using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] GameObject[] arrayOfPlayer;
    [SerializeField] GameObject staminaBar;

    private const bool isHost = true;
    private const float MAX_STAMINA = 1000, MAX_PUSH_POINTS = 2000, STAMINA_REGEN = 1, PUSH_STAMINA_COST = 100;

    
    private float stamina, pushPoints;

    public float Stamina { get => stamina; set => stamina = value; }
    public float PushPoints { get => pushPoints; set => pushPoints = value; }

    // Start is called before the first frame update
    void Start()
    {
        InitPlayers();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (CheckEndGame())
        {
            UpdatePlayers();
            UpdateStamina();
        }
    }

    public void OnClickPushButton()
    {
        if (Stamina >= PUSH_STAMINA_COST)
        {
            Stamina -= 100;
            PushPoints += 50;
        }
    }

    private void InitPlayers()
    {
        Stamina = MAX_STAMINA;
        PushPoints = MAX_PUSH_POINTS/2;
    }

    private bool CheckEndGame()
    {
        if (PushPoints > MAX_PUSH_POINTS){
            Debug.Log("You Win");
            return false;
        }
        else if(PushPoints < 0){
            Debug.Log("You Lose");
            return false;
        }

        return true;
    }

    private void UpdatePlayers()
    {
        if (isHost)
        {
            arrayOfPlayer[0].transform.position = new Vector3(-3 + (5 * PushPoints / MAX_PUSH_POINTS), 0);
            arrayOfPlayer[1].transform.position = new Vector3(-2 + (5 * PushPoints / MAX_PUSH_POINTS), 0);
        }
        else
        {
            arrayOfPlayer[1].transform.position = new Vector3(-3 + (5 * PushPoints / MAX_PUSH_POINTS), 0);
            arrayOfPlayer[0].transform.position = new Vector3(-2 + (5 * PushPoints / MAX_PUSH_POINTS), 0);
        }
    }

    private void UpdateStamina()
    {
        if(Stamina< MAX_STAMINA)
            Stamina += STAMINA_REGEN;

        if (Stamina >= MAX_STAMINA)
            Stamina = MAX_STAMINA;

        staminaBar.transform.localScale = new Vector3(Stamina / MAX_STAMINA, 1);
    }
}
