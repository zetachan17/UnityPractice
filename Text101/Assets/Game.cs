using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Game : MonoBehaviour
{
    [SerializeField] Text textComponent;

    // Start is called before the first frame update
    void Start()
    {
        textComponent.text = "This is a story text after clicking 'PLAY'.";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
