using Tttanks;
using UnityEngine;
using UnityEngine.Serialization;
using Zenject;

namespace Ttttanks
{
    [CreateAssetMenu(fileName = "PlayerConfigInstaller", menuName = "Tanks/Installers/PlayerConfigInstaller")]
    public class PlayerConfigInstaller : ScriptableObjectInstaller<PlayerConfigInstaller>
    {
        [SerializeField] private TankConfig tankConfig;
        [SerializeField] private TurretConfig turretConfig;
        public override void InstallBindings()
        {
            Container.Bind<TankConfig>().FromInstance(tankConfig).AsSingle();
            Container.Bind<TurretConfig>().FromInstance(turretConfig).AsSingle();
        }
    }
}
