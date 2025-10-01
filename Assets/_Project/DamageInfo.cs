using System.Diagnostics;

public struct DamageInfo
{
    public int amount;
    public object source;
    public DamageType damageTypeFlags;

    public DamageInfo(int amount, object source, DamageType damageTypeFlags)
    {
        this.amount = amount;
        this.source = source;
        this.damageTypeFlags = damageTypeFlags;
    }
}