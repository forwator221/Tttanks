using UnityEngine;

namespace Tttanks
{
    public interface IMovementModel
    {
        PlayerConfig Config { get; }
        void SetConfig(PlayerConfig config);
        Vector3 CalculateMovement(Vector2 input, Vector3 forwardDirection);
        Quaternion CalculateRotation(Vector2 input);
    }
}