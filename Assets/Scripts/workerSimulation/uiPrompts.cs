using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class uiPrompts : MonoBehaviour
{
    public TextMeshProUGUI pointsText;
    public domoSpawner domoSpwn;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (domoSpwn.playerScore == 0)
        {
            pointsText.text = "Press left click to grab and release the DOMO";
        }
        else {
            pointsText.text = "Points: " + domoSpwn.playerScore.ToString();
        }
    }
}
