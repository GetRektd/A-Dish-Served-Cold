using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisions : MonoBehaviour
{
    Enemy enemyscript;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    // Desroyers and colliders that are hit by "Weapon"
    void OnTriggerEnter(Collider other)
    {
        Debug.Log("Hit anything");
        if (other.gameObject.CompareTag("Enemy"))
        {
            Debug.Log("Hit Enemy");
            enemyscript = other.gameObject.GetComponent<Enemy>();
            if(enemyscript != null)
            {
                enemyscript.ChangeHealth(-5);
                if(enemyscript.currentHealth == 0)
                {
                    Destroy(other.gameObject);

                }
            }
           
        } 

    }
}
