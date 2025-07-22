using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;

public class flipMoverScript : MonoBehaviour
{
    public AudioSource clickStopAudioSource;
    public AudioSource clickMoveAudioSource;
    public AudioSource clickFlipAudioSource;
    public List<AudioClip> clickFlipAudios;
    public AudioClip clickStopAudio;
    int chosenFlipAudio;
    bool moveRight;
    Sprite orgSprite;
    public Sprite alterSprite;
    SpriteRenderer objSpriteRnd;
    int dirTravel = 1;
    // Start is called before the first frame update
    void Start()
    {
        moveRight = true;
        objSpriteRnd = GetComponent<SpriteRenderer>();
        orgSprite = objSpriteRnd.sprite;
    }

    // Update is called once per frame
    void Update()
    {
        if (moveRight == true)
        {
            transform.position += transform.right * dirTravel * Time.deltaTime;
        }
    }

    public void OnClickMove()
    {
        moveRight = true;
        Debug.Log("Move was clicked");
    }
    public void OnClickStop()
    {
        moveRight = false;
        Debug.Log("Stop was clicked");
    }
    public void OnClickFlip()
    {
        dirTravel = dirTravel * -1;
        int chosenFlipAudio = Random.Range(0, clickFlipAudios.Count);
        clickFlipAudioSource.PlayOneShot(clickFlipAudios[chosenFlipAudio]);
        Debug.Log("Flip was clicked");
    }
    public void OnClickSpriteAlt()
    {
        if (objSpriteRnd.sprite = alterSprite)
        {
            objSpriteRnd.sprite = orgSprite;
        }
        else
        {
            objSpriteRnd.sprite = alterSprite;
        }


    }
}
