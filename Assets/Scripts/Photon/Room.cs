using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Photon.Pun;
using Photon.Realtime;

public class Room : MonoBehaviour
{
    //public Text roomStatus;
    public GameObject[] playerSpawnPoint;
    public GameObject[] player;
    public GameObject button;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (PhotonNetwork.CurrentRoom.PlayerCount == 2)
        {
            button.gameObject.SetActive(true);
        }
    }

    IEnumerator TwoPlayerInRoom()
    {
        yield return new WaitForSeconds(2f);
        PhotonNetwork.LoadLevel("Battle");
    }
}
