using UnityEngine;

namespace Tttanks
{
    public class ProjectilePresenter
    {
        private readonly IProjectileView _view;
        private readonly IProjectileModel _model;
        private readonly Vector3 _direction;

        public ProjectilePresenter(IProjectileView view, IProjectileModel model, Vector3 direction)
        {
            _view = view;
            _model = model;
            _direction = direction;

            _view.OnHit += HandleHit;
            _view.Move(_direction, _model.Speed);
        }

        private void HandleHit(Collider obj)
        {
            _model.OnHit();
            _view.OnHit -= HandleHit;
            _view.DestroyView();
        }
    }
}