using Unity.Cinemachine;
using Zenject;

namespace Ttttanks
{
    public class CameraInitializer : IInitializable
    {
        private readonly CameraSystem _cameraSystem;
        private readonly CinemachineCamera _cinemachineCamera;
        private readonly PlayerMovementView _playerMovementView;

        [Inject]
        public CameraInitializer(CameraSystem cameraSystem, CinemachineCamera cinemachineCamera, PlayerMovementView playerMovementView)
        {
            _cameraSystem = cameraSystem;
            _cinemachineCamera = cinemachineCamera;
            _playerMovementView = playerMovementView;
        }
        
        public void Initialize()
        {
            _cameraSystem.Construct(_cinemachineCamera, _playerMovementView.transform);
        }
    }
}
