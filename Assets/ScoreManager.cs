using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEditor;
using UnityChan;

public class ScoreManager : MonoBehaviour
{
    HinanAreaCount HinanCount;
    GameManager Gamemanager;
    GameObject AreaCount, Gamemana, HighCount;
    HighHinanAreaCount HighHinan;
    public GameObject score_object = null; // Textオブジェクト
    public string H_Score_Word = "", K_Score_Word = "", S_Score_Word = "";
    public int H_Score_Num, K_Score_Num, S_Score_Num, T_Score_Num;
    //public Image flower1, flower2, flower3, flower4, flower5;
    //Texture2D t = AssetDatabase.LoadAssetAtPath<Texture2D>("Assets/Original/Material&Image");
    // 初期化
    void Start()
    {
        HighCount = GameObject.Find("hinanarea (1)");
        HighHinan = HighCount.GetComponent<HighHinanAreaCount>();
        AreaCount = GameObject.Find("hinanarea (2)");
        HinanCount = AreaCount.GetComponent<HinanAreaCount>();
        Gamemana = GameObject.Find("GameManager");
        Gamemanager = Gamemana.GetComponent<GameManager>();
        H_Score_Word = "×";
        K_Score_Word = "◎";
        S_Score_Word = "×";
        H_Score_Num = 0;
        K_Score_Num = 30;
        S_Score_Num = 0;
        T_Score_Num = 0;
    }

    // 更新
    void Update()
    {
        if(HinanCount.AreaCount == 1)
        {
            H_Score_Word = "〇";
            H_Score_Num = 30;
        }
        if (HighHinan.HighHinanCount == 1)
        {
            H_Score_Word = "◎";
            H_Score_Num = 40;
        }
        if(Gamemanager.ShakeCount == 1)
        {
            S_Score_Word = "×";
        }else if(Gamemanager.ShakeCount == 2)
        {
            S_Score_Word = "△";
            S_Score_Num = 10;
        }else if(Gamemanager.ShakeCount == 3)
        {
            S_Score_Word = "◎";
            S_Score_Num = 30;
        }
        T_Score_Num = H_Score_Num + S_Score_Num + K_Score_Num;
        //// オブジェクトからTextコンポーネントを取得
        Text score_text = score_object.GetComponent<Text>();
        //// テキストの表示を入れ替える
        score_text.text = "避難状況 : " + H_Score_Word +"\r\n" +
            "火災現場に近づいたか ： " + K_Score_Word + "\r\n" + 
            "地震中の移動 ： " + S_Score_Word + "\r\n" +
            "総合点数 ： " + T_Score_Num;
    }
}
