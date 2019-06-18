using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using UnityEngine.SceneManagement;

public class CollisionPlayer : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        PhotonNetwork.AutomaticallySyncScene = false;
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (PhotonNetwork.IsMasterClient)
        {
            if (collision.gameObject.name == "LimitLeft")
            {
                SceneManager.LoadScene("LoseScene");
            }

            if (collision.gameObject.name == "LimitRight")
            {
                SceneManager.LoadScene("WinScene");
            }
        } else
        {
            if (collision.gameObject.name == "LimitLeft")
            {
                SceneManager.LoadScene("WinScene");
            }

            if (collision.gameObject.name == "LimitRight")
            {
                SceneManager.LoadScene("LoseScene");
            }
        }
    }
}
