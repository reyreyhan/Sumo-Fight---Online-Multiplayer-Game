using GooglePlayGames;
using GooglePlayGames.BasicApi;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GooglePlayController : MonoBehaviour
{
    public GameObject loginBtn;

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
                Debug.Log("Brhsl");
            }
            else
            {
                Debug.Log("Gagal Login");
                loginBtn.SetActive(true);
            }
        });
    }
}
