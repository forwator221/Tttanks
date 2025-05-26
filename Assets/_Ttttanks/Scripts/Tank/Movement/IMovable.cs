using UnityEngine;

namespace Tttanks
{
    public interface IMovable
    {
        Vector3 CalculateMovement(Vector2 input, Vector3 forwardDirection);
    }
}