using UnityEngine;
using Zenject;

namespace Tttanks
{
    public class TurretRotationPresenter : ITickable
    {
        private readonly ITurretRotationView _rotationView;
        private readonly ITurretRotationModel _rotationModel;

        [Inject]
        public TurretRotationPresenter(ITurretRotationView rotationView, ITurretRotationModel rotationModel)
        {
            _rotationView = rotationView;
            _rotationModel = rotationModel;
        }

        public void Tick()
        {
            var input = _rotationView.GetMousePosition();
            var turret = _rotationView.GetTransformPosition();
            var currentRotation = _rotationView.GetRotation();
            var forward = _rotationView.Forward;
            var rotation = _rotationModel.CalculateRotation(input, turret, currentRotation, forward, Time.deltaTime);
            
            _rotationView.Rotate(rotation);
        }
    }
}