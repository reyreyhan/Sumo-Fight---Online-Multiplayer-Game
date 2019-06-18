using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using UnityEngine.SceneManagement;

public class CollisionPlayer : MonoBehaviour
{
    public GameObject[] btnWinLose;
    // Start is called before the first frame update
    void Start()
    {
        PhotonNetwork.AutomaticallySyncScene = false;
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(PhotonNetwork.IsMasterClient);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (PhotonNetwork.IsMasterClient)
        {
            if (collision.gameObject.name == "LimitLeft")
            {
                SceneManager.LoadScene("LoseScene");
                //Debug.Log(PhotonNetwork.IsMasterClient);
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
                //Debug.Log(PhotonNetwork.IsMasterClient);
            }

            if (collision.gameObject.name == "LimitRight")
            {
                SceneManager.LoadScene("LoseScene");
            }
        }
    }
}
