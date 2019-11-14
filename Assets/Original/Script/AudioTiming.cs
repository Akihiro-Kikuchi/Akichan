using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioTiming : MonoBehaviour
{
    public GameManager Gamemanager;
    GameObject Gamemana;
    public GameObject WaveSound;
    public AudioClip audioClip1;
    //public AudioClip audioClip2;
    //public AudioClip audioClip3;
    private AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        Gamemana = GameObject.Find("GameManager");
        Gamemanager = Gamemana.GetComponent<GameManager>();
        audioSource = gameObject.GetComponent<AudioSource>();
        audioClip1 = audioSource.clip;
    }

    // Update is called once per frame
    void Update()
    {
        if (Gamemanager.SinarioFlag == 2)
        {
            Invoke("AudioComing", 5);
            Gamemanager.SinarioFlag++;
        }
        
    }



    void AudioComing()
    {
        //audioSource.Play();
        audioSource.PlayOneShot(audioClip1);
        Debug.Log("音が流れました。");
    }

}
