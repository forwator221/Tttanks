using Ttttanks;
using UnityEngine;
using Zenject;

namespace Tttanks
{
    public class PlayerInstaller : MonoInstaller
    {
        [SerializeField] private PlayerMovementView _playerMovementView;
        [SerializeField] private TurretView _turretView;

        public override void InstallBindings()
        {
            InstallMovement();
            InstallTurret();
        }

        private void InstallTurret()
        {
            Container.Bind<ITurretModel>().To<TurretModel>().AsSingle()
                .OnInstantiated<ITurretModel>((ctx, model) =>
                {
                    var config = ctx.Container.Resolve<TurretConfig>();
                    model.SetConfig(config);
                });
            
            Container.BindInterfacesTo<TurretView>().FromInstance(_turretView).AsSingle();

            Container.BindInterfacesTo<TurretPresenter>().AsSingle();
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
    }
}
