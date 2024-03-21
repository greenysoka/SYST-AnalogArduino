byte LED_Pin = 12;
byte bytEmpfang = 0; 
void setup() 
{
  Serial.begin(9600);
  pinMode(LED_Pin, OUTPUT);

}

void loop() 
{
  if(Serial.available()){
    bytEmpfang = Serial.read();
  }
  analogWrite(LED_Pin, bytEmpfang);

}
