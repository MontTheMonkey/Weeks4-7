using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cursorGrab : MonoBehaviour
{
    Vector2 mousePos;
    domoSpawner domoSpwn;
    SpriteRenderer cursorSprRnd;
    //Cursors from Adobe Stock - #713164221 & #713226313
    public Sprite cursorNorm;
    public Sprite cursorHold;
    //All Domo sprites from the Roblox game, Find The Domos
    //https://find-the-domos.fandom.com/wiki/Find_The_Domos_Wiki
    public Sprite ninjaHeld;
    public Sprite redHeld;
    public Sprite skyHeld;
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
        Debug.Log("The cursor is " + mousePos);
        //if (domoSpwn.rdNumber = 0 && mousePos.x >=)
        if (Input.GetKey(KeyCode.Mouse0))
        {
            cursorSprRnd.sprite = cursorHold;
        }
        else
        {
            cursorSprRnd.sprite = cursorNorm;
        }
    }
}
