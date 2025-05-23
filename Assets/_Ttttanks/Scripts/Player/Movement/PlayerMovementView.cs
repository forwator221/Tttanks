using System;
using UnityEngine;
using Zenject;

namespace Tttanks
{
    [RequireComponent(typeof(CharacterController))]
    public class PlayerMovementView : MonoBehaviour, IMovementView, ITransformProvider
    {
        private CharacterController _characterController;
        private IInputReader _input;
        
        public Vector3 Forward => transform.forward;
        public Transform Transform => transform;

        [Inject]
        public void Construct(IInputReader input)
        {
            _input = input;
        }

        private void Awake()
        {
            _characterController = GetComponent<CharacterController>();
        }

        public Vector2 GetInput() => _input.MoveDirection;

        public void Move(Vector3 position)
        {
            _characterController.Move(position);
        }

        public void Rotate(Quaternion deltaRotation)
        {
            transform.rotation *= deltaRotation;
        }

    }
}
