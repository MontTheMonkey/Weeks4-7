using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public Slider tSlider;
    public float ti;

    // Start is called before the first frame update
    void Start()
    {
        tSlider = GetComponent<Slider>();
        tSlider.value = tSlider.maxValue;
    }

    // Update is called once per frame
    void Update()
    {
        ti -= Time.deltaTime;
        tSlider.value = ti; //% tSlider.maxValue;
    }
}
