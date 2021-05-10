#include <Stepper.h>

//settings for the stepperMotor
const int32_t stepsPerRevolution = 32;
const int32_t gearReduction = 64;
const int32_t stepsPerRound = stepsPerRevolution * gearReduction;

char input;
const int32_t motorSpeed = 1200;
int32_t stepsRequired = 0;
int32_t currentPosition = 0;
int32_t requestedPosition;


// Create Instance of Stepper Class
// Specify Pins used for motor coils
// The pins used are 8,9,10,11
// Connected to ULN2003 Motor Driver In1, In2, In3, In4
// Pins entered in sequence 1-3-2-4 for proper step sequencing
Stepper stepperMotor (stepsPerRevolution, 8, 10, 9, 11);

void setup() {
  // put your setup code here, to run once:
  Serial.begin(9600);
}

void loop() {
  while (Serial.available() > 0)
  {
    input = Serial.read();

    if (input == '0') {
      stepsRequired = (0 * stepsPerRound) - (currentPosition / stepsPerRound);
      stepperMotor.setSpeed(motorSpeed);
      stepperMotor.step((stepsRequired - currentPosition) / 25);
      currentPosition = (0 * stepsPerRound);
      digitalWrite(8, LOW);
      digitalWrite(10, LOW);
      digitalWrite(9, LOW);
      digitalWrite(11, LOW);
    }
    else if (input == '1') {
      stepsRequired = (25 * stepsPerRound) - (currentPosition / stepsPerRound);
      stepperMotor.setSpeed(motorSpeed);
      stepperMotor.step((stepsRequired - currentPosition) / 25);
      currentPosition = (25 * stepsPerRound);
      digitalWrite(8, LOW);
      digitalWrite(10, LOW);
      digitalWrite(9, LOW);
      digitalWrite(11, LOW);
    }
    else if (input == '2') {
      stepsRequired = (50 * stepsPerRound) - (currentPosition / stepsPerRound);
      stepperMotor.setSpeed(motorSpeed);
      stepperMotor.step((stepsRequired - currentPosition) / 25);
      currentPosition = (50 * stepsPerRound);
      digitalWrite(8, LOW);
      digitalWrite(10, LOW);
      digitalWrite(9, LOW);
      digitalWrite(11, LOW);
    }
    else if (input == '3') {
      stepsRequired = (75 * stepsPerRound) - (currentPosition / stepsPerRound);
      stepperMotor.setSpeed(motorSpeed);
      stepperMotor.step((stepsRequired - currentPosition) / 25);
      currentPosition = (75 * stepsPerRound);
      digitalWrite(8, LOW);
      digitalWrite(10, LOW);
      digitalWrite(9, LOW);
      digitalWrite(11, LOW);
    }
    else if (input == '4') {
      stepsRequired = (100 * stepsPerRound) - (currentPosition / stepsPerRound);
      stepperMotor.setSpeed(motorSpeed);
      stepperMotor.step((stepsRequired - currentPosition) / 25);
      currentPosition = (100 * stepsPerRound);
      digitalWrite(8, LOW);
      digitalWrite(10, LOW);
      digitalWrite(9, LOW);
      digitalWrite(11, LOW);
    }
    else if (input == 'd') {
      if (currentPosition <= (95 * stepsPerRound)) {
        stepsRequired = (5 * stepsPerRound);
        stepperMotor.setSpeed(motorSpeed);
        stepperMotor.step(stepsRequired / 25);
        currentPosition = (currentPosition + stepsRequired);
        digitalWrite(8, LOW);
        digitalWrite(10, LOW);
        digitalWrite(9, LOW);
        digitalWrite(11, LOW);
      }
    }
    else if (input == 'u') {
           if (currentPosition >= (5 * stepsPerRound)) {
        stepsRequired = (-5 * stepsPerRound);
        stepperMotor.setSpeed(motorSpeed);
        stepperMotor.step(stepsRequired / 25);
        currentPosition = (currentPosition + stepsRequired);
        digitalWrite(8, LOW);
        digitalWrite(10, LOW);
        digitalWrite(9, LOW);
        digitalWrite(11, LOW);
      }
    }
  }
}
