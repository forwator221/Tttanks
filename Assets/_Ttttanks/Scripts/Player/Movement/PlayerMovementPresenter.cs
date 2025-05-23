using UnityEngine;
using Zenject;

namespace Tttanks
{
    public class PlayerMovementPresenter : ITickable
    {
        private readonly IMovementView _view;
        private readonly IMovementModel _model;

        [Inject]
        public PlayerMovementPresenter( IMovementView view, IMovementModel model)
        {
            _view = view;
            _model = model;
        }

        public void Tick()
        {
            var input = _view.GetInput();
            MovePlayer(input);
            RotatePlayer(input);
        }

        private void MovePlayer(Vector2 input)
        {
            var movement = _model.CalculateMovement(input, _view.Forward);
            _view.Move(movement);
        }

        private void RotatePlayer(Vector2 input)
        {
            var rotation = _model.CalculateRotation(input);
            _view.Rotate(rotation);
        }
    }
}