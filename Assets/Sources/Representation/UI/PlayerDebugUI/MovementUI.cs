using TMPro;
using UnityEngine;

public class MovementUI : MonoBehaviour
{
    [SerializeField] private PlayerMovementDebugUI _player;

    [SerializeField] private TMP_Text _coordinatPlayer;
    [SerializeField] private TMP_Text _angleRotationPlayer;
    [SerializeField] private TMP_Text _instantaneousSpeedPlayer;

    private void OnEnable()
    {
        _player.CoordinatesShipPlayerChanged += OnCoordinatesShipPlayerChanged;
        _player.AngleRotationChanged += OnAngleRotationChanged;
        _player.SpeedChanged += OnChangedSpeed;
    }

    private void OnDisable()
    {
        _player.CoordinatesShipPlayerChanged -= OnCoordinatesShipPlayerChanged;
        _player.AngleRotationChanged -= OnAngleRotationChanged;
        _player.SpeedChanged -= OnChangedSpeed;
    }

    private void OnCoordinatesShipPlayerChanged(Vector2 coordinates)
    {
        _coordinatPlayer.text = $"Coordinate: {coordinates}";
    }

    private void OnAngleRotationChanged(float angle)
    {
        _angleRotationPlayer.text = $"AngleRotation: {Mathf.RoundToInt(angle)}°";
    }

    private void OnChangedSpeed(float boost)
    {
        _instantaneousSpeedPlayer.text = $"Speed: {Mathf.RoundToInt(boost)}";
    }
}
