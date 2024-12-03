using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterStats : MonoBehaviour
{
    public Stat damage;
    public Stat maxHealth;

    [SerializeField] private int currentHealth;

    void Start()
    {
        currentHealth = maxHealth.GetValue();

        //Ecample equip sword with 4 damage
        damage.AddModifier(4);
    }

    public void TakeDamage(int _damage)
    {
        currentHealth -= _damage;

        if (currentHealth < 0)
            Die();
    }

    private void Die()
    {
        throw new NotImplementedException();
    }
}
