using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Canyon : MonoBehaviour
{
    public GameObject missilePrefab;
    public float delaySpawn = 0.5f;
    public float intervalSpawn = 2f;
    

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Shoot", delaySpawn, intervalSpawn);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    private void Shoot()
    {
        Instantiate(missilePrefab);
    }

    
}
