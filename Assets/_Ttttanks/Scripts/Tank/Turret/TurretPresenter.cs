using UnityEngine;
using Zenject;

namespace Ttttanks
{
    public class TurretPresenter : ITickable
    {
        private readonly ITurretView _view;
        private readonly ITurretModel _model;

        [Inject]
        public TurretPresenter(ITurretView view, ITurretModel model)
        {
            _view = view;
            _model = model;
        }

        public void Tick()
        {
            var input = _view.GetMousePosition();
            var turret = _view.GetTransformPosition();
            var currentRotation = _view.GetRotation();
            var forward = _view.Forward;
            var rotation = _model.CalculateRotation(input, turret, currentRotation, forward, Time.deltaTime);
            
            _view.Rotate(rotation);
        }
    }
}