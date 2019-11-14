using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityChan;

public class NotificationButton : MonoBehaviour
{
    GameManager Gamemanager;
    GameObject Gamemana;
    Atari atari;                        //Atariの参照
    GameObject Atari;                   //Atariをobjectとして見つけるための物
    public GameObject NotificationImage, CloseButton, Player;
    public int NotificationHantei;
    // Start is called before the first frame update
    void Start()
    {
        Gamemana = GameObject.Find("GameManager");
        Gamemanager = Gamemana.GetComponent<GameManager>();
        Atari = GameObject.Find("Atari");
        atari = Atari.GetComponent<Atari>();
        NotificationImage.SetActive(false);
        CloseButton.SetActive(false);
        NotificationHantei = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if(Gamemanager.SinarioFlag == 1)
        {
            if (atari.AtariFlag == 1)
            {
                NotificationImage.SetActive(true);
                CloseButton.SetActive(true);
                Player.gameObject.GetComponent<UnityChanControlScriptWithRgidBody>().enabled = false;
                Debug.Log("動けないよ。");
                NotificationHantei = 1;
            }
            if (Input.GetKeyDown(KeyCode.Space))
            {
                //if(NotificationHantei == 0)
                //{
                //    OnClick2();
                //}
                //else if(NotificationHantei == 1)
                //{
                //    OnClick();
                //}
                OnClick();
            }
        }
    }

    public void OnClick()
    {
        //if(Gamemanager.SinarioFlag == 1)
        //{
            NotificationImage.SetActive(true);
            CloseButton.SetActive(true);
            Player.gameObject.GetComponent<UnityChanControlScriptWithRgidBody>().enabled = false;
            Debug.Log("動けないよ。NotificationHantei : " + NotificationHantei);
            //NotificationHantei = 0;
        //}
    }

    public void OnClick2()
    {
        //if (Gamemanager.SinarioFlag == 1)
        //{
            if (atari.AtariFlag == 1)
            {
                atari.AtariFlag = 2;
            }
            NotificationImage.SetActive(false);
            CloseButton.SetActive(false);
            Player.gameObject.GetComponent<UnityChanControlScriptWithRgidBody>().enabled = true;
            Debug.Log("動けるよ。NotificationHantei : " + NotificationHantei);
            //NotificationHantei = 1;
        //}
    }
}
