using UnityEngine;

public class PickUpController : MonoBehaviour {

    // I want to set this value in the Editor, so...
    [SerializeField]           // This way, the private property can't be edited by other objects,
    private int pickUpValue;   // but it can be edited in the Editor.

    void OnEnable()
    {
        GameController.Instance.pickUpCreated(pickUpValue);
    }
    
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
        if (other.gameObject.CompareTag("Player"))
        {
            GameController.Instance.AddToScore(pickUpValue);

            gameObject.SetActive(false);
        }
    }
}
