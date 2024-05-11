using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    public GameObject bulletPrefab;
    public GameObject playerAgent;
    public bool isPlayer = false;
    public float firingRate = 5f;

    private float speed = 300.0f;
    private float currentTime = 0f;

    // Start is called before the first frame update
    void Start()
    {
        playerAgent = transform.parent.gameObject;
    }

    // Update is called once per frame
    void Update()
    {

        bool fireBullet = isPlayer && Input.GetKeyUp(KeyCode.F);

        if (!isPlayer) {
            
            currentTime += Time.deltaTime;
            if (currentTime > firingRate) {
                currentTime = 0f;
                fireBullet = true;
            }

            if (fireBullet) {
                PlayerShoot();
            }
        }
        

        
    }

    void PlayerShoot()
    {
        Vector3 firePosition = transform.position + transform.forward * 1.5f;

        GameObject spawnBullet = GameObject.Instantiate(bulletPrefab, firePosition, Quaternion.identity);
        Rigidbody rb = spawnBullet.GetComponent<Rigidbody>();
        if (rb != null) {
            rb.AddForce(playerAgent.transform.forward * speed);
        }
        
    }
}
