using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GooglePlayGames;
using GooglePlayGames.BasicApi;

public class UnlockWinAchievement : MonoBehaviour
{
    int randomPlayerScore;

    // Start is called before the first frame update
    void Start()
    {
        randomPlayerScore = Random.Range(0, 1000);
        PlayGamesPlatform.Instance.ReportProgress(GPGSIds.achievement_menang, 100f, null);
        PlayGamesPlatform.Instance.ReportScore(randomPlayerScore, GPGSIds.leaderboard_score, (bool success) => {
        });

    }

    // Update is called once per frame
    void Update()
    {
        
    }

}
