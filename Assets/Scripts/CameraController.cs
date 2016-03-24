using UnityEngine;

public class CameraController : MonoBehaviour {

    // Making the camera a child of the player game object makes it rotate, and we don't want that.
    // This script is to avoid that behaviour, we copy the player's position and ignore the rotation.

    [SerializeField] // Explained in PickUpController script.
    private GameObject player; //Reference to the Player game object so we can get its position.

    private Vector3 offset; // Difference between the camera and the Player.

	// Use this for initialization
	void Start () {
        offset = transform.position - player.transform.position; //Rotation is not taken into account here.
	}
	
	// LateUpdate is garantied to run after all updates, so it's great for cameras and procedural animation.
	void LateUpdate () {
        transform.position = player.transform.position + offset;
	}
}
