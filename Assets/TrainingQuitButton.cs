using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TrainingQuitButton : MonoBehaviour
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

    public void OnClick()
    {
        TrainManager.TrainingSinario = 0;
        SceneManager.LoadScene("Demo1024");
    }
}
