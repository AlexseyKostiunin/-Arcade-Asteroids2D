using UnityEngine;

public abstract class Weapon : MonoBehaviour
{
    [SerializeField] protected Transform ShootPoint;
    [SerializeField] protected Bullet Template;
    
    public abstract void Shoot();

    protected void CreatingBullet(Transform shootPoint, Bullet template)
    {
        Instantiate(template, shootPoint.position, shootPoint.rotation);
    }
}
