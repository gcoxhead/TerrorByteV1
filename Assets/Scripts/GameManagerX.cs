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
    public GameObject itemCount;
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
       //uiStart.gameObject.SetActive(true);
       StartGame(1);
    }
    
    
    public void StartGame(int difficulty)
    {
        isGameActive = true;
        uiStart.gameObject.SetActive(false);

        byteScore = 0;
        time = 60;
        Debug.Log ("Countdown Set");
        lives = 3;

        ClearPreviousScore();

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
            time -= Time.deltaTime;
            timeText.text = ("Time: " + Mathf.Round(time));

            if (time <0)
            { 
                GameOver();
            }
        }
    }

    //public void UpdateScore(int scoreToAdd)
    //{

       // score += scoreToAdd;
       // scoreText.text = "Score:"+ score;

       // if (score>highScore)
       // {
         //   highScore = score;
          //  highscoreText.text = "Highscore" + highScore;
       // }
        
       // if (scoreToAdd == 15 )
      //  {
          //  blueberryScore += 1 ;
          //  blueberryCount.text = "" + blueberryScore ;

       // }
        
        // if (scoreToAdd == 10 )
       // {
        //    strawberryScore += 1 ;
       //     strawberryCount.text = "" + strawberryScore ;

       // }

        // if (scoreToAdd == 5 )
        //{
          //  daisyScore += 1 ;
         //   daisyCount.text = "" + daisyScore ;

       // }
        

        //highscoreText.text = "Highscore: " + highScore;

        //health += scoreToAdd;

        //if (health >= 100)
        //{
           // health = 100;
          //  healthText.text = "Health:"+ health + "%";
        //}
        //else if (health <= 0)
        //{
           // health = 0;
            //healthText.text = "Health:"+ health + "%";
           // GameOver();
        //}
       // else
        //healthText.text = "Health:"+ health;
   // }

    // Stop game, bring up game over text and restart button
    public void GameOver()
    {
        //gameOverText.gameObject.SetActive(true);
        //restartButton.gameObject.SetActive(true);
        //quitButton.gameObject.SetActive(true);
        //highscoreText.gameObject.SetActive(true);
        //scoreText.gameObject.SetActive(false);
        //timerText.gameObject.SetActive(false);
        isGameActive = false;
        
    }

    // Restart game by reloading the scene
    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
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
        livesText.text = "Lives:" + lives ;
        //usbScore = 0;
        //.text = "Lives:" + lives ;
        //lives = 3;
        //livesText.text = "Lives:" + lives ;


    }

}
