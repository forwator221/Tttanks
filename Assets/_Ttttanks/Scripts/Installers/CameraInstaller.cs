using Unity.Cinemachine;
using UnityEngine;
using Zenject;

namespace Ttttanks
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
