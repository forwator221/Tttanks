using UnityEngine;

namespace Tttanks
{
    public interface ITurretRotationView
    {
        Vector3 GetMousePosition();
        Vector3 GetTransformPosition();
        Quaternion GetRotation();
        Vector3 Forward { get; }
        void Rotate(Quaternion rotation);
    }
}
