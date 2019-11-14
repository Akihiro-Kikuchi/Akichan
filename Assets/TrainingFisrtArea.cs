using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrainingFisrtArea : MonoBehaviour
{
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
        
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Agent")
        {
            TrainManager.TrainingSinario = 4;
            Destroy(gameObject);
        }
    }
}
