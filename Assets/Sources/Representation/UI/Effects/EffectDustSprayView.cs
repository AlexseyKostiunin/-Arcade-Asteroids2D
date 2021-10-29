using UnityEngine;
using Asteroids.Logic;

public class EffectDustSprayView : MonoBehaviour, IDestroyTime
{
    [SerializeField] private float _speedSizeReduction;
    [SerializeField] private float _timeDestroy;

    private EffectDustSpray _dustSpray;

    private void Awake()
    {
        _dustSpray = new EffectDustSpray();
    }

    private void Start()
    {
        ExplosionAsteroid();
        DestroyYourselfAfterCertainTime(gameObject,_timeDestroy);
    }

    private void ExplosionAsteroid()
    {
        _dustSpray.Effect(transform, _speedSizeReduction);
    }

    public void DestroyYourselfAfterCertainTime(GameObject gameObject, float timeDestroy)
    {
        Destroy(gameObject, timeDestroy);
    }
}
