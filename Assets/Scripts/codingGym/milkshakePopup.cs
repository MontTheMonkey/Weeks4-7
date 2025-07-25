using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.AI;
using TMPro;
using UnityEngine.UI;

public class milkshakePopup : MonoBehaviour
{
    // Start is called before the first frame update
    public playerChar pChar;
    public GameObject mShake;
    public TMP_Text milkText;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //In-game position of the milkshake
        if (pChar.playerPos.x > -7 && pChar.playerPos.x < -3 && pChar.playerPos.y > 0 && pChar.playerPos.y < 3)
        {
            mShake.SetActive(true);
            Debug.Log("Player is near the milkshake");
        }
        else
        {
            mShake.SetActive(false);
            Debug.Log("Player is away from the milkshake");
        }
    }
}
