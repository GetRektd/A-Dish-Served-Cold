using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
   private Rigidbody enemyRb;
    private GameObject player;
    public float speed = 0.5f;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player");
    enemyRb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
         Vector3 lookDirection = (player.transform.position 
       - transform.position).normalized;
       enemyRb.AddForce(lookDirection * 0.5f); 

       
    }
}
