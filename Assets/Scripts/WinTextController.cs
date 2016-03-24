public class WinTextController : UISetup {

    protected override void OnUICreation() // This  code is added to the Start method of the parent class.
    {
        text.text = textInGame;
        text.enabled = false;
    }

    void Update () {
        if (GameController.Instance.LevelWon)
            text.enabled = true;  // I think there's room for improvement here. This will do for now.
	}
}