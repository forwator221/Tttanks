using UnityEngine;

namespace Tttanks
{
    public class TurretShootModel : ITurretShootModel
    {
        public TurretConfig Config { get; private set; }
        public float LastShotTime { get; private set; }

        public void SetConfig(TurretConfig config)
        {
            Config = config;
            LastShotTime = -Config.FireRate;
        }

        public bool CanShoot()
        {
            return Time.time >= LastShotTime + Config.FireRate;
        } 

        public void RecordShoot() => LastShotTime = Time.time;
    }
}