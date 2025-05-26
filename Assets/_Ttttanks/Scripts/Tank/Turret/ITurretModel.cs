using Tttanks;
using UnityEngine;

namespace Ttttanks
{
    public interface ITurretModel : IRotatableAroundWorldPoint
    {
        TurretConfig Config { get; }
        void SetConfig (TurretConfig config);
    }

    public interface IRotatableAroundWorldPoint
    {
        Quaternion CalculateRotation(Vector3 input, Vector3 center, Quaternion currentRotation,Vector3 forward, float deltaTime);

    }
}
