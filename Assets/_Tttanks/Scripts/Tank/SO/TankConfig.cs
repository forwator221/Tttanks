using UnityEngine;

namespace Tttanks
{
    [CreateAssetMenu(fileName = "PlayerConfig", menuName = "Tanks/Configs/PlayerConfig", order = 1)]
    public class TankConfig : ScriptableObject
    {
        [field: SerializeField] public GameObject TankPrefab { get; private set; }
        [field: SerializeField] public float MovementSpeed { get; private set; }
        [field: SerializeField] public float RotationSpeed { get; private set; }
        [field: SerializeField] public float ShootingCooldown { get; private set; }
    }
}
