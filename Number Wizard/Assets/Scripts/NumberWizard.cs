using UnityEngine;
using System.Collections;

public class NumberWizard : MonoBehaviour {

    int max;
    int min;
    int guess;

    // Use this for initialization
    void Start () {
        StartGame();
    }

    void StartGame()
    {
        max = 1000;
        min = 1;
        guess = 500;

        print("Welcome to number wizzard");
        print("Pick a number in your head, but dont tell me");


        print("The highest number you can pick is" + max);
        print("The lowset number you can pick is" + min);

        print("Is the number higher or lower than " + guess + "?");
        print("Up arrow for higher");
        print("down arrow for lower");
        print("return for equal");

        max = max + 1;
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            //print("up key was pressed");
            min = guess;
            guess = (max+min)/2 ;
            print("Higher or lower than " + guess + "?");
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            //print("down key was pressed");
            max = guess;
            guess = (min + max) / 2;
            print("Higher or lower than " + guess + "?");
        }
        else if (Input.GetKeyDown(KeyCode.Return))
        {
            print("I won!!");
            StartGame();
        }

    }
}
