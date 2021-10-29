using UnityEngine;

namespace Asteroids.Logic
{
    public interface ICreateEffect
    {
        void CreatingEffect(GameObject[] templateDeadEffect);
    }

    public interface IDestroyTime
    {
        void DestroyYourselfAfterCertainTime(GameObject gameObject, float timeDestroy);
    }
}