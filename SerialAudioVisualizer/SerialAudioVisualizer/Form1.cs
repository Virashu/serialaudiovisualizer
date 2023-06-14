using System;
using System.Windows.Forms;
using System.IO.Ports;
using NAudio.Wave;
using System.Numerics;
using MathNet.Numerics.IntegralTransforms;
using System.Collections.Generic;
using System.Linq;

namespace SerialAudioVisualizer
{
    internal enum SmoothType
    {
        Horizontal,
        Vertical,
        Both
    }

    public partial class Form1 : Form
    {
        private bool _connected;
        public int level;

        private WaveBuffer buffer;

        private static int _verticalSmoothness = 3;
        private static int _horizontalSmoothness = 1;
        private float size = 10;
        private const float intensity = 100;

        private static SmoothType _smoothType = SmoothType.Both;

        private readonly List<Complex[]> smooth = new List<Complex[]>();

        private Complex[] values;

        private const int Count = 60;
        private bool capturing;

        public Form1()
        {
            InitializeComponent();
            Timer tmr = new Timer();
            tmr.Interval = 50;   // milliseconds
            tmr.Tick += Tmr_Tick;  // set handler
            tmr.Start();
        }

        private void Tmr_Tick(object sender, EventArgs e)
        {
            if (capturing) AudioUpdate();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _connected = false;
            capturing = false;
            Indicator1.Visible = false;
            PortPanel.Enabled = false;
            //panel1.Enabled = false;
        }

        private void ButtonConnect_Click(object sender, EventArgs e)
        {
            if (!_connected)
            {
                try
                {
                    SerialPort.PortName = Box.Text;
                    SerialPort.BaudRate = 115200;
                    SerialPort.Open();
                    _connected = true;
                    Box.Enabled = false;
                    ButtonConnect.Text = "Disconnect";
                }
                catch
                {
                    MessageBox.Show("Connection error.");
                }
            }
            else
            {
                SerialPort.Close();
                _connected = false;
                Box.Enabled = true;
                ButtonConnect.Text = "Connect";
            }

            Indicator1.Visible = _connected;
            PortPanel.Enabled = _connected;
            //panel1.Enabled = _connected;
        }

        private void ButtonUpdate_Click(object sender, EventArgs e)
        {
            string[] ports = SerialPort.GetPortNames();
            Box.Text = "";
            Box.Items.Clear();

            if (ports.Length != 0)
            {
                Box.Items.AddRange(ports);
                Box.SelectedIndex = 0;
            }
        }

        private void Box_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void SerialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                Output.Text = $@"Data: {SerialPort.ReadByte()}";
            } catch { }
        }

        private float Average(double[] nums)
        {
            return (float)(Enumerable.Sum(nums) / nums.Length);
        }

        private void ButtonSend_Click(object sender, EventArgs e)
        {
            byte[] sendByte = new byte[1];
            sendByte[0] = 234;
            SerialPort.Write(sendByte, 0, 1);
            /*
            string text = BoxText.Text;
            int sendInt = Convert.ToInt32(text);
            byte[] buffer1 = new byte[1] { Convert.ToByte(sendInt) };
            SerialPort.Write(buffer1, 0, 1);
            */
        }

        private void ButtonSerialAudio_Click(object sender, EventArgs e)
        {
            if (!capturing)
            {
                var capture = new WasapiLoopbackCapture();
                capture.DataAvailable += CapDataAvailable;
                capture.RecordingStopped += (s, a) => { capture.Dispose(); };
                capture.StartRecording();
                capturing = true;
            }
            LabelHorSmooth.Text = "Vertical smoothness: " + _horizontalSmoothness.ToString();
            LabelVerSmooth.Text = "Vertical smoothness: " + _verticalSmoothness.ToString();
            switch (_smoothType)
            {
                case SmoothType.Both:
                    LabelSmoothing.Text = "Smoothing: both";
                    break;
                case SmoothType.Vertical:
                    LabelSmoothing.Text = "Smoothing: vertial";
                    break;
                case SmoothType.Horizontal:
                    LabelSmoothing.Text = "Smoothing: horizontal";
                    break;
            }
        }

        private void ButtonSerialAudioStop_Click(object sender, EventArgs e)
        {
            var capture = new WasapiLoopbackCapture();
            capture.StopRecording();
            capturing = false;
        }

        private void CapDataAvailable(object sender, WaveInEventArgs e)
        {
            buffer = new WaveBuffer(e.Buffer); // save the buffer in the class variable

            int len = buffer.FloatBuffer.Length / 8;

            // fft
            values = new Complex[len];
            for (var i = 0; i < len; i++)
                values[i] = new Complex(buffer.FloatBuffer[i], 0.0);
            Fourier.Forward(values, FourierOptions.Default);

            // shift array
            if (_smoothType == SmoothType.Vertical || _smoothType == SmoothType.Both)
            {
                smooth.Add(values);
                if (smooth.Count > _verticalSmoothness)
                    smooth.RemoveAt(0);
            }
        }

        private void AudioUpdate()
        {
            var visValues = new double[Count];

            switch (_smoothType)
            {
                case SmoothType.Vertical:
                    {
                        for (var i = 0; i < Count; i++)
                            visValues[i] = VSmooth(i, smooth.ToArray());
                        break;
                    }
                case SmoothType.Horizontal:
                    {
                        for (var i = 0; i < Count; i++)
                            visValues[i] = HSmooth(i);
                        break;
                    }
                case SmoothType.Both:
                    {
                        for (var i = 0; i < Count; i++)
                            visValues[i] = BothSmooth(i);
                        break;
                    }
            }

            string tp = "{";

            for (var i = Count - 1; i >= 0; i--)
            {
                if (visValues[i] is double.NaN)
                {
                    return;
                }
                tp += Convert.ToInt32(Math.Min(Math.Max(visValues[i], 0), 255)*intensity).ToString();
                if (i != 0)
                {
                    tp += "|";
                }
            }

            tp += "|";
            for (var i = 0; i < Count; i++)
            {
                tp += Convert.ToInt32(Math.Min(Math.Max(visValues[i], 0), 255)*intensity).ToString();
                if (i != Count - 1)
                {
                    tp += "|";
                }
            }

            tp += "}";

            int vl = Convert.ToInt32(Math.Min(Math.Max(Average(visValues) * 100, 0), 100));
            // Console.WriteLine(vl);

            AudioBar.Value = vl;

            Console.WriteLine(tp + "  \n " + tp.Length);

            if (_connected) { SerialPort.Write(tp); }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode) {
                case Keys.Right:
                    _horizontalSmoothness++;
                    LabelHorSmooth.Text = "Vertical smoothness: " + _horizontalSmoothness.ToString();
                    break;
                case Keys.Left:
                    if (_horizontalSmoothness > 1)
                        _horizontalSmoothness--;
                    LabelHorSmooth.Text = "Vertical smoothness: " + _horizontalSmoothness.ToString();
                    break;
                case Keys.Down:
                    if (_verticalSmoothness > 1)
                    {
                        _verticalSmoothness--;
                        for (int i = 0; i < smooth.Count; i++)
                            smooth.RemoveAt(i);
                    }
                    LabelVerSmooth.Text = "Vertical smoothness: " + _verticalSmoothness.ToString();
                    break;
                case Keys.Up:
                    _verticalSmoothness++;
                    for (int i = 0; i < smooth.Count; i++)
                        smooth.RemoveAt(i);
                    LabelVerSmooth.Text = "Vertical smoothness: " + _verticalSmoothness.ToString();
                    break;
                case Keys.H:
                    _smoothType = SmoothType.Horizontal;
                    LabelSmoothing.Text = "Smoothing: horizontal";
                    break;
                case Keys.V:
                    _smoothType = SmoothType.Vertical;
                    LabelSmoothing.Text = "Smoothing: vertical";
                    break;
                case Keys.B:
                    _smoothType = SmoothType.Both;
                    LabelSmoothing.Text = "Smoothing: both";
                    break;
            }
        }

        private double BothSmooth(int i)
        {
            var s = smooth.ToArray();

            double value = 0;

            for (int h = Math.Max(i - _horizontalSmoothness, 0); h < Math.Min(i + _horizontalSmoothness, 64); h++)
                value += VSmooth(h, s);

            return value / ((_horizontalSmoothness + 1) * 2);
        }

        private double VSmooth(int i, Complex[][] s)
        {
            double value = 0;

            for (var v = 0; v < s.Length; v++)
                value += Math.Abs(s[v] != null ? s[v][i].Magnitude : 0.0);

            return value / s.Length;
        }

        private double HSmooth(int i)
        {
            double value = 0;
            for (int h = Math.Max(i - _horizontalSmoothness, 0);
                 h < Math.Min(i + _horizontalSmoothness, 64);
                 h++)
                value += values[h].Magnitude;
            return value / ((_horizontalSmoothness + 1) * 2);
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.ExitThread();

            Environment.Exit(0);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}