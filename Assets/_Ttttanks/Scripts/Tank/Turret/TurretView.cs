using System;
using Tttanks;
using UnityEngine;
using Zenject;

namespace Ttttanks
{
    public class TurretView : MonoBehaviour , ITurretView
    {
        private IInputReader _input;
        private IMovementView _playerMovement;
        private Camera _camera;

        public Vector3 Forward => _playerMovement.Forward;

        [Inject]
        public void Construct(IInputReader input, Camera mainCamera, IMovementView playerMovement)
        {
            _input = input;
            _camera = mainCamera;
            _playerMovement = playerMovement;
        }
        
        public Vector3 GetMousePosition()
        {
            float depth = _camera.WorldToScreenPoint(transform.position).z;

            return _camera.ScreenToWorldPoint(new Vector3(
                _input.LookDirection.x,
                _input.LookDirection.y,
                depth
            ));
        }
        
        public Vector3 GetTransformPosition() => transform.position;
        public Quaternion GetRotation() => transform.rotation;

        public void Rotate(Quaternion rotation)
        {
            transform.rotation = rotation;
        }
    }
}
