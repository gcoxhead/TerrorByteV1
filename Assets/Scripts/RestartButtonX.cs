using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RestartButtonX : MonoBehaviour
{
    private Button button;
    private GameManagerX gameManagerX;
    //public int difficulty;

    // Start is called before the first frame update
    void Start()
    {
        button = GetComponent<Button>();
        button.onClick.AddListener(SetRestart);
        gameManagerX = GameObject.Find("Game Manager").GetComponent<GameManagerX>();
        
    }

    /* When a button is clicked, call the StartGame() method
     * and pass it the difficulty value (1, 2, 3) from the button 
    */
    void SetRestart()
    {
        Debug.Log(button.gameObject.name + " was clicked");
        gameManagerX.RestartGame();
    }



}