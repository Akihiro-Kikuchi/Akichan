using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MapDisplay : MonoBehaviour
{
    GameObject Gamemana, StartCamera, OtherCamera;
    GameManager Gamemanager;
    public GameObject Map;
    int MapDisplayFlag;
    // Start is called before the first frame update
    void Start()
    {
        Gamemana = GameObject.Find("GameManager");
        Gamemanager = Gamemana.GetComponent<GameManager>();
        Map.SetActive(false);
        MapDisplayFlag = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (Gamemanager.SinarioFlag == 1)
        {
            if (MapDisplayFlag == 0)
            {
                if (Input.GetKeyDown(KeyCode.M))
                {
                    Map.SetActive(true);
                    MapDisplayFlag = 1;
                    Debug.Log("Mapを表示");
                }
            }
            else
            {
                if (Input.GetKeyDown(KeyCode.M))
                {
                    Map.SetActive(false);
                    MapDisplayFlag = 0;
                    Debug.Log("Mapを非表示");
                }
            }
        }
    }
}
