using UnityEngine;

namespace Ttttanks
{
    public interface ITurretView
    {
        Vector3 GetMousePosition();
        Vector3 GetTransformPosition();
        Quaternion GetRotation();
        Vector3 Forward { get; }
        void Rotate(Quaternion rotation);
    }
}
