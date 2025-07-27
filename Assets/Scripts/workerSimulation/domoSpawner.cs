using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class domoSpawner : MonoBehaviour
{
    //All Domo sprites from the Roblox game, Find The Domos
    //https://find-the-domos.fandom.com/wiki/Find_The_Domos_Wiki
    List<Sprite> domoSpr = new List<Sprite>(3);
    public int playerScore;
    // Start is called before the first frame update
    void Start()
    {
        domoSpr[0] = GetComponent<Sprite>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
