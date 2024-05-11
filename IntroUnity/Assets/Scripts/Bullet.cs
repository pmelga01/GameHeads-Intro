using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float lifeTime = 1.2f;

    // Start is called before the first frame update
    void Start()
    {
        // Destroy the bullet after a delay
        Destroy(gameObject, lifeTime);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        // The bullet will be destroyed upon collision with any object
        Destroy(gameObject);
    }

    private void OnCollisionEnter(Collision other)
    {
        // if (other.gameObject.layer == LayerMask.NameToLayer("Player"))
        // {
        //     // Destroy the bullet upon collision with an object on the "Player" layer
        //     Destroy(gameObject);
        // }

        
        // The bullet will be destroyed upon collision with player
        if (other.gameObject.CompareTag("Player")) {
            Destroy(gameObject);
        }
        
    }
}
