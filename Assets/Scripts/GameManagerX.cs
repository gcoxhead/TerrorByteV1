using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;



public class GameManagerX : MonoBehaviour
{
    // Game Objects
    public TextMeshProUGUI byteText;
    //public TextMeshProUGUI gameOverText;
    public TextMeshProUGUI timeText;
    public TextMeshProUGUI livesText;

    public GameObject uiLevel;
    public GameObject uiStart;
    public GameObject startCamera;
    public GameObject mainCamera;
    public GameObject uiGameOver;
    public GameObject uiReboot;
    public GameObject Level1;
    public AudioSource alarm;
    
    
    // public Button restartButton; 
    // public Button quitButton; 
    // public List<GameObject> targetPrefabs;

    // Game Variables
    private int score;
    private float time; 
    private int lives;
    private int usbScore;
    private int hddScore;
    private int byteScore;
    public bool isGameActive;

    //Static Game Settings
    
    // Start the game, remove start screen, reset scores.
    public void Awake()
    {
       uiStart.gameObject.SetActive(true);
       startCamera.gameObject.SetActive(true);
       uiLevel.gameObject.SetActive(false);
       uiGameOver.gameObject.SetActive(false);
       mainCamera.gameObject.SetActive(false);
       isGameActive = false;
       lives = 2;
       livesText.text = "BackUps:" + lives ;
       
    }
    
    public void StartGame(int difficulty)
    {
        isGameActive = true;
        uiStart.gameObject.SetActive(false);
        uiLevel.gameObject.SetActive(true);

        uiGameOver.gameObject.SetActive(false);
        uiReboot.gameObject.SetActive(false);
    
        startCamera.gameObject.SetActive(false);
        mainCamera.gameObject.SetActive(true);
        byteScore = 0;
        time = 10;
        Debug.Log ("Countdown Set");
        

        //ClearPreviousScore();

        //UpdateScore(0);
        uiStart.gameObject.SetActive(false);
        uiLevel.gameObject.SetActive(true);
        
    }

    public void Update()
    {
        if (Input.GetKey("escape"))
        {
            Application.Quit();
        }
 
        if (isGameActive)
        {
            //countdown timer
            time -= Time.deltaTime;
            timeText.text = ("Time: " + Mathf.Round(time));
            
            // check if countdown time is over

            if (time <0)
            { 
                GameOver();
            }
        }
    }

    

    // Stop game, bring up game over text and restart button
    public void GameOver()
    {
         uiReboot.gameObject.SetActive(true);
         startCamera.gameObject.SetActive(true);
         uiLevel.gameObject.SetActive(false);
         mainCamera.gameObject.SetActive(false);
         isGameActive = false;
         lives -= 1;
         if (lives<0)
             {
                uiGameOver.gameObject.SetActive(true);
                lives = 2;
             }

         livesText.text = "BackUps:" + lives ;

    }

    // Restart game by reloading the scene
    public void RestartGame()
    {
        SceneManager.LoadScene("Level1");
    }

    public void PlayAgain()
    {
        StartGame(1);
    }

    public void ClearPreviousScore()
    {
        byteScore = 0;
        byteText.text = "Bytes:" + byteScore ;
        lives = 3;
        livesText.text = "BackUps:" + lives ;
        //usbScore = 0;
        //.text = "Lives:" + lives ;
        //lives = 3;
        //livesText.text = "Lives:" + lives ;


    }
}
