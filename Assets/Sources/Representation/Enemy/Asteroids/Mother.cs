
public sealed class Mother: Enemy
{ 
    public override void SpawnChildrens()
    {
        CreatingChildrens(NumberSpawnChildrens, TemplateChildren);
    }

    public override void Die()
    {
        EffectDeath(TemplateEffectDead);
        gameObject.SetActive(false);
    }
}
