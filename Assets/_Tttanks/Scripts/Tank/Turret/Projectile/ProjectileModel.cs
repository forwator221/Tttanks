namespace Tttanks
{
    public class ProjectileModel : IProjectileModel
    {
        public float Speed { get; private set; }
        public float Damage { get; private set; }

        public ProjectileModel(float speed, float damage)
        {
            Speed = speed;
            Damage = damage;
        }
        public void OnHit()
        {
            
        }
    }
}