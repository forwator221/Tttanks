namespace Ttttanks
{
    public class PlayerMovementModel
    {
        public float MovementSpeed { get; private set; }
        public float RotationSpeed { get; private set; }

        public PlayerMovementModel(PlayerConfig playerConfig)
        {
            MovementSpeed = playerConfig.MovementSpeed;
            RotationSpeed = playerConfig.RotationSpeed;
        }
    }
}