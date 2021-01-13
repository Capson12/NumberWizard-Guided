using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour
{

    int maximum = 500;
    int minimum = 1;
    int guess = 250;

    // Start is called before the first frame update
    void Start()
    {
        StartGame();
       
        
    }

    void StartGame()
    {
        maximum = 500;
        minimum = 1;
        guess = 250;
         
        Debug.Log("Welcome to number wizard guys!");
        Debug.Log("Pick a number, and don't tell me");

        Debug.Log("The highest it can be is: " + maximum);
        Debug.Log("The Lowest it can be is: " + minimum);
        Debug.Log("Tell me if your nunber is lower or higher than " + guess);
        Debug.Log("Press up or down on the keyboard if it your number is higher or lower than the displayed. Then press 'Enter' when the Number is correct!");
        
        
        maximum = maximum + 1;


    }

    // Update is called once per frame
    void Update()
    {
        
        
        
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            
            minimum = guess; 
            NextGuess();
        }
        

        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            maximum = guess;
            NextGuess();
        }

        else if (Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("I guessed the right number!!!");
            StartGame();
        }
    }

    void NextGuess()
    {


        guess = (maximum + minimum) / 2;
        Debug.Log("Is it Higher or lower than: " + guess);
    }
    
}

