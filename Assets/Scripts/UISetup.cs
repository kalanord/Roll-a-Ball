using UnityEngine;
using UnityEngine.UI;

public class UISetup : MonoBehaviour {

    protected Text text; // Reference to our Text Component. It's protected instead of private so the child objects can access it.

    [SerializeField]
    protected string textInGame; // Text that can be modified from the Editor to be shown in game, without using the placeholder one.

    void Start () {

        text = GetComponent<Text>(); // Setting the reference to our Text Component.
        OnUICreation(); //This virtual method lets me add code to this Start metho from the child.
    }

    protected virtual void OnUICreation() { }
}