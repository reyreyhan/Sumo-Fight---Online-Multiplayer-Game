using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class PushController : MonoBehaviour
{

    public GameObject player;

    // Start is called before the first frame update
    public void Start()
    {
    }

    // Update is called once per frame
    public void Update()
    {

    }

    public void Push()
    {
        player.transform.Translate(Vector2.right * 15 * Time.deltaTime);
    }
}
