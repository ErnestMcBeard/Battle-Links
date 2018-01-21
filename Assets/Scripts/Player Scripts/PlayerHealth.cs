﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public const int maxHealth = 120;
    public int currentHealth = maxHealth;

	public void TakeDamage(int amount)
    {
        currentHealth -= amount;
        if (currentHealth <= 0)
        {
            currentHealth = 0;
            // TODO: Handle player death.
        }
    }
}
