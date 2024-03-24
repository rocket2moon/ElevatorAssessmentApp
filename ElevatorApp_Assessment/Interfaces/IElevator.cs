using ElevatorApp_Assessment.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElevatorApp_Assessment.Interfaces
{
    public interface IElevator
    {
        void HandleUpButtonState(ElevatorServiceLogic elevator);
        void HandleDownButtonState(ElevatorServiceLogic elevator);
        void HandleCloseDoorButtonState();
        void HandleOpenDoorButtonState();
        void HandleFloorButtonState(ElevatorServiceLogic elevator, int floor);
    }
}
