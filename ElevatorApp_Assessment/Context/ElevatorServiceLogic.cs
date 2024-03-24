using ElevatorApp_Assessment.Implementation;
using ElevatorApp_Assessment.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElevatorApp_Assessment.Context
{
    public class ElevatorServiceLogic
    {
        private IElevator currentState;
        private int currentFloor;

        public ElevatorServiceLogic()
        {
            currentState = new RestStateImplemetation();
            currentFloor = 1;
        }

        public int CurrentFloor => currentFloor;
        public IElevator CurrentState => currentState;

        public void HandleUpButton()
        {
            currentState.HandleUpButtonState(this);
        }

        public void HandleDownButton()
        {
            currentState.HandleDownButtonState(this);
        }

        public void HandleFloorButton(int floor)
        {
            if (floor < 1 || floor > 5)
            {
                Console.WriteLine($"Invalid floor number: {floor}");
                return;
            }
            currentState.HandleFloorButtonState(this, floor);
        }

        public void HandleDoorOpenButton()
        {
            currentState.HandleOpenDoorButtonState();
        }

        public void HandleDoorCloseButton()
        {
            currentState.HandleCloseDoorButtonState();
        }

        public void TransitionToState(IElevator newState)
        {
            currentState = newState;
        }

    }
}
