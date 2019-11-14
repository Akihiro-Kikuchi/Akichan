using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrajectoryRenderer : MonoBehaviour
{

    public Material[] _material;           // 割り当てるマテリアル.
    private int i;
    GameManager Gamemanager;
    GameObject Gamemana;
    public GameObject Trajectory1, Trajectory2;

    // Use this for initialization
    void Start()
    {
        Gamemana = GameObject.Find("GameManager");
        Gamemanager = Gamemana.GetComponent<GameManager>();
        i = 0;
        Trajectory1.GetComponent<Renderer>().material = _material[i];
        Trajectory2.GetComponent<Renderer>().material = _material[i];
        Trajectory2.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        //if (Input.GetKeyUp(KeyCode.Space))
        //{
        //    i++;
        //    if (i == 3)
        //    {
        //        i = 0;
        //    }

        //    this.GetComponent<Renderer>().material = _material[i];
        //}
        if(Gamemanager.SinarioFlag == 3)
        {
            Trajectory1.SetActive(false);
            Trajectory2.SetActive(true);
        }
        if(Gamemanager.SinarioFlag == 5)
        {
            Trajectory1.SetActive(true);
            Trajectory1.GetComponent<Renderer>().material = _material[2];
            Trajectory2.GetComponent<Renderer>().material = _material[1];
        }

    }
}
