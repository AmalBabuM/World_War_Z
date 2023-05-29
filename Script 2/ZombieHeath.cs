using System.Collections;
using System.Collections.Generic;
using UnityEditor.PackageManager;
using UnityEngine;

public class ZombieHeath : MonoBehaviour
{
    public int maxHealth = 100;
    public int currentHealth;
     HealthBar healthBar;

    // Start is called before the first frame update
    void Start()
    {
        healthBar = GetComponentInChildren<HealthBar>();
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);  
    }

    /*// Update is called once per frame
    void Update()
    {
        
    }*/

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
        healthBar.SetHealth(currentHealth);
        if(currentHealth<=0)
        {
            var enemy =GetComponent<ragdoll>();
            enemy.DoRagDoll(true);
        }
    }
}
