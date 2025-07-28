using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class cursorGrab : MonoBehaviour
{
    float timer;
    public Vector2 mousePos;
    public domoSpawner domoSpwn;
    public SpriteRenderer cursorSprRnd;
    //Cursors from Adobe Stock - #713164221 & #713226313
    public Sprite cursorNorm;
    public Sprite cursorHold;
    //All Domo sprites from the Roblox game, Find The Domos
    //https://find-the-domos.fandom.com/wiki/Find_The_Domos_Wiki
    public List<Sprite> domoSpr = new List<Sprite>(3);
    // Start is called before the first frame update
    void Start()
    {
        cursorSprRnd = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        //Sets the cursor sprite to the player's mouse position so it acts like a cursor in-game
        mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.position = mousePos;
        timer += Time.deltaTime;
        //Debug.Log(mousePos);

        //Ninja box coords + sprite index
        if (mousePos.x > -7.7f && mousePos.x < -2.65f && mousePos.y < -1.2f && cursorSprRnd.sprite == domoSpr[0] && Input.GetKeyDown(KeyCode.Mouse0) == true)
        {
            domoSpwn.playerScore += 1;
            domoSpwn.rdNumber = UnityEngine.Random.Range(0, domoSpwn.domoObj.Count);
            cursorSprRnd.sprite = cursorNorm;
            domoSpwn.domoSpawned = true;
            //To score double points, you need to drop off the DOMO in 0.75 secs
            if (timer <= 0.75f)
            {
                domoSpwn.playerScore += 1;
            }
            timer = 0;
        }
        //Sky box coords + sprite index
        if (mousePos.x > -2.65f && mousePos.x < 2.65f && mousePos.y < -1.2f && cursorSprRnd.sprite == domoSpr[1] && Input.GetKeyDown(KeyCode.Mouse0))
        {
            domoSpwn.playerScore += 1;
            domoSpwn.rdNumber = UnityEngine.Random.Range(0, domoSpwn.domoObj.Count);
            cursorSprRnd.sprite = cursorNorm;
            domoSpwn.domoSpawned = true;
            if (timer <= 0.75f)
            {
                //Debug.Log(timer);
                domoSpwn.playerScore += 1;
            }
            timer = 0;
        }
        //Red box coords + sprite index
        if (mousePos.x > 2.65f && mousePos.x < 7.7f && mousePos.y < -1.2f && cursorSprRnd.sprite == domoSpr[2] && Input.GetKeyDown(KeyCode.Mouse0))
        {
            domoSpwn.playerScore += 1;
            domoSpwn.rdNumber = UnityEngine.Random.Range(0, domoSpwn.domoObj.Count);
            cursorSprRnd.sprite = cursorNorm;
            domoSpwn.domoSpawned = true;
            if (timer <= 0.75f)
            {
                domoSpwn.playerScore += 1;
            }
            timer = 0;
        }
    }
}
