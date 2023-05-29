using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NavEnemy : MonoBehaviour
{ 
    Animator anim;
    private NavMeshAgent enemy;
    private GameObject player;
    public float range = 19.0f;
    public float shortRange = 2f;

    private float speed;
    private float zVelocity=0.0f;
    private float attack=1f;
    private float walk=0.5f;
    float limit;
    PlayerHealth playerHealth;
    
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        playerHealth= player.GetComponent<PlayerHealth>();
        anim= GetComponent<Animator>();
        enemy = GetComponent<NavMeshAgent>();
        speed = 1f * Time.deltaTime;
    }

    // Update is called once per frame
    void Update()
    {   
        
        float distance = Vector3.Distance(transform.position, player.transform.position);
        limit=(distance < shortRange) ? attack : walk;

        if (distance< range)
        {
            enemy.SetDestination(player.transform.position);
           
        }
        else
        {
            enemy.SetDestination(transform.position);
        }
        
        if((distance < range && distance>shortRange) && zVelocity <0.5) 
        {
            zVelocity += speed;
            
        }
        else if(distance > range && zVelocity>0.0f)
        {
            zVelocity-= speed;
        }

        if(distance<shortRange && zVelocity<1f)
        {
            zVelocity += speed;
            /*playerHealth.TakeDamage(2);*/

        }
        else if (distance > shortRange && zVelocity > 0.5f)
        {
            zVelocity -= speed;
        }
        if(distance<shortRange)
        {
            playerHealth.TakeDamage(2);
        }



       /* if (distance < range && distance >shortRange && zVelocity>limit)
        {
            zVelocity -= speed;
        }
        if(distance> range&& zVelocity>0.0f)
        {
            zVelocity=0f;
        }*/

        anim.SetFloat("zVelocity", zVelocity);


           
    }
   

}
