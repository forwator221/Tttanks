using UnityEngine;

namespace Tttanks
{
    public interface IRotatable
    {
        Quaternion CalculateRotation(Vector2 input);
    }
}