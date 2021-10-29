
public sealed class Daughter : Enemy
{
    public override void SpawnChildrens()
    {
        CreatingChildrens(NumberSpawnChildrens, TemplateChildren);
    }

    public override void Die()
    {
        EffectDeath(TemplateEffectDead);
        Destroy(gameObject);
    }
}
