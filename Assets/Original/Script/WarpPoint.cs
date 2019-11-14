using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WarpPoint : MonoBehaviour
{
    public GameObject In, Out, Text1, Text2, Text3;
    //public GameObject OtherCamera, ResultCamera, Trajectory;
    GameManager Gamemanager;
    public GameObject Gamemana;

    // Start is called before the first frame update
    void Start()
    {
        Gamemana = GameObject.Find("GameManager");
        Gamemanager = Gamemana.GetComponent<GameManager>();

        Text1.SetActive(false);
        Text2.SetActive(false);
        Text3.SetActive(false);
        //Trajectory.SetActive(false);
        //ResultCamera.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionStay(Collision col)
    {
        if (col.gameObject.tag == "hinanIn")
        {
            Text1.SetActive(true);
            if (Input.GetKey(KeyCode.U))
            {
                this.transform.position = Out.transform.position;
            }
        }
        else
        {
            Text1.SetActive(false);
        }
        if (col.gameObject.tag == "yama")
        {
            Text2.SetActive(true);
            if (Input.GetKey(KeyCode.D))
            {
                this.transform.position = In.transform.position;
            }
        }
        else
        {
            Text2.SetActive(false);
        }
        if(col.gameObject.tag == "Finish")
        {
            Text3.SetActive(true);
            if (Input.GetKey(KeyCode.Q))
            {
                //Quit();
                //OtherCamera.SetActive(false);
                //ResultCamera.SetActive(true);
                //Trajectory.SetActive(true);
                Gamemanager.SinarioFlag = 5;
                Debug.Log("避難が完了した。");
            }
        }
        else
        {
            Text3.SetActive(false);
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

