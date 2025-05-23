using UnityEngine;
using Zenject;

namespace Ttttanks
{
    public class PlayerInstaller : MonoInstaller
    {
        [SerializeField] private PlayerMovementView _playerMovementView;
        [SerializeField] private PlayerConfig _playerConfig;

        public override void InstallBindings()
        {
            InstallMovement();
        }

        private void InstallMovement()
        {
            Container.Bind<PlayerMovementModel>().ToSelf().AsSingle().WithArguments(_playerConfig);
            Container.Bind<PlayerMovementView>().FromInstance(_playerMovementView).AsSingle();
            Container.BindInterfacesTo<PlayerMovementPresenter>().AsSingle();
        }
    }
}
