using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Movement : MonoBehaviour
{
    // allow speed and objects to be changed in the unity inspector
    public float speed = 3.5f;
    public Transform player;
    public Vector3 offset;
    
    private void Update()
    {
        CalculateMovement();
    }

    
    private void CalculateMovement()
    {
        // get input as float for both horiz and vert
        float horizInput = Input.GetAxis("Horizontal");
        float vertInput = Input.GetAxis("Vertical");
        
        // create new vector3 for the direction using horiz and vertical, with z set to 0
        // since were in 2d technically
        Vector3 direction = new Vector3(horizInput, vertInput, 0f);
        // transform.Translate will move the current object the script is attached to
        transform.Translate(direction * (speed * Time.deltaTime));
    }
}
