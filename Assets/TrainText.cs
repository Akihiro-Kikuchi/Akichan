using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrainText : MonoBehaviour
{
    TrainingRoomManager TrainManager;
    GameObject Trainmana;
    // Start is called before the first frame update
    void Start()
    {
        Trainmana = GameObject.Find("TrainingRoomManager");
        TrainManager = Trainmana.GetComponent<TrainingRoomManager>();
        //Text1.SetActive(true);
        //Button.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        if(TrainManager.TrainingSinario == 0)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                SinarioTo();
            }
        }            
        
    }

    public void OnClick()
    {
        TrainManager.TrainingSinario = 1;
    }

    void SinarioTo()
    {
        TrainManager.TrainingSinario = 1;
    }

}
