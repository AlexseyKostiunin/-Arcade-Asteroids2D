using UnityEngine;

public sealed class Alien : Enemy
{   
    public override void Die()
    {
        EffectDeath(TemplateEffectDead);
        gameObject.SetActive(false);
    }
}
