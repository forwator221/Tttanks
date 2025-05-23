using Tttanks;
using UnityEngine;
using Zenject;

namespace Ttttanks
{
    [CreateAssetMenu(fileName = "PlayerConfigInstaller", menuName = "Tanks/Installers/PlayerConfigInstaller")]
    public class PlayerConfigInstaller : ScriptableObjectInstaller<PlayerConfigInstaller>
    {
        [SerializeField] private PlayerConfig _playerConfig;
        public override void InstallBindings()
        {
            Container.Bind<PlayerConfig>().FromInstance(_playerConfig).AsSingle();
        }
    }
}
