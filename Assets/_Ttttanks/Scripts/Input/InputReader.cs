using System;
using System.Reflection;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;
using static PlayerInputAsset;

namespace Ttttanks
{
    [CreateAssetMenu(fileName = "InputReader", menuName = "Tanks/InputReader")]
    public class InputReader : ScriptableObject, IPlayerActions, IInputReader
    {
        public event UnityAction<Vector2> Move;
        public event UnityAction<Vector2> Look;
        public event UnityAction<bool> Fire;

        private PlayerInputAsset _input;
        
        public Vector2 MoveDirection => _input.Player.Move.ReadValue<Vector2>();
        public Vector2 LookDirection => _input.Player.Look.ReadValue<Vector2>();
        
        public void EnableInput() => _input?.Enable();
        public void DisableInput() => _input?.Disable();

        public void OnMove(InputAction.CallbackContext context)
        {
            Move?.Invoke(context.ReadValue<Vector2>());
        }

        public void OnLook(InputAction.CallbackContext context)
        {
            Look?.Invoke(context.ReadValue<Vector2>());
        }

        public void OnFire(InputAction.CallbackContext context)
        {
            Fire?.Invoke(context.ReadValueAsButton());
        }
        
        private void OnEnable()
        {
            if (_input == null)
            {
                _input = new PlayerInputAsset();
                _input.Player.SetCallbacks(this);
            }
            
            EnableInput();
        }

        private void OnDisable()
        {
            DisableInput();
        }
    }
}
