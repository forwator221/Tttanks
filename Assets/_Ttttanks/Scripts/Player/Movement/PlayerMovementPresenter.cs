using UnityEngine;
using Zenject;

namespace Ttttanks
{
    public class PlayerMovementPresenter : ITickable
    {
        private readonly PlayerMovementView _view;
        private readonly PlayerMovementModel _model;
        private readonly IInputReader _input;

        [Inject]
        public PlayerMovementPresenter( PlayerMovementView view, PlayerMovementModel model, IInputReader input)
        {
            _view = view;
            _model = model;
            _input = input;
        }

        public void Tick()
        {
            MovePlayer();
            RotatePlayer();
        }

        private void MovePlayer()
        {
            var movement = CalculateMovement(_input.MoveDirection);
            _view.Move(movement);
        }

        private void RotatePlayer()
        {
            var rotation = CalculateRotation(_input.MoveDirection);
            _view.Rotate(rotation);
        }

        private Vector3 CalculateMovement(Vector2 input)
        {
            var verticalInput = input.y;
            var movement = _view.Forward * (verticalInput * _model.MovementSpeed * Time.deltaTime);
            return movement;
        }

        private Vector3 CalculateRotation(Vector2 input)
        {
            var horizontalInput = input.x;
            var rotation = Vector3.up * (horizontalInput * _model.RotationSpeed * Time.deltaTime);
            return rotation;
        }
    }
}