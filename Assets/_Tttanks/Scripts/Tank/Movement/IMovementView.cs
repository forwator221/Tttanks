using UnityEngine;

namespace Tttanks
{
    public interface IMovementView
    {
        Vector2 GetInput();
        Vector3 Forward { get; }
        void Move(Vector3 position);
        void Rotate(Quaternion rotation);
    }
}