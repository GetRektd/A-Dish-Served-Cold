using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
   private Rigidbody enemyRb;
    private GameObject player;
    public float speed = 0.5f;
    public int currentHealth;
    public int maxHealth = 3;
    Vector3 lookDirection;
    
    // Start is called before the first frame update
    void Awake()
    {
        player = GameObject.FindObjectOfType<PlayerController>().gameObject;
        enemyRb = GetComponent<Rigidbody>();
        currentHealth = maxHealth;
    }

    // Update is called once per frame
    void Update()
    {
         lookDirection = (player.transform.position - transform.position).normalized;

         if(currentHealth < 1)
         {
            Destroy(gameObject);

         }
    }

    void FixedUpdate()
    {
        if (player != null) 
        {
             enemyRb.AddForce(lookDirection * 0.5f); 
        }
       
    }

    public void ChangeHealth(int amount)
    {
        currentHealth = Mathf.Clamp(currentHealth + amount, 0, maxHealth);
        Debug.Log(currentHealth + "/" + maxHealth);
    }
}
