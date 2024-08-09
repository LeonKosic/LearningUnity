using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawnScript : MonoBehaviour
{    
    [SerializeField]
    private GameObject pipe;
    [SerializeField]
    private float spawnRate = 2;
    [SerializeField]
    private float heightOffset;

    private float time = 0;

    // Start is called before the first frame update
    void Start()
    {
        spawnPipe();   
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        if (time > spawnRate) {
            spawnPipe();
            time-=spawnRate; 
        }
        
    }

    void spawnPipe()
    {
        float lowestPoint = transform.position.y - heightOffset;
        float highestPoint = transform.position.y + heightOffset;
        Instantiate(pipe, new Vector3(transform.position.x,Random.Range(lowestPoint,highestPoint),1), transform.rotation);
    }
}
