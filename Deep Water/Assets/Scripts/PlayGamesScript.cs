using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GooglePlayGames;
using GooglePlayGames.BasicApi;

public class PlayGamesScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        PlayGamesClientConfiguration config = new PlayGamesClientConfiguration.Builder().Build();
        PlayGamesPlatform.InitializeInstance(config);
        PlayGamesPlatform.Activate();

        SignIn();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SignIn()
    {
        Social.localUser.Authenticate(sucess => { });
    }

    #region Achievements
    public static void UnlockAchievement(string id)
    {
        Social.ReportProgress(id, 100, sucess => { });
    }
    public static void IncrementAchievement(string id, int stepsToIncrement)
    {
        PlayGamesPlatform.Instance.IncrementAchievement(id, stepsToIncrement, sucess => { });
    }

    public static void ShowAchievementUI()
    {
        Social.ShowAchievementsUI();
    }
    #endregion /Achievements

    #region Leaderboards
    public static void AddScoreToLeaderboard(string leaderboardId, long score)
    {
        Social.ReportScore(score, leaderboardId, sucess => { });
    }
    public static void ShowLeaderboardsUI()
    {
        Social.ShowLeaderboardUI();
    }

    #endregion /Leaderboards
}
