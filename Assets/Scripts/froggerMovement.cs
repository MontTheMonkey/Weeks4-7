using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class froggerMovement : MonoBehaviour
{
    [Range (-3, 10)]
    public float frogX;
    public float frogY;
    // Start is called before the first frame update
    void Start()
    {
        

    }

    // Update is called once per frame
    void Update()
    {
        //Frog axis determines which button (arrow keys, controller or WASD) is pressed
        //Vector2 frogAxis = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));

        
        //Frog position keeps track of the changes made to the player position
        Vector2 frogPos = transform.position;

        if (Input.GetKeyDown(KeyCode.D))
        {
            frogPos.x += 1;
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            frogPos.x -= 1;
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            frogPos.y += 1;
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            frogPos.y -= 1;
        }
        transform.position = frogPos;
    }
}
