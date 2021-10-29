
public sealed class Son : Enemy
{
    public override void Die()
    {
        EffectDeath(TemplateEffectDead);
        Destroy(gameObject);
    }
}
