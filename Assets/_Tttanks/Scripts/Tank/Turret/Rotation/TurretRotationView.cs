using Tttanks;
using UnityEngine;
using Zenject;

namespace Tttanks
{
    public class TurretRotationView : MonoBehaviour , ITurretRotationView
    {
        private IInputReader _input;
        private IMovementView _movement;
        private Camera _camera;

        public Vector3 Forward => _movement.Forward;

        [Inject]
        public void Construct(IInputReader input, Camera mainCamera, IMovementView movement)
        {
            _input = input;
            _camera = mainCamera;
            _movement = movement;
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
