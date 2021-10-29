using UnityEngine;
using Asteroids.Logic;
public abstract class Enemy : MonoBehaviour , ICreateEffect
{
    [SerializeField] protected GameObject TemplateChildren;
    [SerializeField] protected GameObject[] TemplateEffectDead;

    [SerializeField] protected int NumberSpawnChildrens;
    [SerializeField] protected int RewardScore;

    public int TransferRewardScore { get; private set; }

    private void Start()
    {
        TransferRewardScore = RewardScore;
    }

    public abstract void Die();

    public virtual void SpawnChildrens() { }

    public void CreatingEffect(GameObject[] templateDeadEffect)
    {
        int randomIndex = Random.Range(0, templateDeadEffect.Length);

        Instantiate(templateDeadEffect[randomIndex], transform.position, Quaternion.identity);
    }

    protected void CreatingChildrens(int numberSpawnChildrens, GameObject templateChildren)
    {
        for (int i = 0; i < numberSpawnChildrens; i++)
        {
            Instantiate(templateChildren, transform.position, transform.rotation);
        }
    }

    protected void EffectDeath(GameObject[] templateEffectDead)
    {
        CreatingEffect(templateEffectDead);
    }
}
