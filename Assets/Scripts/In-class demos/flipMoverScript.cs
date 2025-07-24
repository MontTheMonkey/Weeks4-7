using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;
using UnityEngine.UI;

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
        moveRight = false;
        objSpriteRnd = GetComponent<SpriteRenderer>();
        orgSprite = objSpriteRnd.sprite;
        clickStopAudioSource.clip = clickStopAudio;
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
        clickMoveAudioSource.Play();
        Debug.Log("Move was clicked");
    }
    public void OnClickStop()
    {
        moveRight = false;
        clickStopAudioSource.Play();
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
        //Would like to switch back
        objSpriteRnd.sprite = alterSprite;
    }
}
