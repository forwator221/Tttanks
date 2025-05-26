using System;
using UnityEngine;

namespace Tttanks
{
    public interface IProjectileView
    {
        void Move(Vector3 direction, float speed);
        void DestroyView();
        Transform Transform { get; }
        event Action<Collider> OnHit;
    }
}