using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathCheck : MonoBehaviour
{
    float pMaxHealth;
    float pHealth;

    // Start is called before the first frame update
    void Start()
    {
        // Fetch PlayerPref health
        GetHealth();
    }

    void GetHealth()
    {
        // Default max hp/current hp is 3
        pMaxHealth = PlayerPrefs.GetFloat("mHealth", 3);
        pHealth = PlayerPrefs.GetFloat("Health", pMaxHealth);
    }

    public void Damage(float dValue)
    {
        pHealth -= dValue;
        
        if (pHealth <= 0)
        {
            Die();
        }
        else
        {
            // Set PlayerPref "Health" to current hp
            PlayerPrefs.SetFloat("Health", pHealth);

            // Call to update GUI
        }
    }

    public void Die()
    {
        pHealth = 0;

        // Call to update GUI, ask for Respawn()
    }
}
