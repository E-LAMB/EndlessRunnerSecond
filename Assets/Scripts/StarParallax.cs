using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarParallax : MonoBehaviour
{

    float parallax_speed = 0.5f;
    Rigidbody2D playerObject;

    // Update is called once per frame
    void Update()
    {
        float movementValueX = Input.GetAxis("Horizontal");
        playerObject.velocity = new Vector2(movementValueX * parallax_speed, playerObject.velocity.y);
    }
}
