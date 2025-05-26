using UnityEngine;

namespace Tttanks
{
    public class TurretRotationModel : ITurretRotationModel
    {
        public TurretConfig Config { get; private set; }
        
        public void SetConfig(TurretConfig config)
        {
            Config = config;
        }

        public Quaternion CalculateRotation(Vector3 input, Vector3 center, Quaternion currentRotation, Vector3 forward, float deltaTime)
        {
            Vector3 targetDirection = input - center;
            targetDirection.y = 0;

            if (targetDirection.sqrMagnitude < 0.0001f)
                return currentRotation;

            targetDirection.Normalize();
            Quaternion targetRotation = Quaternion.LookRotation(targetDirection);
            float maxAngleStep = Config.RotationSpeed * deltaTime;
            
            Quaternion nextRotation = Quaternion.RotateTowards(currentRotation, targetRotation, maxAngleStep);
            
            Vector3 newForward = nextRotation * Vector3.forward;
            float angleFromInitial = Vector3.Angle(forward, newForward);
            
            if (angleFromInitial > Config.MaxRotationAngle / 2)
                return currentRotation;

            return nextRotation;
        }
    }
}