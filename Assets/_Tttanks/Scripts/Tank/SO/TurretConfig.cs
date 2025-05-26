using UnityEngine;

namespace Tttanks
{
    [CreateAssetMenu(fileName = "TurretConfig", menuName = "Tanks/Configs/TurretConfig", order = 2)]
    public class TurretConfig : ScriptableObject
    {
        [field: SerializeField] public float RotationSpeed { get; private set; }
        [field: SerializeField] public float MaxRotationAngle { get; private set; }
        [field: SerializeField] public float FireRate { get; private set; }
        [field: SerializeField] public ProjectileView ProjectilePrefab { get; private set; }
        [field: SerializeField] public float Damage { get; private set; }
        [field: SerializeField] public float Speed { get; private set; }
    }
}