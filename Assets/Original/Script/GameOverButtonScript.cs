using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverButtonScript : MonoBehaviour
{
    GameObject Gamemana;
    GameManager Gamemanager;

    // Start is called before the first frame update
    void Start()
    {
        Gamemana = GameObject.Find("GameManager");
        Gamemanager = Gamemana.GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // ボタンが押された場合、今回呼び出される関数
    public void OnClick()
    {
        Gamemanager.SinarioFlag = 5;
        Debug.Log("押された! SinarioFlag : " + Gamemanager.SinarioFlag);  // ログを出力
    }
}
