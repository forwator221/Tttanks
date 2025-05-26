using UnityEngine;
using Zenject;

namespace Tttanks
{
    public interface IProjectileFactory : IFactory<Vector3, Vector3, TurretConfig, ProjectilePresenter> {}
}