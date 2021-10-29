using UnityEngine;
using UnityEngine.Events;

public class PlayerMovementDebugUI : MonoBehaviour
{
    [SerializeField] private PlayerMovement _player;

    public Vector2 Coordinate { get; private set; }
    public float Boost { get; private set; }
    public float Angle { get; private set; }

    public event UnityAction<Vector2> CoordinatesShipPlayerChanged;
    public event UnityAction<float> SpeedChanged;
    public event UnityAction<float> AngleRotationChanged;

    private void Update()
    {
        CoordinatesPlayerShip();
        InstantaneousSpeed();
        AngleRotation();
    }

    private void CoordinatesPlayerShip()
    {
        Coordinate = _player.SelfTransform.position;

        CoordinatesShipPlayerChanged?.Invoke(Coordinate);
    }

    private void InstantaneousSpeed()
    {
        Boost = _player.AccelerationPlayer.magnitude * 1000;

        SpeedChanged?.Invoke(Boost);
    }

    private void AngleRotation()
    {
        Angle = _player.AngleRotatePlayer;

        AngleRotationChanged?.Invoke(Angle);
    }
}
