using UnityEngine;

namespace Tttanks
{
    public class TurretShootView : MonoBehaviour, ITurretShootView
    {
        [SerializeField] private Transform _firePoint;

        public Transform FirePoint => _firePoint;

        public void PlayShootEffects(TurretConfig turretConfig)
        {
            //TODO add SFX and VFX
        }
    }
}