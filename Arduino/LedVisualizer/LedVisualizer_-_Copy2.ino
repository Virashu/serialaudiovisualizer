// #include <GyverOLED.h>
// #include "FastLED.h"


// #define LED_COUNT 120
// #define LED_DT 2

// GyverOLED<SSD1306_128x64, OLED_NO_BUFFER> oled;
// struct CRGB leds[LED_COUNT];
// int max_bright = 255;

// void setup() {
//   Serial.begin(9600);
//   LEDS.setBrightness(max_bright);
//   Serial.setTimeout(5);
//   LEDS.addLeds<WS2812B, LED_DT, GRB>(leds, LED_COUNT);
//   LEDS.show();
//   oled.init();
//   lcp(String("Hello!"));
// }

// String income;

// void loop() {
//   if (Serial.available() > 0) {
//     char first = Serial.read();
//     if (first == '{') {
//       income = Serial.readStringUntil('}');
//       // int l;
//       // String* income_s = split(income, '|', l);
//       // lcp(String(income.length()));
//       for (int i=0;i<LED_COUNT;i++) {
//         // int brt = income_s[i].toInt();
//         int brt = getValue(income, '|', i).toInt();
//         if (i == 0) {
//           lcp(String(brt));
//         }
//         brt = min(max(brt, 0), 255);
//         leds[i].setRGB(brt, brt, brt);
        
//       }
//       // delete[] income_s;
//       LEDS.show();
//     }
//   }
// }

// String getValue(String data, char separator, int index) {
//   int found = 0;
//   int strIndex[] = {0, -1};
//   int maxIndex = data.length() - 1;

//   for(int i = 0; i <= maxIndex && found <= index; i++){
//     if(data.charAt(i) == separator || i == maxIndex){
//         found++;
//         strIndex[0] = strIndex[1] + 1;
//         strIndex[1] = (i == maxIndex) ? i + 1 : i;
//     }
//   }

//   return found>index ? data.substring(strIndex[0], strIndex[1]) : "";
// }

// // String split(String data, chat sep, int index) {
// //   for (int i = 0; i)
// // }

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