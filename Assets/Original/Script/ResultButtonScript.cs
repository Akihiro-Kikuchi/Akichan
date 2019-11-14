using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResultButtonScript : MonoBehaviour
{

    GameManager Gamemanager;
    GameObject Gamemana;
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

    public void OnClick()
    {        
        Debug.Log("Quit()ボタンが押された!");  // ログを出力
        Quit();
    }

    public void OnClick2()
    {
        if(Gamemanager.SinarioFlag == 5)
        {
            Gamemanager.SinarioFlag++;
        }
    }

    void Quit()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#elif UNITY_STANDALONE
    UnityEngine.Application.Quit();
#endif
    }
}
