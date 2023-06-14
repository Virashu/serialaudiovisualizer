#include <GyverOLED.h>
#include "FastLED.h"


#define LED_COUNT 120
#define LED_DT 2

int max_bright = 255;
struct CRGB leds[LED_COUNT];

void setup() {
  Serial.begin(115200);
  Serial.setTimeout(5);
  LEDS.setBrightness(max_bright);
  LEDS.addLeds<WS2812B, LED_DT, GRB>(leds, LED_COUNT);
  LEDS.show();
}


int brt;

void loop() {
  if (Serial.available()) {
    char first = Serial.read();
    if (first == '{') {
      char data[419];
      int amount = Serial.readBytesUntil('}', data, 419);
      data[amount] = NULL;

      char *offset = data;
      int i = 0;

      while (true) {
        brt = atoi(offset);
        leds[i++].setRGB(brt, brt, brt);
        offset = strchr(offset, '|');
        if (offset) offset++;
        else break;
      }
      LEDS.show();
    }
  }
}
