using UnityEngine;
using UnityEngine.UI;

public class NumberWizard : MonoBehaviour
{
    public Text guessText;

    int max = 1000;
    int min = 1;
    int guess;
    int maxGuessesAllowed = 5;

    void Start ()
    {
        NextGuess();
    }

    public void GuessLower()
    {
        max = guess;
        NextGuess();
    }

    public void GuessHigher()
    {
        min = guess;
        NextGuess();
    }

    private void NextGuess()
    {
        guess = Random.Range(min, max + 1);
        guessText.text = guess.ToString();
        maxGuessesAllowed = maxGuessesAllowed - 1;
        if (maxGuessesAllowed <= 0)
            Application.LoadLevel("Win");
    }
}
