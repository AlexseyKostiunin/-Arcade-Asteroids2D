using UnityEngine;

namespace Asteroids.Logic
{
    public abstract class Movement
    {
        protected float ScaledMoveSpeed;

        public abstract void Move(Transform transformObject);

        public abstract void Rotate(Transform transformObject);

        public abstract void SetScaledSpeed(float speed, float deltaTime);
    }

    public sealed class MovementPlayer : Movement
    {
        public Vector3 Acceleration { get; private set; }
        public float EulerAngleZ { get; private set; }

        private float _scaledRotateSpeed;
        private float _rotate;

        public void Accelerate(Transform player, float unitsInSecond, float maxSpeed, float deltaTime)
        {
            Acceleration += player.up * (unitsInSecond * deltaTime);
            Acceleration = Vector2.ClampMagnitude(Acceleration, maxSpeed);
        }

        public void Slowdown(float secondsStop, float deltaTime)
        {
            Acceleration -= Acceleration * (deltaTime / secondsStop);
        }

        public override void Move(Transform player)
        {
            player.position += Acceleration;
        }

        public override void Rotate(Transform player)
        {
            player.Rotate(0f, 0f, -_rotate * _scaledRotateSpeed);
        }

        public void SetValueRotate(float rotate)
        {
            _rotate = rotate;
        }

        public override void SetScaledSpeed(float rotateSpeed, float deltaTime)
        {
            _scaledRotateSpeed = rotateSpeed * deltaTime;
        }

        public float GetEulerAngleZ(float rotate, Transform player)
        {
            rotate = player.rotation.eulerAngles.z;

            return EulerAngleZ = rotate;
        }
    }

    public sealed class MovementAsteroid : Movement
    {
        public override void Move(Transform enemy)
        {
            enemy.Translate(Vector2.one * ScaledMoveSpeed);
        }

        public override void Rotate(Transform enemy)
        {
            float fullAngle = 360.0f;

            enemy.eulerAngles = new Vector3(0.0f, 0.0f, Random.value * fullAngle);
        }

        public override void SetScaledSpeed(float speedMove, float deltaTime)
        {
            ScaledMoveSpeed = speedMove * deltaTime;
        }
    }

    public sealed class MovementAlien : Movement
    {
        private Vector3 _targetPostion;

        public override void Move(Transform enemy)
        {
            enemy.position = Vector2.MoveTowards(enemy.position, _targetPostion, ScaledMoveSpeed);
        }

        public override void Rotate(Transform enemy)
        {
            Vector3 direction = enemy.InverseTransformPoint(_targetPostion);

            float angle = Mathf.Atan2(direction.x, direction.y) * Mathf.Rad2Deg;

            enemy.Rotate(0, 0, -angle);
        }

        public void SetTargetEnemy(Vector3 targetPosition)
        {
            _targetPostion = targetPosition;
        }

        public override void SetScaledSpeed(float speedMove, float deltaTime)
        {
            ScaledMoveSpeed = speedMove * deltaTime;
        }
    }
}