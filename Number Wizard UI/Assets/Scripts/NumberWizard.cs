using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour
{
    [SerializeField] int max;
    [SerializeField] int min;
    int guess;

    public void OnPressHigher()
    {
        min = guess;
        NextGuess();
    }

    public void OnpressLower()
    {
        max = guess;
        NextGuess();
    }
        
    // Start is called before the first frame update
    void Start()
    {
        StartGame();
    }

    void StartGame()
    {
        max = max + 1;
        guess = (max + min) / 2;
    }

    void NextGuess()
    {
        guess = (max + min) / 2;
    }

    
}
