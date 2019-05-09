using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using Photon.Realtime;

public class PlayerSync : MonoBehaviour
{
    public GameObject[] pushButton;
    public GameObject[] staminaBar;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(PhotonNetwork.IsMasterClient == true)
        {
            pushButton[1].SetActive(false);
            staminaBar[1].SetActive(false);
        } else
        {
            pushButton[0].SetActive(false);
            staminaBar[0].SetActive(false);
        }
    }
}
