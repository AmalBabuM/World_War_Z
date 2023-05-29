using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public int maxHealth = 500;
    public int currentHealth;
    public PlayerHealthbar healthBar;

    // Start is called before the first frame update
    void Start()
    {
       
        currentHealth = maxHealth;
        /*Debug.Log(currentHealth);*/
        healthBar.SetMaxHealth(currentHealth);
    }
    /*private void Update()
    {
        if(Input.GetKey("space"))
        {
            TakeDamage(20);
        }
    }*/

    /*// Update is called once per frame
    void Update()
    {
        
    }*/
   /* private void OnControllerColliderHit(ControllerColliderHit hit)
    {
        if(hit.collider.tag == "Enemy")
        {
            TakeDamage(5);
            Debug.Log("Hi");
        }
    }*/

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
        healthBar.SetHealth(currentHealth);
        if (currentHealth <= 0)
        {
            var enemy = GetComponent<ragdoll>();
            enemy.DoRagDoll(true);
        }
    }
}
