using UnityEngine;

public abstract class Bullet : MonoBehaviour
{
    [SerializeField] protected float SpeedBullet;
    [SerializeField] protected float TimeDestroy;

    protected Score Reward => FindObjectOfType<Score>();

    protected void BulletMovement(float speedBullet)
    {
        transform.Translate(Vector2.up * speedBullet * Time.deltaTime);
    }
}
