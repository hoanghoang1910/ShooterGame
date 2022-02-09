using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class covidAction : MonoBehaviour
{

    public float speed;
    public GameObject player;
    
    void Start()
    {
        player = GameObject.Find("Circle");
    }

    // Update is called once per frame
    void Update()
    {
        float step = speed * Time.deltaTime;
        transform.position = Vector2.MoveTowards(transform.position, player.transform.position, step);
    }
}
