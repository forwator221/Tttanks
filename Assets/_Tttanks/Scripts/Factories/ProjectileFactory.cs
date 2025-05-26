using UnityEngine;
using Zenject;

namespace Tttanks
{
    public class ProjectileFactory : IProjectileFactory
    {
        private readonly DiContainer _container;
        private readonly ProjectilePool _pool;

        public ProjectileFactory(DiContainer container, ProjectilePool pool)
        {
            _container = container;
            _pool = pool;
        }

        public ProjectilePresenter Create(Vector3 position, Vector3 direction, TurretConfig config)
        {
            var view = _pool.Spawn(position, Quaternion.LookRotation(direction));
        
            var model = new ProjectileModel(config.Speed, config.Damage);
            var presenter = new ProjectilePresenter(view, model, direction);

            return presenter;
        }
        
        public class ProjectilePool : MonoMemoryPool<Vector3, Quaternion, ProjectileView>
        {
            protected override void Reinitialize(Vector3 position, Quaternion rotation, ProjectileView item)
            {
                item.transform.position = position;
                item.transform.rotation = rotation;
                item.gameObject.SetActive(true);
            }

            protected override void OnDespawned(ProjectileView item)
            {
                item.gameObject.SetActive(false);
            }
        }
    }
    
    
}