using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObject : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (this.gameObject.name == "Player(Clone)")
        {
            transform.Translate(Vector3.right * 1 * Time.deltaTime);
        } else if (this.gameObject.name == "Player2(Clone)")
        {
            transform.Translate(Vector3.left * 1 * Time.deltaTime);
        }
    }

    public void MovePlayerMaster()
    {
        transform.Translate(Vector3.right * 1 * Time.deltaTime);
    }

    public void MovePlayerClient()
    {
        transform.Translate(Vector3.left * 1 * Time.deltaTime);
    }
}
