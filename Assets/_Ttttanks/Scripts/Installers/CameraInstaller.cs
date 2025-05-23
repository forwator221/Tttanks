using Unity.Cinemachine;
using UnityEngine;
using Zenject;

namespace Tttanks
{
    public class CameraInstaller : MonoInstaller
    {
        [SerializeField] private CinemachineCamera cinemachineCamera;
        [SerializeField] private CameraSystem cameraSystem;

        public override void InstallBindings()
        {
            Container.BindInstance(cinemachineCamera).AsSingle();
            Container.BindInstance(cameraSystem).AsSingle();
            
            Container.BindInterfacesTo<CameraInitializer>().AsSingle();
        }
    }
}
