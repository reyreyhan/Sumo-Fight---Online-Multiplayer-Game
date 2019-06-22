using GooglePlayGames;
using GooglePlayGames.BasicApi;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GooglePlayController : MonoBehaviour
{
    public GameObject loginBtn, leaderboardBtn, achievementBtn;

    // Start is called before the first frame update
    void Start()
    {
        Auth();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Auth()
    {
        PlayGamesClientConfiguration config = new PlayGamesClientConfiguration.Builder().Build();
        PlayGamesPlatform.InitializeInstance(config);
        PlayGamesPlatform.Activate();

        Social.localUser.Authenticate((bool success) =>
        {
            if (success == true)
            {
                FirstLogin();
                leaderboardBtn.SetActive(true);
                achievementBtn.SetActive(true);
            }
            else
            {
                loginBtn.SetActive(true);
            }
        });
    }

    public void ShowLeaderboardUI()
    {
        PlayGamesPlatform.Instance.ShowLeaderboardUI(GPGSIds.leaderboard_score);
    }

    public void ShowAchievementUI()
    {
        PlayGamesPlatform.Instance.ShowAchievementsUI();
    }

    public void FirstLogin()
    {
        PlayGamesPlatform.Instance.ReportProgress(GPGSIds.achievement_login, 100f, null);
    }

    public void Win()
    {
        PlayGamesPlatform.Instance.ReportProgress(GPGSIds.achievement_menang, 100f, null);
    }

    public void Lose()
    {
        PlayGamesPlatform.Instance.ReportProgress(GPGSIds.achievement_kalah, 100f, null);
    }
}
