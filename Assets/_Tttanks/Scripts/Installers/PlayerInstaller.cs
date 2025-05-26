using UnityEngine;
using Zenject;

namespace Tttanks
{
    public class PlayerInstaller : MonoInstaller
    {
        [SerializeField] private PlayerMovementView _playerMovementView;
        [SerializeField] private TurretRotationView _turretRotationView;
        [SerializeField] private ProjectileView _projectilePrefab;
        [SerializeField] private TurretShootView _turretShootView;

        public override void InstallBindings()
        {
            InstallMovement();
            InstallTurret();
        }
        private void InstallMovement()
        {
            Container.Bind<ITankMovementModel>().To<PlayerTankMovementModel>().AsSingle()
                .OnInstantiated<ITankMovementModel>((ctx, model) =>
                {
                    var config = ctx.Container.Resolve<TankConfig>();
                    model.SetConfig(config);
                });

            Container.BindInterfacesTo<PlayerMovementView>().FromInstance(_playerMovementView).AsSingle();

            Container.BindInterfacesTo<PlayerMovementPresenter>().AsSingle();
        }

        private void InstallTurret()
        {
            Rotation();
            Projectile();
            Shoot();
        }

        private void Shoot()
        {
            Container.Bind<ITurretShootModel>().To<TurretShootModel>().AsSingle()
                .OnInstantiated<ITurretShootModel>((ctx, model) =>
                {
                    var config = ctx.Container.Resolve<TurretConfig>();
                    model.SetConfig(config);
                });

            Container.BindInterfacesTo<TurretShootView>().FromInstance(_turretShootView).AsSingle();

            Container.BindInterfacesTo<TurretShootPresenter>().AsSingle();
        }

        private void Projectile()
        {
            Container.BindMemoryPool<ProjectileView, ProjectileFactory.ProjectilePool>()
                .WithInitialSize(10)
                .FromComponentInNewPrefab(_projectilePrefab)
                .UnderTransformGroup("Projectiles");

            Container.Bind<IProjectileFactory>().To<ProjectileFactory>().AsSingle();
        }

        private void Rotation()
        {
            Container.Bind<ITurretRotationModel>().To<TurretRotationModel>().AsSingle()
                .OnInstantiated<ITurretRotationModel>((ctx, model) =>
                {
                    var config = ctx.Container.Resolve<TurretConfig>();
                    model.SetConfig(config);
                });
            
            Container.BindInterfacesTo<TurretRotationView>().FromInstance(_turretRotationView).AsSingle();

            Container.BindInterfacesTo<TurretRotationPresenter>().AsSingle();
        }

    }
}
