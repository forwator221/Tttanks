using UnityEngine;
using Zenject;

namespace Tttanks
{
    [CreateAssetMenu(fileName = "InputInstaller", menuName = "Tanks/Installers/InputInstaller")]
    public class InputInstaller : ScriptableObjectInstaller<InputInstaller>
    {
        [SerializeField] private InputReader inputReader;

        public override void InstallBindings()
        {
            Container.Bind<IInputReader>().FromInstance(inputReader).AsSingle();
        }
    }
}
