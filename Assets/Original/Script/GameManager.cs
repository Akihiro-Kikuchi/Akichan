using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CameraShaker;
using UnityEngine.UI;
using UnityChan;

public class GameManager : MonoBehaviour
{
    ButtonScript Buttonscript;          //ButtonScriptの参照←使ってないけどね
    Atari atari;                        //Atariの参照
    GameObject Atari;                   //Atariをobjectとして見つけるための物
    HinanAreaCount HinanCount;          //HinanAreaCountの参照
    GameObject AreaCount;               //HinanAreaCountをobjectとして見つけるための物
    HighHinanAreaCount HighHinan;
    GameObject HighCount;
    CameraChanger Camerachanger;        //CameraChangerの参照
    GameObject Changer;                 //CameraChangerのobjectを見つけるための物←下で宣言したOtherCameraを使ってるので意味ない
    // ゲームステート
    public enum GameState               //ゲームステータスあると何かとべんりなきがして入れたけど使ってないね。
    {
        Opening,
        Playing,
        Clear,
        Over
    }

    public GameState currentState = GameState.Opening;
    public GameObject Efect, Wave, Siya, Player, HinanArea, Notification, FinishButton, FinishButton2, ResultText1, ResultText2;
    public GameObject StartCamera, OtherCamara, ResultCamera, GameOverCamera, Trajectory, Text, ControllText;
    public GameObject MapDisplay;
    public int SinarioFlag = 0;                         //ゲーム進行のシナリオ番号。初期値0
    public int MapDisplayFlag = 0;                      //ゲーム中のマップ表示0と1で反映。初期値0
    //public AudioClip audioClip1;
    public GameObject audioSource;
    public int ShakeCount = 0;                          //地震発生のカメラ振動を捕える補数。初期値0


    // Start is called before the first frame update
    void Start()
    {
        // オープニング
        GameOpening();
        SinarioFlag = 0;
        MapDisplayFlag = 0;
        ShakeCount = 0;
        Efect.SetActive(false);
        Siya.SetActive(false);
        StartCamera.SetActive(true);
        OtherCamara.SetActive(false);
        //Trajectory.SetActive(false);
        ResultCamera.SetActive(false);
        //NPC.SetActive(false);
        Wave.GetComponent<WaveController>().enabled = false;
        Player.gameObject.GetComponent<UnityChanControlScriptWithRgidBody>().enabled = false;
        //GetComponent<NPCControl>().enabled = false;
        ControllText.SetActive(false);
        audioSource.SetActive(false);
        MapDisplay.SetActive(false);
        HinanArea.SetActive(false);
        Notification.SetActive(false);
        Atari = GameObject.Find("Atari");
        atari = Atari.GetComponent<Atari>();
        AreaCount = GameObject.Find("hinanarea (2)");
        HinanCount = AreaCount.GetComponent<HinanAreaCount>();
        HighCount = GameObject.Find("hinanarea (1)");
        HighHinan = HighCount.GetComponent<HighHinanAreaCount>();
        //HighCount = GameObject.Find("hinanarea (1)");
        //HighhinanCount = HighCount.GetComponent<HinanareaCount>();
        //Changer = GameObject.Find("MainCamera");
        Camerachanger = OtherCamara.GetComponent<CameraChanger>();
        if (HinanCount.AreaCount == 0)
        {
            FinishButton.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(Time.time + ": Flag :" +SinarioFlag);
        Vector3 Ppos = Player.transform.position;
        if (SinarioFlag == 0)
        {
            StartCamera.SetActive(true);
            OtherCamara.SetActive(false);
            ControllText.SetActive(false);
            //Trajectory.GetComponent<Material>().color = new Color(1.0f, 1.0f, 1.0f, 0.0f);
        }
        if(SinarioFlag == 1)
        {
            //audioSource.Play();
            audioSource.SetActive(true);
            StartCamera.SetActive(false);
            OtherCamara.SetActive(true);
            ControllText.SetActive(true);
            Player.gameObject.GetComponent<UnityChanControlScriptWithRgidBody>().enabled = true;
            if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W))
            {
                Text.SetActive(false);
            }
            if(atari.AtariFlag == 1)
            {
                Notification.SetActive(true);
            }

        }
        else
        {
            Notification.SetActive(false);
        }
        if(SinarioFlag == 2)
        {

            Invoke("StopShake", 10);
        }

        if(SinarioFlag == 3)
        {
            if (Input.GetKeyUp(KeyCode.UpArrow))
            {
                if (ShakeCount <= 2)
                {
                    ShakeCount = 1;
                    Debug.Log("ShakeCount : " + ShakeCount);
                }
            }
            if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.RightArrow))
            {
                if (ShakeCount == 0)
                {
                    ShakeCount = 2;
                    Debug.Log("ShakeCount : " + ShakeCount);
                }
            }
            if (Input.GetKey(KeyCode.C))
            {
                ShakeCount = 3;
                Debug.Log("ShakeCount : " + ShakeCount);
            }
        }
        if(SinarioFlag == 4)
        {
            Debug.Log("シナリオ４です。");
        }

        if(SinarioFlag == 5)
        {
            Player.gameObject.GetComponent<UnityChanControlScriptWithRgidBody>().enabled = false;
            OtherCamara.SetActive(false);
            GameOverCamera.SetActive(false);
            ResultCamera.SetActive(true);
            audioSource.SetActive(false);
            if (HinanCount.AreaCount == 1)
            {
                FinishButton.SetActive(true);
            }
            if (HighHinan.HighHinanCount == 1)
            {
                FinishButton2.SetActive(true);
            }
            if (Camerachanger.ChangerCount == 0)
            {
                ResultText1.SetActive(false);
                ResultText2.SetActive(true);
            }
            else if (Camerachanger.ChangerCount == 1)
            {
                ResultText1.SetActive(true);
                ResultText2.SetActive(false);
            }

            //Wave.GetComponent<WaveController>().enabled = false;
            //Trajectory.GetComponent<Material>().color = new Color(1.0f, 1.0f, 1.0f, 1.0f);
            //Trajectory.SetActive(true);
        }
        if (SinarioFlag == 6)
        {
            Start();
        }
        if(SinarioFlag == 1 || SinarioFlag == 2 || SinarioFlag == 3 || SinarioFlag == 4)
        {
            if (MapDisplayFlag == 0)
            {
                if (Input.GetKeyDown(KeyCode.M))
                {
                    MapDisplay.SetActive(true);
                    MapDisplayFlag = 1;
                    Debug.Log("Mapを表示");
                    if (SinarioFlag == 3)
                    {
                        HinanArea.SetActive(true);
                    }
                }
            }
            else
            {
                if (Input.GetKeyDown(KeyCode.M))
                {
                    MapDisplay.SetActive(false);
                    MapDisplayFlag = 0;
                    Debug.Log("Mapを非表示");
                    if (SinarioFlag == 3)
                    {
                        HinanArea.SetActive(false);
                    }
                }
            }
        }
    }

    void GameOpening()
    {

    }

    void OnCollisionEnter(Collision col)
    {
        if (SinarioFlag <= 1)
        {
            if (col.gameObject.tag == "Agent")
            {
                EarthQuake();
                
            }
        }
    }

    void StopShake()
    {
        OtherCamara.GetComponent<CameraShake>().enabled = false;
        Debug.Log("振動は止まりました。 Flag:" + SinarioFlag);
        SinarioFlag = 4;
    }

    void EarthQuake()
    {
        SinarioFlag = 2;
        Debug.Log("地震が発生しました。Flag:" + SinarioFlag);
        Efect.SetActive(true);
        Siya.SetActive(true);
        //NPC.SetActive(true);
        Wave.GetComponent<WaveController>().enabled = true;
        //GetComponent<NPCControl>().enabled = true;
    }

}
