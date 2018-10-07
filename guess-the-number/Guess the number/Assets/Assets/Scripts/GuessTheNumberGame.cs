using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GuessTheNumberGame : MonoBehaviour {

    public InputField input;
    public Text infoText;

    private int guessNumber;
    private int usersGuess;

	void Start () {
        guessNumber = Random.Range(0, 100);
	}

    public void CheckGuess() {
        usersGuess = int.Parse(input.text);

        if (usersGuess == guessNumber) {
            infoText.text = "You guessed the number!";
        } else if (usersGuess < guessNumber) {
            infoText.text = "Your guess is lower than the guess number.";
        } else {
            infoText.text = "Your guess is greater than the guess number";
        }

        input.text = "";
    }
}
