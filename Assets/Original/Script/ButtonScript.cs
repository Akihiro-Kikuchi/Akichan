using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonScript : MonoBehaviour
{
    GameObject Gamemana, StartCamera, OtherCamera;
    GameManager Gamemanager;

    public void Start()
    {
        Gamemana = GameObject.Find("GameManager");
        Gamemanager = Gamemana.GetComponent<GameManager>();
    }

    // ボタンが押された場合、今回呼び出される関数
    public void OnClick()
    {
        if (Gamemanager.SinarioFlag == 0)
        {
            Gamemanager.SinarioFlag++;
            Debug.Log("押された! SinarioFlag : " + Gamemanager.SinarioFlag);  // ログを出力
        }
    }
}