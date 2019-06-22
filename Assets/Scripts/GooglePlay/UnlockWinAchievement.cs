using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GooglePlayGames;
using GooglePlayGames.BasicApi;

public class UnlockWinAchievement : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        PlayGamesPlatform.Instance.ReportProgress(GPGSIds.achievement_menang, 100f, null);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
