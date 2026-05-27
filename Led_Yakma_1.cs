int red=4;
int blue=2;
int green=3;


void setup() {
  pinMode(red,OUTPUT);
  pinMode(blue,OUTPUT);
  pinMode(green,OUTPUT);

  digitalWrite(red,1);
  digitalWrite(blue,1);
  digitalWrite(green,1);
  delay(2000);
  digitalWrite(red,0);
  digitalWrite(blue,0);
  digitalWrite(green,0);

  // put your setup code here, to run once:

}

void loop() {
  digitalWrite(red,1);
  delay(400);
  digitalWrite(red,0);
  digitalWrite(blue,1);
  delay(400);
  digitalWrite(blue,0);
  digitalWrite(green,1);
  delay(400);
  digitalWrite(green,0);
  

  // put your main code here, to run repeatedly:

}
