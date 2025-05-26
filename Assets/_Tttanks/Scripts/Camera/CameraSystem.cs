using Unity.Cinemachine;
using UnityEngine;

namespace Tttanks
{
    public class CameraSystem : MonoBehaviour
    {
        private CinemachineCamera _camera;
        private Transform _target;
        
        public void Construct(CinemachineCamera camera, Transform target)
        {
            _camera = camera;
            _target = target;
            
            _camera.Follow = _target;
            _camera.LookAt = _target;
            _camera.OnTargetObjectWarped(_target, transform.position - _camera.transform.position - Vector3.forward);
        }
    }
}
