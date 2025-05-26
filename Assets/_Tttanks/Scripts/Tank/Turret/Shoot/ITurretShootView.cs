using UnityEngine;

namespace Tttanks
{
    public interface ITurretShootView
    {
        Transform FirePoint { get; }
        void PlayShootEffects(TurretConfig config);
    }
}