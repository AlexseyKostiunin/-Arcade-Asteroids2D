using UnityEngine;

[RequireComponent(typeof(Ammo))]
public sealed class Laser : Weapon
{
    private Ammo _ammo;

    private void Start()
    {
        _ammo = GetComponent<Ammo>();
    }

    public override void Shoot()
    {
        _ammo.SpentCartridg();
        CreatingBullet(ShootPoint,Template);
    }
}
