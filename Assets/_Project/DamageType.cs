using System;

[Flags]
public enum DamageType : int
{
    Physical = 1,
    Magic = 2,
    Fire = 4,
    Ice = 8,
    Poison = 16
}