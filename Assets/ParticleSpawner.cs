using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleSpawner : MonoBehaviour
{
    // we can pass in what gameobjects we want to spawn, and we also
    // pass in the player as an object to get their position (we should prob offset the spawn pos
    // based on the player pos)
    public float spawnTime;
    public GameObject particle1, particle2, particle3;
    public GameObject player;
    public int pickObject;
    
    void Start()
    {
        spawnTime = Random.Range(0.5f, 2.5f);
    }
    
    private void Update()
    {
        spawnTime -= Time.deltaTime;
        // if spawnTime reaches 0 then we spawn a new object
        if (spawnTime <= 0)
        {
            // choose a random num from 1-3
            pickObject = Random.Range(1, 4);
            Spawn();
            // change the spawn time to be random in between two floats
            spawnTime = Random.Range(0.5f, 2.5f);
        }
    }

    private void Spawn()
    {
        // get position of player currently
        Vector3 playerPos = player.transform.position;
        
        // switch statement to spawn different particles randomly
        
        //Pablito will rewrite this to make it less redundant xP
        switch (pickObject)
        {
            case 1:
                Instantiate(particle1, new Vector3(playerPos.x, playerPos.y, playerPos.z), Quaternion.identity);
                break;
            case 2:
                Instantiate(particle2, new Vector3(playerPos.x, playerPos.y, playerPos.z), Quaternion.identity);
                break;
            case 3:
                Instantiate(particle3, new Vector3(playerPos.x, playerPos.y, playerPos.z), Quaternion.identity);
                break;
        }
    }
    
}
