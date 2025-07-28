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
        mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.position = mousePos;
        timer += Time.deltaTime;
        Debug.Log(mousePos);
        // if (Input.GetKey(KeyCode.Mouse0) && cursorSprRnd.sprite == cursorNorm)
        // {
        //     cursorSprRnd.sprite = cursorHold;
        //     //Debug.Log("The cursor is " + mousePos);
        // }
        // else if (cursorSprRnd.sprite != domoSpr[0] || cursorSprRnd.sprite != domoSpr[1] || cursorSprRnd.sprite != domoSpr[domoSpr.Count])
        // {
        //     cursorSprRnd.sprite = cursorNorm;
        // }

        //Ninja box coords + sprite index
        if (mousePos.x > -7.7f && mousePos.x < -2.65f && mousePos.y < -1.2f && cursorSprRnd.sprite == domoSpr[0] && Input.GetKeyDown(KeyCode.Mouse0) == true)
        {
            domoSpwn.playerScore += 1;
            domoSpwn.rdNumber = UnityEngine.Random.Range(0, domoSpwn.domoObj.Count);
            cursorSprRnd.sprite = cursorNorm;
            domoSpwn.domoSpawned = true;
            if (timer <= 2f)
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
            if (timer <= 2f)
            {
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
            if (timer <= 2f)
            {
                domoSpwn.playerScore += 1;
            }
            timer = 0;
        }
    }
}
