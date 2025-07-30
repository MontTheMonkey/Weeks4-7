using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UIElements;

public class froggerMovement : MonoBehaviour
{
    public TMP_Text deathMsg;
    public carMovement carEntity;
    public Vector2 playerPos;
    Vector2 playerSpawn = new Vector2(0, -4);
    float leapDistance = 0.5f;
    // Start is called before the first frame update
    void Start()
    {
        transform.position = playerSpawn;
        playerPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            playerPos.y += leapDistance;
            transform.position = playerPos;
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            playerPos.y -= leapDistance;
            transform.position = playerPos;
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            playerPos.x += leapDistance;
            transform.position = playerPos;
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            playerPos.x -= leapDistance;
            transform.position = playerPos;
        }
        if (carEntity.carSprRndr.bounds.Contains(playerPos) == true)
        {
            transform.position = playerSpawn;
            deathMsg.text = "You died";
        }
    }
}
