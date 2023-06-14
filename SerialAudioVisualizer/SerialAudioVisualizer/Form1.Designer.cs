
namespace SerialAudioVisualizer
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ButtonConnect = new System.Windows.Forms.Button();
            this.ButtonUpdate = new System.Windows.Forms.Button();
            this.Box = new System.Windows.Forms.ComboBox();
            this.Output = new System.Windows.Forms.Label();
            this.SerialPort = new System.IO.Ports.SerialPort(this.components);
            this.BoxText = new System.Windows.Forms.TextBox();
            this.ButtonSend = new System.Windows.Forms.Button();
            this.PortPanel = new System.Windows.Forms.Panel();
            this.LableSerial = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Indicator1 = new System.Windows.Forms.Label();
            this.ButtonSerialAudio = new System.Windows.Forms.Button();
            this.ButtonSerialAudioStop = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.AudioBar = new System.Windows.Forms.ProgressBar();
            this.LabelAudio1 = new System.Windows.Forms.Label();
            this.LabelAudio = new System.Windows.Forms.Label();
            this.LabelSmoothing = new System.Windows.Forms.Label();
            this.LabelHorSmooth = new System.Windows.Forms.Label();
            this.LabelVerSmooth = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.PortPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ButtonConnect
            // 
            this.ButtonConnect.Location = new System.Drawing.Point(713, 12);
            this.ButtonConnect.Name = "ButtonConnect";
            this.ButtonConnect.Size = new System.Drawing.Size(75, 23);
            this.ButtonConnect.TabIndex = 0;
            this.ButtonConnect.Text = "Connect";
            this.ButtonConnect.UseVisualStyleBackColor = true;
            this.ButtonConnect.Click += new System.EventHandler(this.ButtonConnect_Click);
            // 
            // ButtonUpdate
            // 
            this.ButtonUpdate.Location = new System.Drawing.Point(713, 41);
            this.ButtonUpdate.Name = "ButtonUpdate";
            this.ButtonUpdate.Size = new System.Drawing.Size(75, 23);
            this.ButtonUpdate.TabIndex = 1;
            this.ButtonUpdate.Text = "Update";
            this.ButtonUpdate.UseVisualStyleBackColor = true;
            this.ButtonUpdate.Click += new System.EventHandler(this.ButtonUpdate_Click);
            // 
            // Box
            // 
            this.Box.FormattingEnabled = true;
            this.Box.Location = new System.Drawing.Point(586, 12);
            this.Box.Name = "Box";
            this.Box.Size = new System.Drawing.Size(121, 21);
            this.Box.TabIndex = 2;
            this.Box.SelectedIndexChanged += new System.EventHandler(this.Box_SelectedIndexChanged);
            // 
            // Output
            // 
            this.Output.AutoSize = true;
            this.Output.Location = new System.Drawing.Point(88, 95);
            this.Output.Name = "Output";
            this.Output.Size = new System.Drawing.Size(33, 13);
            this.Output.TabIndex = 3;
            this.Output.Text = "None";
            // 
            // SerialPort
            // 
            this.SerialPort.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.SerialPort_DataReceived);
            // 
            // BoxText
            // 
            this.BoxText.Location = new System.Drawing.Point(54, 111);
            this.BoxText.Name = "BoxText";
            this.BoxText.Size = new System.Drawing.Size(100, 20);
            this.BoxText.TabIndex = 6;
            // 
            // ButtonSend
            // 
            this.ButtonSend.Location = new System.Drawing.Point(54, 137);
            this.ButtonSend.Name = "ButtonSend";
            this.ButtonSend.Size = new System.Drawing.Size(100, 23);
            this.ButtonSend.TabIndex = 7;
            this.ButtonSend.Text = "Send";
            this.ButtonSend.UseVisualStyleBackColor = true;
            this.ButtonSend.Click += new System.EventHandler(this.ButtonSend_Click);
            // 
            // PortPanel
            // 
            this.PortPanel.BackColor = System.Drawing.SystemColors.ControlDark;
            this.PortPanel.Controls.Add(this.LableSerial);
            this.PortPanel.Controls.Add(this.Output);
            this.PortPanel.Controls.Add(this.BoxText);
            this.PortPanel.Controls.Add(this.ButtonSend);
            this.PortPanel.Enabled = false;
            this.PortPanel.Location = new System.Drawing.Point(12, 52);
            this.PortPanel.Name = "PortPanel";
            this.PortPanel.Size = new System.Drawing.Size(217, 163);
            this.PortPanel.TabIndex = 8;
            // 
            // LableSerial
            // 
            this.LableSerial.AutoSize = true;
            this.LableSerial.Location = new System.Drawing.Point(2, 2);
            this.LableSerial.Name = "LableSerial";
            this.LableSerial.Size = new System.Drawing.Size(33, 13);
            this.LableSerial.TabIndex = 8;
            this.LableSerial.Text = "Serial";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(217, 26);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // Indicator1
            // 
            this.Indicator1.AutoSize = true;
            this.Indicator1.BackColor = System.Drawing.Color.Lime;
            this.Indicator1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.Indicator1.Location = new System.Drawing.Point(12, 12);
            this.Indicator1.Name = "Indicator1";
            this.Indicator1.Padding = new System.Windows.Forms.Padding(50, 0, 50, 0);
            this.Indicator1.Size = new System.Drawing.Size(217, 26);
            this.Indicator1.TabIndex = 10;
            this.Indicator1.Text = "Connected";
            // 
            // ButtonSerialAudio
            // 
            this.ButtonSerialAudio.Location = new System.Drawing.Point(66, 89);
            this.ButtonSerialAudio.Name = "ButtonSerialAudio";
            this.ButtonSerialAudio.Size = new System.Drawing.Size(75, 23);
            this.ButtonSerialAudio.TabIndex = 11;
            this.ButtonSerialAudio.Text = "Start";
            this.ButtonSerialAudio.UseVisualStyleBackColor = true;
            this.ButtonSerialAudio.Click += new System.EventHandler(this.ButtonSerialAudio_Click);
            // 
            // ButtonSerialAudioStop
            // 
            this.ButtonSerialAudioStop.Location = new System.Drawing.Point(66, 118);
            this.ButtonSerialAudioStop.Name = "ButtonSerialAudioStop";
            this.ButtonSerialAudioStop.Size = new System.Drawing.Size(75, 23);
            this.ButtonSerialAudioStop.TabIndex = 13;
            this.ButtonSerialAudioStop.Text = "Stop";
            this.ButtonSerialAudioStop.UseVisualStyleBackColor = true;
            this.ButtonSerialAudioStop.Click += new System.EventHandler(this.ButtonSerialAudioStop_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Controls.Add(this.AudioBar);
            this.panel1.Controls.Add(this.LabelAudio1);
            this.panel1.Controls.Add(this.LabelAudio);
            this.panel1.Controls.Add(this.ButtonSerialAudio);
            this.panel1.Controls.Add(this.ButtonSerialAudioStop);
            this.panel1.Location = new System.Drawing.Point(12, 221);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(217, 144);
            this.panel1.TabIndex = 14;
            // 
            // AudioBar
            // 
            this.AudioBar.Location = new System.Drawing.Point(54, 60);
            this.AudioBar.Name = "AudioBar";
            this.AudioBar.Size = new System.Drawing.Size(100, 23);
            this.AudioBar.TabIndex = 15;
            // 
            // LabelAudio1
            // 
            this.LabelAudio1.AutoSize = true;
            this.LabelAudio1.Location = new System.Drawing.Point(86, 41);
            this.LabelAudio1.Name = "LabelAudio1";
            this.LabelAudio1.Size = new System.Drawing.Size(34, 13);
            this.LabelAudio1.TabIndex = 15;
            this.LabelAudio1.Text = "Audio";
            // 
            // LabelAudio
            // 
            this.LabelAudio.AutoSize = true;
            this.LabelAudio.Location = new System.Drawing.Point(1, 2);
            this.LabelAudio.Name = "LabelAudio";
            this.LabelAudio.Size = new System.Drawing.Size(34, 13);
            this.LabelAudio.TabIndex = 14;
            this.LabelAudio.Text = "Audio";
            // 
            // LabelSmoothing
            // 
            this.LabelSmoothing.AutoSize = true;
            this.LabelSmoothing.Location = new System.Drawing.Point(17, 372);
            this.LabelSmoothing.Name = "LabelSmoothing";
            this.LabelSmoothing.Size = new System.Drawing.Size(57, 13);
            this.LabelSmoothing.TabIndex = 15;
            this.LabelSmoothing.Text = "Smoothing";
            this.LabelSmoothing.Click += new System.EventHandler(this.label1_Click);
            // 
            // LabelHorSmooth
            // 
            this.LabelHorSmooth.AutoSize = true;
            this.LabelHorSmooth.Location = new System.Drawing.Point(17, 389);
            this.LabelHorSmooth.Name = "LabelHorSmooth";
            this.LabelHorSmooth.Size = new System.Drawing.Size(60, 13);
            this.LabelHorSmooth.TabIndex = 16;
            this.LabelHorSmooth.Text = "HorSmooth";
            // 
            // LabelVerSmooth
            // 
            this.LabelVerSmooth.AutoSize = true;
            this.LabelVerSmooth.Location = new System.Drawing.Point(17, 406);
            this.LabelVerSmooth.Name = "LabelVerSmooth";
            this.LabelVerSmooth.Size = new System.Drawing.Size(59, 13);
            this.LabelVerSmooth.TabIndex = 17;
            this.LabelVerSmooth.Text = "VerSmooth";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(108, 372);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 18;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.LabelVerSmooth);
            this.Controls.Add(this.LabelHorSmooth);
            this.Controls.Add(this.LabelSmoothing);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Indicator1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.PortPanel);
            this.Controls.Add(this.Box);
            this.Controls.Add(this.ButtonUpdate);
            this.Controls.Add(this.ButtonConnect);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Serial";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.PortPanel.ResumeLayout(false);
            this.PortPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonConnect;
        private System.Windows.Forms.Button ButtonUpdate;
        private System.Windows.Forms.ComboBox Box;
        private System.Windows.Forms.Label Output;
        private System.IO.Ports.SerialPort SerialPort;
        private System.Windows.Forms.TextBox BoxText;
        private System.Windows.Forms.Button ButtonSend;
        private System.Windows.Forms.Panel PortPanel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label Indicator1;
        private System.Windows.Forms.Button ButtonSerialAudio;
        private System.Windows.Forms.Button ButtonSerialAudioStop;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LabelAudio;
        private System.Windows.Forms.Label LableSerial;
        private System.Windows.Forms.Label LabelAudio1;
        private System.Windows.Forms.ProgressBar AudioBar;
        private System.Windows.Forms.Label LabelSmoothing;
        private System.Windows.Forms.Label LabelHorSmooth;
        private System.Windows.Forms.Label LabelVerSmooth;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}

