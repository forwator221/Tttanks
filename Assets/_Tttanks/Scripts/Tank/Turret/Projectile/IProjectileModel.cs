namespace Tttanks
{
    public interface IProjectileModel
    {
        float Speed { get;}
        float Damage { get; }
        void OnHit();
    }
}