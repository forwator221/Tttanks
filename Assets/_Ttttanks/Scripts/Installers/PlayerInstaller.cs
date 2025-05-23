using UnityEngine;
using Zenject;

namespace Tttanks
{
    public class PlayerInstaller : MonoInstaller
    {
        [SerializeField] private PlayerMovementView _playerMovementView;

        public override void InstallBindings()
        {
            InstallMovement();
        }

        private void InstallMovement()
        {
            Container.Bind<IMovementModel>().To<PlayerMovementModel>().AsSingle()
                .OnInstantiated<IMovementModel>((ctx, model) =>
                {
                    var config = ctx.Container.Resolve<PlayerConfig>();
                    model.SetConfig(config);
                });

            Container.BindInterfacesTo<PlayerMovementView>().FromInstance(_playerMovementView).AsSingle();

            Container.BindInterfacesTo<PlayerMovementPresenter>().AsSingle();
        }
    }
}
