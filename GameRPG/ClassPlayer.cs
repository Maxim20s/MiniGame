namespace GameRPG
{
    interface ClassPlayer
    {
        byte IndexClassPlayer { get; }
        int DamageClass { get; }
        int HealthClass { get; }
        int UpgradeDamageClass { get; }
        int UpgradeHeallClass { get; }
    }
}
