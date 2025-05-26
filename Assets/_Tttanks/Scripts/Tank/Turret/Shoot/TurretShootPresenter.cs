using Zenject;

namespace Tttanks
{
    public class TurretShootPresenter : ITickable
    {
        private readonly ITurretShootView _view;
        private readonly ITurretShootModel _model;
        private readonly IInputReader _input;
        private readonly IProjectileFactory _projectileFactory;

        [Inject]
        public TurretShootPresenter(
            ITurretShootView view, 
            ITurretShootModel model, 
            IInputReader input, 
            IProjectileFactory projectileFactory, 
            TurretConfig turretConfig)
        {
            _view = view;
            _model = model;
            _input = input;
            _projectileFactory = projectileFactory;
            
            _model.SetConfig(turretConfig);
        }

        public void Tick()
        {
            if (_input.IsFirePressed && _model.CanShoot())
            {
                _model.RecordShoot();

                var position = _view.FirePoint.position;
                var direction = _view.FirePoint.forward;

                _projectileFactory.Create(position, direction, _model.Config);
                _view.PlayShootEffects(_model.Config);
            }
        }
    }
}