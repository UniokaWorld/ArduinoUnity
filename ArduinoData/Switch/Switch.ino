const int DIN_PIN = 7;

void setup() {
  Serial.begin(9600);
}

void loop() {
  int value;
    
  value = digitalRead( DIN_PIN );
  Serial.print( value );
  
  Serial.print("\t"); 
  Serial.println("");
  //delay(1);
}
