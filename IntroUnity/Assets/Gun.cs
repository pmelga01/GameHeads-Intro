using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    public GameObject bulletPrefab;
    public GameObject playerAgent;

    private float speed = 300.0f;

    // Start is called before the first frame update
    void Start()
    {
        playerAgent = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F)) {
            PlayerShoot();
        }
        
    }

    void PlayerShoot()
    {
        GameObject spawnBullet = GameObject.Instantiate(bulletPrefab, transform.position, Quaternion.identity);
        Rigidbody rb = spawnBullet.GetComponent<Rigidbody>();
        rb.AddForce(playerAgent.transform.forward * speed);
    }
}
