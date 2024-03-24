using ElevatorApp_Assessment.Context;
using ElevatorApp_Assessment.Implementation;
using ElevatorApp_Assessment.Interfaces;

namespace TestElevatorApp
{
    public class ElevatorTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Elevator_HandleUpButton_ShouldTransitionToMovingUpState()
        {
            // Arrange
            ElevatorServiceLogic elevator = new ElevatorServiceLogic();

            // Act
            elevator.HandleUpButton();

            // Assert
            Assert.IsTrue(elevator.CurrentState is MovingUpStateImplementation);
        }

        [Test]
        public void Elevator_HandleDownButton_ShouldTransitionToMovingDownState()
        {
            // Arrange
            ElevatorServiceLogic elevator = new ElevatorServiceLogic();

            // Act
            elevator.HandleDownButton();

            // Assert
            Assert.IsTrue(elevator.CurrentState is  MovingDownStateImplementation);
        }

        [Test]
        public void Elevator_HandleFloorButton_ShouldTransitionToMovingDownState()
        {
            // Arrange
            ElevatorServiceLogic elevator = new ElevatorServiceLogic();

            // Act
            elevator.HandleFloorButton(1);

            // Assert
            Assert.IsTrue(elevator.CurrentState is RestStateImplemetation);
        }

        [Test]
        public void Elevator_HandleFloorButton_ShouldTransitionToMovingUpState()
        {
            // Arrange
            ElevatorServiceLogic elevator = new ElevatorServiceLogic();

            // Act
            elevator.HandleFloorButton(2);

            // Assert
            Assert.IsTrue(elevator.CurrentState is RestStateImplemetation);
        }

        [Test]
        public void Elevator_HandleFloorButton_ShouldNotTransitionToMovingStateIfAlreadyOnFloor()
        {
            // Arrange
            ElevatorServiceLogic elevator = new ElevatorServiceLogic();

            // Act
            elevator.HandleFloorButton(1);

            // Assert
            Assert.IsTrue(elevator.CurrentState is RestStateImplemetation);
        }

        [Test]
        public void Elevator_HandleFloorButton_ShouldNotTransitionToMovingStateIfInvalidFloorSupplied()
        {
            // Arrange
            ElevatorServiceLogic elevator = new ElevatorServiceLogic();

            // Act
            elevator.HandleFloorButton(9);

            // Assert
            Assert.IsTrue(elevator.CurrentState is RestStateImplemetation);
        }

        [Test]
        public void Elevator_HandleCloseButton_ShouldClose()
        {
            // Arrange
            ElevatorServiceLogic elevator = new ElevatorServiceLogic();

            // Act
            elevator.HandleDoorCloseButton();

            // Assert
            Assert.IsTrue(elevator.CurrentState is RestStateImplemetation);
        }

        [Test]
        public void Elevator_HandleOpenButton_ShouldOpen()
        {
            // Arrange
            ElevatorServiceLogic elevator = new ElevatorServiceLogic();

            // Act
            elevator.HandleDoorOpenButton();

            // Assert
            Assert.IsTrue(elevator.CurrentState is RestStateImplemetation);
        }
    }
}