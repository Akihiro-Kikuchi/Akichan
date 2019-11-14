using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TrainingRoom : MonoBehaviour
{
    GameObject Gamemana, StartCamera, OtherCamera;
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

    public void OnClick()
    {
        Gamemanager.SinarioFlag = 0;
        SceneManager.LoadScene("TrainingRoom");
    }

}
