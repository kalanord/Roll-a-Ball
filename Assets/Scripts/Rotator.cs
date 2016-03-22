using UnityEngine;
using System.Collections;

public class Rotator : MonoBehaviour {

    Vector3 rotation = new Vector3(15, 30, 45);
    
    // Update is called once per frame
    void Update ()
    {
        // This rotates the cube.
        transform.Rotate(rotation * Time.deltaTime);

        // We multiply movements by deltaTime in order to make them smooth and framerate independent.
        // This is not needed in fixedUpdate since the time between them are always the same.

        // REMEMBER TO ADD A RIGIDBODY TO ANYTHING THIS SCRIPT IS ATTACHED TO
        // This optimizes Unity's calculations since the game object will be a dynamic one instead of a static one.

        // This script works with the Is Kinematic option. When kinematic, a game object isn't affected by any physics forces,
        // but it can still be moved and animated by its transform.
	}
}
