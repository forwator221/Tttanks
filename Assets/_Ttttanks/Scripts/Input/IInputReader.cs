using UnityEngine;
using UnityEngine.Events;

namespace Tttanks
{
    public interface IInputReader
    {
        Vector2 MoveDirection { get; }
        Vector2 LookDirection { get; }

        event UnityAction<Vector2> Move;
        event UnityAction<Vector2> Look;
        event UnityAction<bool> Fire;

        void EnableInput();
        void DisableInput();
    }
}