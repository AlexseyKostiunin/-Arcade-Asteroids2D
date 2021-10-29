
public sealed class Cannon : Weapon
{
    public override void Shoot()
    {
        CreatingBullet(ShootPoint,Template);
    }
}
