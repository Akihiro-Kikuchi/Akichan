using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrainText2 : MonoBehaviour
{
    //public GameObject Text2, Button2, Text3, Button3;
    TrainingRoomManager TrainManager;
    GameObject Trainmana;
    // Start is called before the first frame update
    void Start()
    {
        Trainmana = GameObject.Find("TrainingRoomManager");
        TrainManager = Trainmana.GetComponent<TrainingRoomManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("Spaceが押された。");
            SinarioToo();
        }
    }

    public void OnClick()
    {
        if(TrainManager.TrainingSinario == 1)
        {
            //TrainManager.TrainingSinario = 2;
            SinarioToo();
        }else if(TrainManager.TrainingSinario == 2)
        {
            SinarioToo();
        }else if(TrainManager.TrainingSinario == 4)
        {
            SinarioToo();
        }else if(TrainManager.TrainingSinario == 5)
        {
            SinarioToo();
        }
        
    }

    void SinarioToo()
    {
        
        if (TrainManager.TrainingSinario == 1)
        {
            
            TrainManager.TrainingSinario = 2;
        }else if (TrainManager.TrainingSinario == 2)
        {
            TrainManager.TrainingSinario = 3;
        }else if(TrainManager.TrainingSinario == 4)
        {
            TrainManager.TrainingSinario = 5;
        }else if(TrainManager.TrainingSinario == 5)
        {
            TrainManager.TrainingSinario = 6;
        }

    }
}
