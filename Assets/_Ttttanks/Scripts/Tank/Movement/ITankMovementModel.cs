namespace Tttanks
{
    public interface ITankMovementModel : IRotatable, IMovable
    {
        TankConfig Config { get; }
        void SetConfig(TankConfig config);
    }
}