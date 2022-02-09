using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollision : MonoBehaviour
{
    public GameObject explosion;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void explosionIns(Vector3 position)
    {
        GameObject a = Instantiate(explosion);
        a.transform.position = position;
        Destroy(a, 2);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.collider.tag == "covid")
        {          
            Vector3 contactPoint = collision.contacts[0].point;
            explosionIns(contactPoint);
            SoundManager.PlayExplosionSound();
            collision.gameObject.SetActive(false);
            this.gameObject.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
