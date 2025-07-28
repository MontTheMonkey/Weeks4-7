using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class uiPrompts : MonoBehaviour
{
    public TextMeshProUGUI pointsTMP;
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
            pointsTMP.text = "Press left click to grab and release the DOMO";
        }
        else {
            pointsTMP.text = "Points: " + domoSpwn.playerScore.ToString();
        }
    }
}
