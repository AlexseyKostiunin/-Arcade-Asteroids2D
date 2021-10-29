using UnityEngine;
using DG.Tweening;

namespace Asteroids.Logic
{
    public abstract class Effects
    {
        public abstract void Effect(Transform transform, float speedSizeChange);
    }

    public sealed class EffectExplosion : Effects
    {
        public override void Effect(Transform transform, float speedSizeIncrease)
        {
            transform.DOScale(new Vector3(2.5f, 2.5f), speedSizeIncrease);
        }
    }

    public sealed class EffectDustSpray : Effects
    {
        public override void Effect(Transform transform, float speedSizeReduction)
        {
            transform.DOScale(new Vector3(0.1f, 0.1f), speedSizeReduction);
        }
    }
}