using Unity.Cinemachine;
using Zenject;

namespace Tttanks
{
    public class CameraInitializer : IInitializable
    {
        private readonly CameraSystem _cameraSystem;
        private readonly CinemachineCamera _cinemachineCamera;
        private readonly ITransformProvider _playerMovementView;

        [Inject]
        public CameraInitializer(CameraSystem cameraSystem, CinemachineCamera cinemachineCamera, ITransformProvider playerMovementView)
        {
            _cameraSystem = cameraSystem;
            _cinemachineCamera = cinemachineCamera;
            _playerMovementView = playerMovementView;
        }
        
        public void Initialize()
        {
            _cameraSystem.Construct(_cinemachineCamera, _playerMovementView.Transform);
        }
    }
}
