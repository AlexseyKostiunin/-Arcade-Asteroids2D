using UnityEngine;
using UnityEngine.Events;
using Asteroids.Logic;

public class Player : MonoBehaviour, ICreateEffect
{
    [SerializeField] private GameObject[] _templateEffectDead;
    
    public event UnityAction PlayerDead;

    private readonly byte _indexEffectExplosionShip = 1;

    public void CreatingEffect(GameObject[] templateDeadEffect)
    {
        for (int i = 0; i < _indexEffectExplosionShip; i++)
        {
            Instantiate(templateDeadEffect[i], transform.position, Quaternion.identity);
        }
    }

    private void Dead()
    {
        CreatingEffect(_templateEffectDead);
        Destroy(gameObject);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.TryGetComponent(out Enemy enemy))
        {
            Dead();

            PlayerDead?.Invoke();
        }
    }
}
