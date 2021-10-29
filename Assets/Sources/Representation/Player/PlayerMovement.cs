using UnityEngine;
using System;
using UnityEngine.InputSystem;
using Asteroids.Logic; 

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private Boost _boost;
    [SerializeField] private TimeStop _timeStop;

    private PlayerInput _input;
    private MovementPlayer _movement;

    private Transform _selfTransform;

    private float _rotatePlayer;

    public Vector3 AccelerationPlayer => _movement.Acceleration;
    public Transform SelfTransform => _selfTransform;
    public float AngleRotatePlayer => _movement.EulerAngleZ;

    private void Awake()
    {
        _input = new PlayerInput();
        _movement = new MovementPlayer();
    }

    private void OnEnable()
    {
        _input.Enable();
    }

    private void OnDisable()
    {
        _input.Disable();
    }

    private void Start()
    {
        _selfTransform = GetComponent<Transform>();
    }

    private void Update()
    {
        ReadingInputValues();
        TryMovement();
        TryAccelerate();
        TryRotation();
    }

    private void ReadingInputValues()
    {
        _rotatePlayer = _input.Player.Rotate.ReadValue<float>();
    }

    private void TryMovement()
    {
        _movement.Move(_selfTransform);
    }

    private void TryAccelerate()
    {
        if (MoveFowardPerfomed())
            _movement.Accelerate(_selfTransform, _boost.UnitsInSecond, _boost.MaxBoost, Time.deltaTime);
        else
            _movement.Slowdown(_timeStop.SecondsToStop,Time.deltaTime);
    }

    private void TryRotation()
    {
        _movement.SetValueRotate(_rotatePlayer);
        _movement.SetScaledSpeed(_boost.Rotation,Time.deltaTime);
        
        _movement.Rotate(_selfTransform);

        _movement.GetEulerAngleZ(_rotatePlayer, _selfTransform);
    }

    private bool MoveFowardPerfomed()
    {
        return _input.Player.MoveForward.phase == InputActionPhase.Performed;
    }
}

[Serializable]
internal class Boost
{
    [SerializeField] private float _units;
    [SerializeField] private float _max;

    [SerializeField] private float _rotation;

    public float UnitsInSecond => _units;    
    public float MaxBoost => _max;
    public float Rotation => _rotation;
}

[Serializable]
internal class TimeStop
{
    [SerializeField] private float _seconds;

    public float SecondsToStop => _seconds;
}

