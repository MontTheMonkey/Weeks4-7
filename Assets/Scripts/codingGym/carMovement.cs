using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.UIElements;

public class carMovement : MonoBehaviour
{
    public GameObject carObj;
    public SpriteRenderer carSprRndr;
    public float carSpeed = 1.25f;
    float carOriginX = -10f;
    Vector3 carPos;
    float timer;
    // Start is called before the first frame update
    void Start()
    {
        carSprRndr = GetComponent<SpriteRenderer>();
        carPos.x = carOriginX;
        carPos.y = UnityEngine.Random.Range(-3, 3);
    }

    // Update is called once per frame
    void Update()
    {
        //This moves the wood along the conveyor belt
        carPos.x += carSpeed * Time.deltaTime;
        timer += Time.deltaTime;
        
        if (timer == 3)
        {
            Instantiate(carObj);
            timer = 0;
        }

        if (carPos.x > 10)
        {
            //Loops the car to where it came from
            carPos.x = carOriginX;
            carPos.y = UnityEngine.Random.Range(-3, 3);
        }
        transform.position = carPos;
    }
}
