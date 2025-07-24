using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerChar : MonoBehaviour
{
    public Vector3 playerPos = new Vector3();
    public float cSpeed = 3;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            playerPos.y += cSpeed * Time.deltaTime;
            transform.position = playerPos;
        }
        if (Input.GetKey(KeyCode.S))
        {
            playerPos.y -= cSpeed * Time.deltaTime;
            transform.position = playerPos;
        }
        if (Input.GetKey(KeyCode.D))
        {
            playerPos.x += cSpeed * Time.deltaTime;
            transform.position = playerPos;
        }
        if (Input.GetKey(KeyCode.A))
        {
            playerPos.x -= cSpeed * Time.deltaTime;
            transform.position = playerPos;
        }
    }
}