using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class spawnerController : MonoBehaviour
{
    public GameObject book;
    public float spawnRate = 2;
    public float timer = 0;
    public float defaultHeight = 10;
    // Start is called before the first frame update
    void Start()
    {
        spawnBook();
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < spawnRate)
        {
            timer = timer + Time.deltaTime;
        }
        else
        { 
            spawnBook();
            timer = 0;
        }
    }

    void spawnBook()
    {
        float lowestHeight = transform.position.y - defaultHeight;
        float highestHeight = transform.position.y + defaultHeight;
        Instantiate(book, new Vector3(transform.position.x, Random.Range(lowestHeight, highestHeight),0), transform.rotation);
    }
}
