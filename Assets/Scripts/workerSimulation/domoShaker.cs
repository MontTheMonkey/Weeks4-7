using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class domoShaker : MonoBehaviour
{
    Vector3 domoPos;
    int diRotation = 1;
    int domoSpeed = 8;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        domoPos.z += domoSpeed * diRotation * Time.deltaTime;
        transform.eulerAngles = domoPos;
        //Changes direction once it's rotated 10 degrees either direction
        if (domoPos.z <= -10f || domoPos.z >= 10f)
        {
            diRotation = diRotation * -1;
        }
    }
}
