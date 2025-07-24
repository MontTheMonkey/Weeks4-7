using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class heroScript : MonoBehaviour
{
    public Slider healthBar;
    public float maxHealth = 100;
    public float currentHealth;
    public float dmgValue = 5;
    public AudioSource heroAudio;
    public AudioClip hitSfx;
    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
        healthBar.value = currentHealth / maxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        healthBar.value = currentHealth / maxHealth;
        if (Input.GetKeyDown(KeyCode.Space) && currentHealth > 0)
        {
            currentHealth = currentHealth - dmgValue;
            heroAudio.PlayOneShot(hitSfx);
            Debug.Log("Current health is " + currentHealth.ToString());
        }
        if (currentHealth <= 0)
        {
            Debug.Log("Hero is dead");
        }
    }
}
