using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    // target is the player (we want to follow the player)
    public float followSpeed = 2f;
    public Transform target;
    
    private void Update()
    {
        // get the current position of the player, and a position thats 
        Vector3 position = target.position;
        Vector3 newPos = new Vector3(position.x, position.y, -10f);
        // slerp (i think) is supposed to interpolate the difference between the current position
        // of the player and the new position and like smoothly changes the position to that idk its cool :3
        transform.position = Vector3.Slerp(transform.position, newPos, followSpeed * Time.deltaTime);
    }
}
