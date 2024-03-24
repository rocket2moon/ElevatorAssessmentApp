using ElevatorApp_Assessment.Context;
using ElevatorApp_Assessment.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElevatorApp_Assessment.Implementation
{
    /// <summary>
    /// This is a concrete state representing the elevator at rest
    /// </summary>
    public class RestStateImplemetation : IElevator
    {
        public void HandleCloseDoorButtonState()
        {
            Console.WriteLine("Doors are already closed.");
        }

        public void HandleOpenDoorButtonState()
        {
                Console.WriteLine("Doors are opening...");

                // Simulate door opening
                Thread.Sleep(1000); 

                Console.WriteLine("Doors are opened");  
        }

        public void HandleDownButtonState(ElevatorServiceLogic elevator)
        {
            Console.WriteLine("Moving the elevator down because down button was pressed");
            elevator.TransitionToState(new MovingDownStateImplementation());
        }

        public void HandleFloorButtonState(ElevatorServiceLogic elevator, int floor)
        {
            Console.WriteLine($"The elevator is now in floor {floor}");
        }

        public void HandleUpButtonState(ElevatorServiceLogic elevator)
        {
            Console.WriteLine("Moving the elevator up because up button was pressed...");
            elevator.TransitionToState(new MovingUpStateImplementation());
        }
    }
}
