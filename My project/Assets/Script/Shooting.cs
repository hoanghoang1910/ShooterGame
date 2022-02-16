using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    // Start is called before the first frame update

    public Transform firePoint;
    public GameObject[] bullet;
    public AudioSource shoot;
    public float bulletForce = 20f;
    private GameObject selectedBullet;
    void Start()
    {
        selectedBullet = bullet[0];
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            Debug.Log("Switch to red bullet");
            selectedBullet = bullet[0];
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            Debug.Log("Switch to yellow bullet");
            selectedBullet = bullet[1];
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            Debug.Log("Switch to purple bullet");
            selectedBullet = bullet[2];
        }
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            shoot.Play();
            Shoot();
        }
    }


    void Shoot()
    {
        GameObject bulletSpawn = Instantiate(selectedBullet, firePoint.position, firePoint.rotation);
        Rigidbody2D rb = bulletSpawn.GetComponent<Rigidbody2D>();
        rb.AddForce(firePoint.up * bulletForce, ForceMode2D.Impulse);
    }
}
