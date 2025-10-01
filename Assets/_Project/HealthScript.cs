using UnityEngine;

public class HealthScript : MonoBehaviour, IDamageable
{
    private int health = 100;
    public int Health => health;

    public void TakeDamage(DamageInfo damageInfo)
    {
        if (damageInfo.amount <= 0 || damageInfo.source == null || damageInfo.damageTypeFlags == 0)
        {
            Debug.LogError($"ERROR: Invalid DamageInfo Passed: Amount: {damageInfo.amount}, Source: {damageInfo.source}, Damage Type(s): {damageInfo.damageTypeFlags}");
            return;
        }

        health -= damageInfo.amount;

        Debug.Log($"{gameObject.name} took {damageInfo.amount} damage ({damageInfo.damageTypeFlags.ToString()}) from {damageInfo.source}.");
    }
}


