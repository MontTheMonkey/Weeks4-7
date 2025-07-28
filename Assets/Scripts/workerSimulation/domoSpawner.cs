using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class domoSpawner : MonoBehaviour
{
    //All Domo sprites from the Roblox game, Find The Domos
    //https://find-the-domos.fandom.com/wiki/Find_The_Domos_Wiki
    public List<GameObject> domoObj = new List<GameObject>(3);
    public GameObject ingameDomo;
    public int playerScore;
    public int rdNumber;
    public bool domoSpawned;
    public cursorGrab curGrab;
    // Start is called before the first frame update
    void Start()
    {
        rdNumber = UnityEngine.Random.Range(0, domoObj.Count);
        domoSpawned = true;
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(ingameDomo);
        if (domoSpawned == true)
        {
            ingameDomo = Instantiate(domoObj[rdNumber], GetComponent<Transform>());
            domoSpawned = false;
        }
        //DOMO spawn area
        if (curGrab.mousePos.x >= -1.6f && curGrab.mousePos.x <= 1.8f && curGrab.mousePos.y >= 0.9f && Input.GetKeyDown(KeyCode.Mouse0) == true)
        {
            Destroy(ingameDomo);
            curGrab.cursorSprRnd.sprite = curGrab.domoSpr[rdNumber];
            Debug.Log("grab function peocesddrfdjcxgjdc");
        }
        if (Input.GetKeyDown(KeyCode.Space) == true)
        {
            Destroy(ingameDomo);
            Debug.Log("destroy!");
        }
    }
}
