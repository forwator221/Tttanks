using UnityEngine;

namespace Ttttanks
{
    [RequireComponent(typeof(CharacterController))]
    public class PlayerMovementView : MonoBehaviour
    {
        private CharacterController _characterController;
        
        public Vector3 Forward => transform.forward;

        private void Awake()
        {
            _characterController = GetComponent<CharacterController>();
        }

        public void Move(Vector3 deltaPosition)
        {
            _characterController.Move(deltaPosition);
        }

        public void Rotate(Vector3 deltaRotation)
        {
            transform.Rotate(deltaRotation, Space.Self);
        }
    }
}
