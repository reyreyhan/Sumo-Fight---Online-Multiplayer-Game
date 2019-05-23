using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using Photon.Realtime;

public class Lobby : MonoBehaviourPunCallbacks
{
    public GameObject quickMatchButton;

    // Start is called before the first frame update
    void Start()
    {
        PhotonNetwork.AutomaticallySyncScene = true;
        quickMatchButton.SetActive(false);
        PhotonNetwork.ConnectUsingSettings();
    }

    public override void OnConnectedToMaster()
    {
        quickMatchButton.SetActive(true);
    }

    public void JoinRoom()
    {
        quickMatchButton.SetActive(false);
        PhotonNetwork.JoinRandomRoom();

        StartCoroutine(WaitJoinRoom());
    }

    IEnumerator WaitJoinRoom()
    {
        yield return new WaitForSeconds(2f);

        RoomOptions roomOpt = new RoomOptions() { IsVisible = true, IsOpen = true, MaxPlayers = 2 };
        int roomNumber = Random.Range(0, 1000);
        PhotonNetwork.CreateRoom("Room " + roomNumber.ToString(), roomOpt, null, null);
    }

    public override void OnJoinedRoom()
    {
        StopAllCoroutines();
        PhotonNetwork.LoadLevel("Battle");
    }
}
