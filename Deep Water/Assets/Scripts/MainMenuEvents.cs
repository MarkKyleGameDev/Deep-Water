using System.Collections;
using GooglePlayGames;
using GooglePlayGames.BasicApi;
using UnityEngine;
using UnityEngine.UI;

public class MainMenuEvents : MonoBehaviour
{
    private Text signInButtonText;
    private Text authStatus;

    private GameObject achButton;
    private GameObject ldrButton;
    public void Start()
    {
        achButton = GameObject.Find("achButton");
        ldrButton = GameObject.Find("ldrButton");

        signInButtonText =
           GameObject.Find("GooglePlayServicesBtn").GetComponentInChildren<Text>();
        authStatus = GameObject.Find("authStatus").GetComponent<Text>();

        GameObject startButton = GameObject.Find("Menu");
        //EventSystem.current.firstSelectedGameObject = startButton;


        //  ADD THIS CODE BETWEEN THESE COMMENTS

        // Create client configuration
        PlayGamesClientConfiguration config = new
            PlayGamesClientConfiguration.Builder()
            .Build();

        // Enable debugging output (recommended)
        PlayGamesPlatform.DebugLogEnabled = true;

        // Initialize and activate the platform
        PlayGamesPlatform.InitializeInstance(config);
        PlayGamesPlatform.Activate();
        //SignIn();
        // END THE CODE TO PASTE INTO START
        PlayGamesPlatform.Instance.Authenticate(SignInCallback, true);
    }

    public void Update()
    {
        achButton.SetActive(Social.localUser.authenticated);
        ldrButton.SetActive(Social.localUser.authenticated);
    }
    private void Awake()
    {
        if (!PlayGamesPlatform.Instance.localUser.authenticated)
        {
            // Sign in with Play Game Services, showing the consent dialog
            // by setting the second parameter to isSilent=false.
            PlayGamesPlatform.Instance.Authenticate(SignInCallback, false);
        }
        else
        {
            // Sign out of play games
            PlayGamesPlatform.Instance.SignOut();

            // Reset UI
            signInButtonText.text = "Sign In";
            authStatus.text = "";
        }
    }

    public void SignInCallback(bool success)
    {
        if (success)
        {
            Debug.Log("(Deep Water) Signed in!");

            // Change sign-in button text
            signInButtonText.text = "Sign out";

            // Show the user's name
            authStatus.text = "Signed in as: " + Social.localUser.userName;
        }
        else
        {
            Debug.Log("(Deep Water) Sign-in failed...");

            // Show failure message
            signInButtonText.text = "Sign in";
            authStatus.text = "Sign-in failed";
        }
    }

    public void ShowAchievements()
    {
        if (PlayGamesPlatform.Instance.localUser.authenticated)
        {
            PlayGamesPlatform.Instance.ShowAchievementsUI();
        }
        else
        {
            Debug.Log("Cannot show Achievements, not logged in");
        }
    }
    public void ShowLeaderboards()
    {
        if (PlayGamesPlatform.Instance.localUser.authenticated)
        {
            PlayGamesPlatform.Instance.ShowLeaderboardUI();
        }
        else
        {
            Debug.Log("Cannot show leaderboard: not authenticated");
        }
    }
}