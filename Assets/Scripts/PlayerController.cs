using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

    private float moveHorizontal; // The tutorial creates this variables in FixedUpdate.
    private float moveVertical;   // I create them here because it seems logical to just create them once.

    private Vector3 movement; // We create it here so it's accesible everywhere in the class and it's
                              // not so expensive in performance as creating it in and Update method.

    private Rigidbody rb; // This variable is used to hold a reference to the attached
                          // Rigidbody component in the same game object.

    public float speed; //Used to control Player speed. Since it's public, we can change its value in the Editor.
    
    // Use this for initialization
    // Start is called on the first frame the script is active. Awake is called always a game object is set active.
	void Start ()
    {
        rb = GetComponent<Rigidbody>(); //We set the reference to our Rigidbody here.

        movement = Vector3.zero;

        moveHorizontal = 0;
        moveVertical = 0;
	}
    
    // FixedUpdate is called before performing physics calculations
    // We'll move the ball by applying force, so movement must be here.
    void FixedUpdate()
    {
        //I use the Top Down coding technic.
        MovePlayer();
    }

    void MovePlayer()
    {
        // The Input class is the Interface into the Input system.
        // Use this class to read the axes set up in the Input Manager, and to access multi-touch/accelerometer data on mobile devices.

        moveHorizontal = Input.GetAxis("Horizontal"); //Returns the value of the virtual axis identified by axisName in the Unity Project Settings.
        moveVertical = Input.GetAxis("Vertical");

        movement.Set(moveHorizontal, 0.0f, moveVertical); // I use "Set" because using "new" to set values creates another instance of the object.
                                                          // I want to use the same to save memory and CPU. So "Set" is the way to go.
                                                          // Basically, THIS AVOIS HEAP FRAGMENTATION.

        rb.AddForce(movement * speed); //Using our reference to the Rigidbody we can apply the movement Vector3 as a force with the AddForce method.
    }
}
