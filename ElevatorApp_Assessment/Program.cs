// See https://aka.ms/new-console-template for more information
using ElevatorApp_Assessment.Context;

ElevatorServiceLogic elevator = new ElevatorServiceLogic();

// Simulating elevator operation based on a predefined scenario
elevator.HandleDoorOpenButton();
elevator.HandleFloorButton(3);
elevator.HandleFloorButton(5);
elevator.HandleUpButton();
elevator.HandleFloorButton(2);
elevator.HandleFloorButton(1);
elevator.HandleDownButton();

Console.ReadLine();
