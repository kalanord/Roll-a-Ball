public class ScoreUIController : UISetup {
       
    private int scoreDisplayed; // Copy of the score.

    protected override void OnUICreation() // This  code is added to the Start method of the parent class.
    {
        SetScoreUI();
    }

    void Update()
    {
        // Instead of updating the UI all the time, I ask if the score has changed first,
        // and if it has, then I show the new score.

        if (scoreDisplayed != GameController.Instance.Score)
            SetScoreUI();
    }

    void SetScoreUI()
    {
        scoreDisplayed = GameController.Instance.Score;
        text.text = textInGame.Trim() + " " + scoreDisplayed;
    }
}
