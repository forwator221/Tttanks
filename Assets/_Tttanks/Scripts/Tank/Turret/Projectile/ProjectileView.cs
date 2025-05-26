using System;
using UnityEngine;
using Zenject;

namespace Tttanks
{
    public class ProjectileView : MonoBehaviour, IProjectileView
    {
        [SerializeField] private Rigidbody _rigidbody;
        
        [Inject]
        private IMemoryPool _pool;
        
        public Transform Transform => transform;
        
        public event Action<Collider> OnHit;
        
        public void Move(Vector3 direction, float speed)
        {
            _rigidbody.linearVelocity = direction.normalized * speed;
        }

        public void DestroyView()
        {
            if (_pool != null)
                _pool.Despawn(this);
            else
                Destroy(gameObject);
        }

        private void OnTriggerEnter(Collider other)
        {
            OnHit?.Invoke(other);
        }

    }
}