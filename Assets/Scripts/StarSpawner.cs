using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarSpawner : MonoBehaviour
{
    public GameObject [] objectsToSpawn;
    Rigidbody2D playerObject;

    float timeToNextSpawn;
    float timeSinceLastSpawn = 0.0f;

    public float distance = 20;

    public float spawntime = 3.0f;
    public float spawntime_stretch = 1f;

    void start()
    {
        timeToNextSpawn = spawntime;
        playerObject = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

        float max_st = spawntime - spawntime_stretch;
        float min_st = spawntime + spawntime_stretch;

        timeSinceLastSpawn = timeSinceLastSpawn + Time.deltaTime;

        if (timeSinceLastSpawn > timeToNextSpawn)
        {
            int selection = Random.Range(0, objectsToSpawn.Length);

            Instantiate(objectsToSpawn[selection],transform.position, Quaternion.identity);


            timeSinceLastSpawn = 0.0f;
            timeToNextSpawn = Random.Range(min_st,max_st);
            playerObject.velocity = new Vector2 (distance,0);
        }
    }
}
