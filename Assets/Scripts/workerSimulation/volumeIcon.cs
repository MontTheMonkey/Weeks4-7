using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class volumeIcon : MonoBehaviour
{
    //Adobe Stock #1365533528
    public SpriteRenderer volSpriteRndr;
    public Sprite fullVol;
    public Sprite halfVol;
    public Sprite lowVol;
    public Sprite muteVol;
    public Slider volSlider;
    float volValue;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Volume range is 0-1
        volValue = volSlider.value;
        if (volValue >= 0.75)
        {
            volSpriteRndr.sprite = fullVol;
        }
        if (volValue >= 0.5 && volValue < 0.75)
        {
            volSpriteRndr.sprite = halfVol;
        }
        if (volValue >= 0.01 && volValue < 0.5)
        {
            volSpriteRndr.sprite = lowVol;
        }
        if (volValue == 0)
        {
            volSpriteRndr.sprite = muteVol;
        }
    }
}
