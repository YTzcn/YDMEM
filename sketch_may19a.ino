/*
  74HC595 & 74HC165 Shift Register Demonstration
  74hc595-to-74ch165.ino
  Input for 8 pushbuttons using 74HC165
  Output to 0 LEDs using 74HC595
 
  DroneBot Workshop 2020
  https://dronebotworkshop.com
*/
 
// Define Connections to 74HC165
 

int load = 7;// PL pin 1

int clockEnablePin = 4;// CE INH pin 15

int dataIn = 5;// Q7 pin 9

int clockIn = 6;// CP pin 2
 
// Define Connections to 74HC595
 
// ST_CP pin 12
//const int latchPin = 10;
// SH_CP pin 11
//const int clockPin = 11;
// DS pin 14
//const int dataPin = 12;
 
void setup () {
 
  // Setup Serial Monitor
  Serial.begin(9600);
 
  // 74HC165 pins
  pinMode(load, OUTPUT);
  pinMode(clockEnablePin, OUTPUT);
  pinMode(clockIn, OUTPUT);
  pinMode(dataIn, INPUT);
 

 
  digitalWrite(load, LOW);
 
 digitalWrite(clockEnablePin, LOW);
 digitalWrite(clockIn, LOW);
}
 
 
void loop() {
 
  // Read Switches
 
  // Write pulse to load pin
  digitalWrite(load, LOW); 
  delayMicroseconds(10);
  digitalWrite(load, HIGH);
  delayMicroseconds(10);
 
  // Get data from 74HC165
  
  digitalWrite(clockIn, HIGH);
  digitalWrite(clockEnablePin, LOW);
  byte incoming = shiftIn(dataIn, clockIn, LSBFIRST);
 Serial.print("Pin States:\r\n");
  Serial.println(incoming, BIN);
  
   incoming = shiftIn(dataIn, clockIn, LSBFIRST);
   Serial.print("Pin States:\r\n");
  Serial.println(incoming, BIN);

  
  digitalWrite(clockEnablePin, HIGH);
 
  // Print to serial monitor
 
 
 
  // Write to LEDs
 
  // ST_CP LOW to keep LEDs from changing while reading serial data
  
 
  // Shift out the bits
 
 
  // ST_CP HIGH change LEDs
 
 
  delay(500);
 
}
