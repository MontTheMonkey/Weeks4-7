using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class carMovement : MonoBehaviour
{
    public GameObject carObj;
    public float carSpeed = 1.25f;
    float carOriginX = -10f;
    Vector3 carPos;
    // Start is called before the first frame update
    void Start()
    {
        carPos.x = carOriginX;
        carPos.y = UnityEngine.Random.Range(-3, 3);
    }

    // Update is called once per frame
    void Update()
    {
        //This moves the wood along the conveyor belt
        carPos.x += carSpeed * Time.deltaTime;

        if (carPos.x > 10f)
        {
            //Loops the car to where it came from
            carPos.x = carOriginX;
            carPos.y = UnityEngine.Random.Range(-3, 3);
        }
        transform.position = carPos;
    }
}
