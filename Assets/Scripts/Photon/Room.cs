using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Photon.Pun;
using Photon.Realtime;

public class Room : MonoBehaviour
{
    //public Text roomStatus;
    public GameObject[] player;
    public GameObject button;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //roomStatus.text = "Waiting For Player";
        
        if (PhotonNetwork.CurrentRoom.PlayerCount == 1)
        {
            player[0].SetActive(true);
            player[1].SetActive(false);
            button.SetActive(false);
            Debug.Log(PhotonNetwork.CurrentRoom.PlayerCount);
        } else
        {
            Debug.Log(PhotonNetwork.CurrentRoom.PlayerCount);
            player[0].SetActive(true);
            player[1].SetActive(true);
            button.SetActive(true);
            //roomStatus.text = "Waiting To Battle Room";
            //StartCoroutine(TwoPlayerInRoom());
        }
    }

    IEnumerator TwoPlayerInRoom()
    {
        yield return new WaitForSeconds(2f);
        PhotonNetwork.LoadLevel("Battle");
    }
}
