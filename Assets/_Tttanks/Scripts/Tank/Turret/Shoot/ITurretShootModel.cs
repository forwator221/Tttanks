namespace Tttanks
{
    public interface ITurretShootModel
    {
        TurretConfig Config { get;}
        float LastShotTime { get; }
        void SetConfig(TurretConfig config);
        bool CanShoot();
        void RecordShoot();
    }
}