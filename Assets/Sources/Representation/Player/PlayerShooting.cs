using UnityEngine;

public class PlayerShooting : MonoBehaviour
{
    [SerializeField] private Cannon _cannon;
    [SerializeField] private Laser _laser;
    [SerializeField] private Ammo _ammo;

    private PlayerInput _input;

    private void Awake()
    {
        _input = new PlayerInput();
    }

    private void OnEnable()
    {
        _input.Enable();
        _input.Player.ShootCanon.performed += ctx => OnShootCannon();
        _input.Player.ShootLaser.performed += ctx => OnShootLaser();
    }

    private void OnDisable()
    {
        _input.Disable();
        _input.Player.ShootCanon.performed -= ctx => OnShootCannon();
        _input.Player.ShootLaser.performed -= ctx => OnShootLaser();
    }

    private void OnShootCannon()
    {
        _cannon.Shoot();
    }

    private void OnShootLaser()
    {
        TryShootLaser();
    }

    private void TryShootLaser()
    {
        if (_ammo.CurrentAmmo > _ammo.NoAmmo)
            _laser.Shoot();
    }
}
