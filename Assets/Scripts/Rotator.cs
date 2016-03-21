using UnityEngine;
using System.Collections;

public class Rotator : MonoBehaviour {

    Vector3 rotation = new Vector3(15, 30, 45);
    
    // Update is called once per frame
    void Update ()
    {
        //This rotates the cube.
        transform.Rotate(rotation * Time.deltaTime);

        //We multiply movements by deltaTime in order to make them smooth and framerate independent.
        //This is not needed in fixedUpdate since the time between them are always the same.
	}
}
