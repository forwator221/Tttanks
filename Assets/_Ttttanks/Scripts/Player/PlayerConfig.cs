using UnityEngine;

namespace Ttttanks
{
    [CreateAssetMenu(fileName = "PlayerConfig", menuName = "Tanks/Configs/PlayerConfig", order = 1)]
    public class PlayerConfig : ScriptableObject
    {
        [field: SerializeField] public GameObject PlayerPrefab { get; private set; }
        [field: SerializeField] public float MovementSpeed { get; private set; }
        [field: SerializeField] public float RotationSpeed { get; private set; }
        [field: SerializeField] public float ShootingCooldown { get; private set; }
    }
}
