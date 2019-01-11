
//resetFunc
void(* resetFunc) (void) = 0;
//LCD_init
#include <Wire.h> 
#include <LiquidCrystal_I2C.h>
LiquidCrystal_I2C lcd(0x27, 16, 2); 

//LED_init
int LEDred=5;
int LEDgreen=6;
int LEDblue=7;
bool isLogin=false;

//IR_init
#include <IRremote.h>
int RECV_PIN = 11;
IRrecv irrecv(RECV_PIN);
decode_results results;
int intReceivedMsg;

//DHT_init
#include "DHT.h"
#define dhtPin 8      //讀取DHT11 Data
#define dhtType DHT11 //選用DHT11   
DHT dht(dhtPin, dhtType); // Initialize DHT sensor

void setup() {  
  lcd.begin(); //In the setup part we are starting the LCD (without anything
  //inside the brackets, because we defined the LCD already).
  pinMode(LEDred, OUTPUT);
  pinMode(LEDgreen, OUTPUT);
  pinMode(LEDblue, OUTPUT);

  //IR
  Serial.begin(9600);
  digitalWrite(LEDred, LOW);
  irrecv.enableIRIn();

  //serial port
  Serial.begin(9600);
  pinMode(2,OUTPUT);
  pinMode(3,OUTPUT);
  pinMode(4,OUTPUT);
  pinMode(5,OUTPUT);
  pinMode(6,OUTPUT);
  pinMode(7,OUTPUT);
  pinMode(8,OUTPUT);
  //DHT setup
  dht.begin();
}

void loop() {
  
  //serial
  if(Serial.available()>0)
  {    
    intReceivedMsg=Serial.read();
    //LED
    digitalWrite (LEDred, LOW);
    digitalWrite (LEDgreen, LOW);
    digitalWrite (LEDblue, LOW);    
    digitalWrite (LEDred, HIGH);
    lcd.noBacklight();    
    delay(200);
    digitalWrite (LEDred, LOW);
    lcd.backlight();    
    delay(100);
    digitalWrite (LEDblue, HIGH);
    lcd.noBacklight();    
    delay(200);
    digitalWrite (LEDblue, LOW);     
    lcd.backlight();    
    delay(100);
    digitalWrite (LEDgreen, HIGH);    
    lcd.noBacklight();    
    delay(200);
    digitalWrite (LEDgreen, LOW);     
    lcd.backlight();    
    
    
    if(intReceivedMsg==49)//Lisa #1
    {
      //led
      digitalWrite(LEDgreen,HIGH);
      //lcd
      lcd.setCursor(0,0);   
      lcd.print("Welcome, Lisa   ");
      lcd.setCursor(0,1); 
      lcd.print(intReceivedMsg);
      //loginStatus
      isLogin=true;
    }
    if(intReceivedMsg==50) //Vincent #2
    {
      //led
      digitalWrite(LEDgreen,HIGH);
      //lcd
      lcd.setCursor(0,0);   
      lcd.print("Welcome, Vincent");
      lcd.setCursor(0,1); 
      lcd.print(intReceivedMsg);
      //loginStatus
      isLogin=true;
    }
    if(intReceivedMsg==51) //COM port is turn on #3
    {
      //led
      digitalWrite(LEDblue,HIGH);
      //lcd
      lcd.setCursor(0,0);   
      lcd.print("PORT is opening  ");
      lcd.setCursor(0,1); 
      lcd.print(intReceivedMsg);
      //loginStatus
      isLogin=true;
    }
    if(intReceivedMsg==57) //COM port is turn off
    {
      //led
      digitalWrite(LEDblue,LOW);
      //lcd
      lcd.setCursor(0,0);   
      lcd.print("PORT is closed   ");
      lcd.setCursor(0,1); 
      lcd.print(intReceivedMsg);
      //loginStatus
      isLogin=false;
    }
    if(intReceivedMsg==48)
    {
      //led
      digitalWrite(LEDred,HIGH);
      //lcd
      lcd.setCursor(0,0);   
      lcd.print("!!Invalid User!!");
      lcd.setCursor(0,1); 
      lcd.print(intReceivedMsg);
    }     
  }
  //lcd
  //lcd.setCursor(0,0); //At the loop part the I²C LCD is programed just like the
  //simple LED
  //lcd.print("Welcome,        ");
  //lcd.setCursor(0,1); // lcd.setCursor to define sign and row where the text
  //should start
  //lcd.print("PPT will let you."); // lcd.print to show text on the LCD
  
  //3color led
  //digitalWrite(LEDblue, HIGH);
  //digitalWrite(LEDred, HIGH);
  if (isLogin == true)  
  {
    //IR
    if (irrecv.decode(&results)) {
      Serial.println(results.value, DEC);
      lcd.setCursor(0,1);
      lcd.print("                ");//lcd.print(results.value);
      if (results.value == 16724175) //If The IR receiver receives the number
      //16724175 (button 1)...
      {
        lcd.print("IR code: 1");
        digitalWrite (LEDred, HIGH);
        delay(1000);
        digitalWrite (LEDred, LOW);
              //lcd    
        lcd.setCursor(0,1); 
        lcd.print("TEMP.:");
        lcd.setCursor(6,1); 
        lcd.print(dht.readTemperature());
      } //...the LED gets turned on.
      if (results.value == 16718055) //If the IR receiver receives the number
      //16718055 (button 2)...
      {
        lcd.print("IR code: 2");
        digitalWrite (LEDblue, HIGH);
        delay(1000);
        digitalWrite (LEDblue, LOW);
        //show humidity
        lcd.setCursor(0,1); 
        lcd.print("HUMI.:");
        lcd.setCursor(6,1); 
        lcd.print(dht.readHumidity());
      } //….the LED gets turned off.
      if (results.value == 16743045) //If the IR receiver receives the number
      //16743045 (button 3)...
      {
        lcd.print("IR code: 3");
        digitalWrite (LEDblue, HIGH);
        delay(1000);
        digitalWrite (LEDblue, LOW);
      } //….the LED gets turned off.
      if (results.value == 16716015) //If the IR receiver receives the number
      //16716015 (button 4)...
      {
        lcd.print("IR code: 4");
        digitalWrite (LEDblue, HIGH);
        delay(1000);
        digitalWrite (LEDblue, LOW);
      } //….the LED gets turned off.
      if (results.value == 16726215) //If the IR receiver receives the number
      //16726215 (button 5)...
      {
        lcd.print("IR code: 5");
        digitalWrite (LEDblue, HIGH);
        delay(1000);
        digitalWrite (LEDblue, LOW);
      } //….the LED gets turned off.
       if (results.value == 16734885) //If the IR receiver receives the number
      //16734885 (button 6)...
      {
        lcd.print("IR code: 6");
        digitalWrite (LEDblue, HIGH);
        delay(1000);
        digitalWrite (LEDblue, LOW);
      } //….the LED gets turned off.
       if (results.value == 16728765) //If the IR receiver receives the number
      //16728765 (button 7)...
      {
        lcd.print("IR code: 7");
        digitalWrite (LEDblue, HIGH);
        delay(1000);
        digitalWrite (LEDblue, LOW);
      } //….the LED gets turned off.
       if (results.value == 16730805) //If the IR receiver receives the number
      //16730805 (button 8)...
      {
        lcd.print("IR code: 8");
        digitalWrite (LEDblue, HIGH);
        delay(1000);
        digitalWrite (LEDblue, LOW);
      } //….the LED gets turned off.
       if (results.value == 16732845) //If the IR receiver receives the number
      //16732845 (button 9)...
      {
        lcd.print("IR code: 9");
        digitalWrite (LEDblue, HIGH);
        delay(1000);
        digitalWrite (LEDblue, LOW);
      } //….the LED gets turned off.
       if (results.value == 16738455) //If the IR receiver receives the number
      //16738455 (button 0)...
      {
        lcd.print("Reset");
        resetFunc();
        digitalWrite (LEDblue, HIGH);
        delay(1000);
        digitalWrite (LEDblue, LOW);
      } //….the LED gets turned off.
       if (results.value == 16756815) //If the IR receiver receives the number
      //16756815 (button UI/SD)...
      {        
        lcd.print("IR code: UI/SD");
        digitalWrite (LEDblue, HIGH);
        delay(1000);
        digitalWrite (LEDblue, LOW);
      } //….the LED gets turned off.
       if (results.value == 16750695) //If the IR receiver receives the number
      //16750695 (button REV)...
      {
        //Logout
        digitalWrite (LEDgreen, LOW);
        isLogin=false;
        lcd.setCursor(0,0);   
        lcd.print("Goodbye(logout)");        
        digitalWrite (LEDblue, HIGH);
        lcd.noBacklight();
        delay(500);
        digitalWrite (LEDblue, LOW);
        lcd.backlight();
        delay(500);
        digitalWrite (LEDblue, HIGH);
        lcd.noBacklight();
        delay(500);
        digitalWrite (LEDblue, LOW);
        lcd.backlight();
        delay(500);
        digitalWrite (LEDblue, HIGH);
        lcd.noBacklight();
        delay(500);
        digitalWrite (LEDblue, LOW);
        lcd.backlight();                
      } //….the LED gets turned off.        
      irrecv.resume(); // Receive the next value
    }
  }  
}
