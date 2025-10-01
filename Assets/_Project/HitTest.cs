using System;
using UnityEngine;

public class HitTest : MonoBehaviour
{
    [SerializeField] private HealthScript target;

    [SerializeField] private int damage;
    [SerializeField] private DamageType damageFlags = DamageType.Fire | DamageType.Ice | DamageType.Physical;

    private void Start()
    {
        if (target.TryGetComponent(out IDamageable damageable))
        {
            damageable.TakeDamage(new DamageInfo(damage, this, damageFlags));
        }
    }
}
