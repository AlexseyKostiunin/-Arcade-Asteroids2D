using UnityEngine;
using Asteroids.Logic;

public class EffectExplosionView : MonoBehaviour, IDestroyTime
{
    [SerializeField] private float _speedSizeIncrease;
    [SerializeField] private float _timeDestroy;

    private EffectExplosion _explosion;

    private void Awake()
    {
        _explosion = new EffectExplosion();
    }

    private void Start()
    {
        ExplosionShip();
        DestroyYourselfAfterCertainTime(gameObject,_timeDestroy);
    }

    private void ExplosionShip()
    {
        _explosion.Effect(transform,_speedSizeIncrease);
    }

    public void DestroyYourselfAfterCertainTime(GameObject gameObject, float timeDestroy)
    {
        Destroy(gameObject, timeDestroy);
    }
}
