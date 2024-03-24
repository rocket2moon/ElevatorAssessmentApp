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
    /// this is a concrete state representing the elevator moving down
    /// </summary>
    public class MovingDownStateImplementation : IElevator
    {

        public void HandleCloseDoorButtonState()
        {
            Console.WriteLine("The elevator door is already closed");
        }

        public void HandleOpenDoorButtonState()
        {
            Console.WriteLine("The elevator door can not be open while elevator is on moving state");
        }

        public void HandleDownButtonState(ElevatorServiceLogic elevator)
        {
            Console.WriteLine("Elevator is already moving down");
        }

        public void HandleFloorButtonState(ElevatorServiceLogic elevator, int floor)
        {
            Console.WriteLine($"Moving the elevator down to floor {floor}");
            elevator.TransitionToState(new MovingDownStateImplementation());
        }

        public void HandleUpButtonState(ElevatorServiceLogic elevator)
        {
            Console.WriteLine("The elevator direction can not be change while elevator is on moving state");
        }
    }
}
