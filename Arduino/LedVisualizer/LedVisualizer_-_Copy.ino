// #include "FastLED.h"
// #include <GyverOLED.h>

// #define LED_COUNT 120
// #define LED_DT 2

// int max_bright = 255;

// struct CRGB leds[LED_COUNT];

// // Data format is:
// // {12;12;12\n32;32;32\n54;54;54}
// //

// GyverOLED<SSD1306_128x64, OLED_NO_BUFFER> oled;

// void setup() {
//   Serial.begin(9600);
//   Serial.setTimeout(10000);
//   LEDS.setBrightness(max_bright);
//   LEDS.addLeds<WS2812B, LED_DT, GRB>(leds, LED_COUNT);
//   LEDS.show();
//   oled.init();
//   lcp("hello!");
// }

// String income = String();
// int o = -1;

// void loop() {
//   if (Serial.available() > 0) {
//     char firstByte = Serial.read();
//     if (firstByte == '{') {
//       String income = Serial.readStringUntil('}');
//       // int l;
//       // String* income2 = split(income, '\n', l);
//       for (int i = 0;i < LED_COUNT;i++) {
//         String rgb = getValue(income, '\n', i);
//         int r = getValue(rgb, ';', 0).toInt();
//         int g = getValue(rgb, ';', 1).toInt();
//         int b = getValue(rgb, ';', 2).toInt();

//         // String* rgb = split(income2[i], ';', l);
//         // int r = rgb[0].toInt();
//         // int g = rgb[1].toInt();
//         // int b = rgb[2].toInt();
        
        
//         if (o == -1) {
//           o = r;
//         }

//         // if (i == 0) {
//         //   // String tp = rgb + String(" || ") + String(r) + String("|") + String(g) + String("|") + String(b);
//         //   String tp = income;
//         //   Serial.println(tp.c_str());
//         // }

//         if (i == 0) {
//           // Serial.println(r);
//           lcp(income);
//         }
//         leds[i].setRGB(r, g, b);
//         LEDS.show();
//         // delete[] rgb;
//       }
//       // delete[] income2;
//     }
//   }
// }

// String getValue(String data, char separator, int index) {
//   int found = 0;
//   int strIndex[] = {0, -1};
//   int maxIndex = data.length()-1;

//   for(int i=0; i<=maxIndex && found<=index; i++){
//     if(data.charAt(i)==separator || i==maxIndex){
//         found++;
//         strIndex[0] = strIndex[1]+1;
//         strIndex[1] = (i == maxIndex) ? i+1 : i;
//     }
//   }

//   return found>index ? data.substring(strIndex[0], strIndex[1]) : "";
// }

// String* split(String& v, char delimiter, int& length) {
//   length = 1;
//   bool found = false;

//   // Figure out how many itens the array should have
//   for (int i = 0; i < v.length(); i++) {
//     if (v[i] == delimiter) {
//       length++;
//       found = true;
//     }
//   }

//   // If the delimiter is found than create the array
//   // and split the String
//   if (found) {

//     // Create array
//     String* valores = new String[length];

//     // Split the string into array
//     int i = 0;
//     for (int itemIndex = 0; itemIndex < length; itemIndex++) {
//       for (; i < v.length(); i++) {

//         if (v[i] == delimiter) {
//           i++;
//           break;
//         }
//         valores[itemIndex] += v[i];
//       }
//     }

//     // Done, return the values
//     return valores;
//   }

//   // No delimiter found
//   return nullptr;
// }

// void lcp(String text) {
//   oled.clear();
//   oled.home();
//   oled.print(text);
//   oled.update();
// }






// ==========================================




