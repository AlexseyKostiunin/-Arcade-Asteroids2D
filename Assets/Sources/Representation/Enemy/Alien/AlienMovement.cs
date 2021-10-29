using UnityEngine;
using Asteroids.Logic;

public class AlienMovement : MonoBehaviour
{
    [SerializeField] private float _speedMove;

    private MovementAlien _movement;
    private Transform _alienTransform;

    private Player _target => FindObjectOfType<Player>();

    private void Start()
    {
        _movement = new MovementAlien();
        _alienTransform = GetComponent<Transform>();
    }

    private void Update()
    {
        if (_target != null)
        {
            _movement.SetScaledSpeed(_speedMove, Time.deltaTime);
            _movement.SetTargetEnemy(_target.transform.position);

            _movement.Move(_alienTransform);
            _movement.Rotate(_alienTransform);
        }
    }
}
