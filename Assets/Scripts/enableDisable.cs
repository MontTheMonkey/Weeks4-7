using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enableDisable : MonoBehaviour
{
    // Start is called before the first frame update
    public SpriteRenderer sr;
    public GameObject canvas;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            sr.enabled = true;
            canvas.SetActive(true);
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            sr.enabled = false;
            canvas.SetActive(false);
        }
    }
}
