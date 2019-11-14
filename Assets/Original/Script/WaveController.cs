using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveController : MonoBehaviour
{
    public GameObject Wave;
    GameObject Gamemana, StartCamera, OtherCamera;
    GameManager Gamemanager;
    float High = 0.1f;
    private void Start()
    {
        Gamemana = GameObject.Find("GameManager");
        Gamemanager = Gamemana.GetComponent<GameManager>();
        if (Gamemanager.SinarioFlag == 2 || Gamemanager.SinarioFlag == 3) {
            //1秒後に呼び出され、1秒ごとに呼び出される
            InvokeRepeating("TsunamiZ", 3, 1);
            InvokeRepeating("TsunamiY", 5, 5);
        }
        else if(Gamemanager.SinarioFlag == 4)
        {
            CancelInvoke();
        }
    }

    //Invokeで使う
    void TsunamiZ()
    {
        this.transform.position += new Vector3(0, 0, -1);      
        //Debug.Log(Time.time + ":呼び出された" + " :TsunamiZ");
    }

    void TsunamiY()
    {
        
        this.transform.position += new Vector3(0, High, 0);
        if (Wave.transform.position.y >= 2)
        {
            High = 0;
        }
        //Debug.Log(Time.time + ":呼び出された" + " :TsunamiY: " + High);
    }
}