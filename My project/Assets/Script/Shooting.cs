using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    // Start is called before the first frame update

    public Transform firePoint;
    public GameObject bullet;
    public AudioSource shoot;
    public float bulletForce = 20f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            shoot.Play();
            Shoot();
        }
    }


    void Shoot()
    {
        GameObject bulletSpawn = Instantiate(bullet, firePoint.position, firePoint.rotation);
        Rigidbody2D rb = bulletSpawn.GetComponent<Rigidbody2D>();
        rb.AddForce(firePoint.up * bulletForce, ForceMode2D.Impulse);
    }
}
