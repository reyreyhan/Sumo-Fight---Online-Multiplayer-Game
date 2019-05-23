using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using Photon.Realtime;

public class NetworkCharacter : MonoBehaviourPun, IPunObservable
{

    Vector3 characterPosition;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (photonView.IsMine)
        {
            transform.position = Vector3.Lerp(transform.position, characterPosition, Time.deltaTime * 5);
        }
        
    }

    public void OnPhotonSerializeView(PhotonStream stream, PhotonMessageInfo info)
    {
        if (stream.IsWriting)
        {
            stream.SendNext(transform.position);
        }
        else
        {
            characterPosition = (Vector3)stream.ReceiveNext();
        }

    }
}
