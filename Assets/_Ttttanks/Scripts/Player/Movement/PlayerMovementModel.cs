using UnityEngine;

namespace Tttanks
{
    public class PlayerMovementModel : IMovementModel
    {
        public PlayerConfig Config { get; private set; }

        public void SetConfig(PlayerConfig config)
        {
            Config = config;
        }

        public Vector3 CalculateMovement(Vector2 input, Vector3 forwardDirection)
        {
            var verticalInput = input.y;
            return forwardDirection * (verticalInput * Config.MovementSpeed * Time.deltaTime);
        }

        public Quaternion CalculateRotation(Vector2 input)
        {
           var horizontalInput = input.x;
           var yRotation = horizontalInput * Config.RotationSpeed * Time.deltaTime;
           
           return Quaternion.Euler(0, yRotation, 0);
        }
    }
}