using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnCovid : MonoBehaviour
{

    public GameObject[] covid;
    public float spawnTime = 1f;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Spawn", spawnTime, spawnTime);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void Spawn()
    {
        int covidNum = Random.Range(0, 3);
        GameObject gameObject = Instantiate(covid[covidNum]);
    }
}
