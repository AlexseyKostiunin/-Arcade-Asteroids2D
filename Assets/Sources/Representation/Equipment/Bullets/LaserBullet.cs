using UnityEngine;
using Asteroids.Logic;

public sealed class LaserBullet : Bullet , IDestroyTime
{
    private void Start()
    {
        DestroyYourselfAfterCertainTime(gameObject, TimeDestroy);
    }

    private void Update()
    {
        BulletMovement(SpeedBullet);
    }

    public void DestroyYourselfAfterCertainTime(GameObject gameObject, float timeDestroy)
    {
        Destroy(gameObject, timeDestroy);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.TryGetComponent(out Enemy enemy))
        {
            Reward.AddRewardScore(enemy.TransferRewardScore);

            enemy.Die();
        }
    }
}
