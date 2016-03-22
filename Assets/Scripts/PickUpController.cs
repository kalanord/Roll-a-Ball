using UnityEngine;
using System.Collections;

public class PickUpController : MonoBehaviour {

    /* In the tutorial, the player has the code to disable things it pick ups.
     * This is bad because:
     * 1) We are giving control of an object's state to another object, 
     * instead of letting every object control their own.
     * 2) The Pick Ups can only collide with the Player, but the Player can 
     * collide with everything else on the level.
     *
     * So, I created another this other script, apart from the Rotator, just to control
     * the Pick Up state in the game. */

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            this.gameObject.SetActive(false);
        }
    }
}
