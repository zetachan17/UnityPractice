using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class NumberWizard : MonoBehaviour
{
    [SerializeField] int max;
    [SerializeField] int min;
    [SerializeField] TextMeshProUGUI guessText;

    int guess;

    public void OnPressHigher()
    {
        min = guess + 1;
        NextGuess();
    }

    public void OnpressLower()
    {
        max = guess - 1;
        NextGuess();
    }
        
    // Start is called before the first frame update
    void Start()
    {
        NextGuess();
    }

    void NextGuess()
    {
        guess = Random.Range(min, max + 1);
        guessText.text = guess.ToString();
    }

    
}
