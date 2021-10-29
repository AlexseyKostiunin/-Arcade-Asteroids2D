using UnityEngine;
using Asteroids.Logic;

public class AsteroidMovement : MonoBehaviour
{
    [SerializeField] private float _speedMove;

    private MovementAsteroid _movement;
    private Transform _asteroidTransform;

    private void Start()
    {
        _movement = new MovementAsteroid();

        _asteroidTransform = GetComponent<Transform>();

        _movement.Rotate(_asteroidTransform);
    }

    private void Update()
    {
        _movement.SetScaledSpeed(_speedMove, Time.deltaTime);

        _movement.Move(_asteroidTransform);
    }
}
