using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using GooglePlayGames;

public class GameControl : MonoBehaviour
{
    public int coinsAmount;
    public Text coinsAmountText;
    public int score;
    public Text scoreText;
    public int highscore;
    public Text highscoreText;
    private bool isPaused;

    Audio au;
    UI ui;
    PlayerCustomisationControl pcc;
    UnityAdsButton uab;

    //int isSkin2Sold;
    //public GameObject skin2;
    //int isSkin3Sold;
    //public GameObject skin3;

    //SpawnScript spawn;
    //InputManager im;

    //int score = 0;

    // Start is called before the first frame update
    void Start()
    {
        /*if (Input.touchCount >= 1)
        {
            coinsAmount = PlayerPrefs.GetInt("CoinsAmount");
            SceneManager.LoadScene("Game");
            Time.timeScale = 1.0f;

        }*/
        isPaused = false;

        au = FindObjectOfType<Audio>();
        ui = FindObjectOfType<UI>();
        pcc = FindObjectOfType<PlayerCustomisationControl>();
        uab = FindObjectOfType<UnityAdsButton>();

        coinsAmount = PlayerPrefs.GetInt("CoinsAmount");
        highscore = PlayerPrefs.GetInt("Highscore");

        //PlayerPrefs.SetInt("isSkin2Sold", 0);
        //PlayerPrefs.SetInt("isSkin3Sold", 0);

        /*pcc.isSkin2Sold = PlayerPrefs.GetInt("isSkin2Sold");
        pcc.isSkin3Sold = PlayerPrefs.GetInt("isSkin3Sold");
        pcc.isSkin4Sold = PlayerPrefs.GetInt("isSkin4Sold");
        pcc.isSkin5Sold = PlayerPrefs.GetInt("isSkin5Sold");
        pcc.isSkin6Sold = PlayerPrefs.GetInt("isSkin6Sold");*/

        pcc.isSkin2Equipped = PlayerPrefs.GetInt("isSkin1Equipped");
        pcc.isSkin2Equipped = PlayerPrefs.GetInt("isSkin2Equipped");
        pcc.isSkin3Equipped = PlayerPrefs.GetInt("isSkin3Equipped");
        pcc.isSkin4Equipped = PlayerPrefs.GetInt("isSkin4Equipped");
        pcc.isSkin5Equipped = PlayerPrefs.GetInt("isSkin5Equipped");
        pcc.isSkin6Equipped = PlayerPrefs.GetInt("isSkin6Equipped");

        pcc.isTrail2Equipped = PlayerPrefs.GetInt("isTrail1Equipped");
        pcc.isTrail2Equipped = PlayerPrefs.GetInt("isTrail2Equipped");
        pcc.isTrail3Equipped = PlayerPrefs.GetInt("isTrail3Equipped");
        pcc.isTrail4Equipped = PlayerPrefs.GetInt("isTrail4Equipped");
        pcc.isTrail5Equipped = PlayerPrefs.GetInt("isTrail5Equipped");
        pcc.isTrail6Equipped = PlayerPrefs.GetInt("isTrail6Equipped");

        //spawn = FindObjectOfType<SpawnScript>();
        //im = FindObjectOfType<InputManager>();
    
    }

    void Update()
    {
        coinsAmountText.text = coinsAmount.ToString();
        scoreText.text = score.ToString();
        highscoreText.text = highscore.ToString();

        if (score > highscore)
        {
            highscore = score;
            PlayGamesScript.AddScoreToLeaderboard(GPGSIds.leaderboard_highscore, highscore);
        }
    }

    public void leaderboards()
    {
        if (!isPaused)
        {
            isPaused = !isPaused;
            ui.leaderboards.SetActive(true);
        }
        else
        {
            isPaused = !isPaused;
            ui.leaderboards.SetActive(false);
        }
    }
    public void goToChallenges()
    {
        if (!isPaused)
        {
            isPaused = !isPaused;
            ui.menuScreen.SetActive(false);
            ui.challengesScreen.SetActive(true);
        }
    }

    public void goToStore()
    {
        if (!isPaused)
        {
            isPaused = !isPaused;
            ui.menuScreen.SetActive(false);
            ui.storeScreen.SetActive(true);
        }
    }

    public void goToPlayer()
    {
        if (!isPaused)
        {
            isPaused = !isPaused;
            ui.menuScreen.SetActive(false);
            ui.playerScreen.SetActive(true);
        }
    }
    
    public void gameOver()
    {
        Time.timeScale = 0.0f;
        ui.gameOverScreen.SetActive(true);
    }

    public void Continue()
    {
        //uab.ShowAd();
        Time.timeScale = 1.0f;
        ui.gameOverScreen.SetActive(false);
    }

    public void backBtn()
    {
        if (isPaused)
        {
            isPaused = !isPaused;
            ui.storeScreen.SetActive(false);
            ui.playerScreen.SetActive(false);
            ui.menuScreen.SetActive(true);
        }
    }

    public void skinsBtn()
    {
        ui.skinsScreen.SetActive(true);
        ui.trailScreen.SetActive(false);
        ui.powerupsScreen.SetActive(false);
    }

    public void trailsBtn()
    {
        ui.skinsScreen.SetActive(false);
        ui.trailScreen.SetActive(true);
        ui.powerupsScreen.SetActive(false);
    }

    public void powerupsBtn()
    {
        ui.skinsScreen.SetActive(false);
        ui.trailScreen.SetActive(false);
        ui.powerupsScreen.SetActive(true);
    }
    
    public void quitBtn()
    {
        PlayerPrefs.SetInt("CoinsAmount", coinsAmount);
        PlayerPrefs.SetInt("Highscore", highscore);
        SceneManager.LoadScene("Menu");
    }

    public void musicToggle()
    {
        au.musicToggle = !au.musicToggle;
        if (!au.musicToggle)
        {
            au.musicSource.volume = 1f;
        }
        else
        {
            au.musicSource.volume = 0f;
        }
    }

    public void ShowEndMenu()
    {
        // Submit leaderboard scores, if authenticated
        if (PlayGamesPlatform.Instance.localUser.authenticated)
        {
            // Note: make sure to add 'using GooglePlayGames'
            PlayGamesPlatform.Instance.ReportScore(highscore,
                GPGSIds.leaderboard_highscore,
                (bool success) =>
                {
                    Debug.Log("(Deep Water) Leaderboard update success: " + success);
                });
        }
    }


    /*public void showLeaderboards()
    {
        PlayGamesScript.ShowLeaderboardsUI();
    }*/
    
    public void startGame()
    {
        PlayerPrefs.SetInt("CoinsAmount", coinsAmount);
        //PlayerPrefs.SetInt("Highscore", score);
        SceneManager.LoadScene("Game");
        Time.timeScale = 1.0f;
    }

    public void privacyPolicy()
    {
        Application.OpenURL("https://deep-water.flycricket.io/privacy.html");
    }
}