using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityChan;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TrainingRoomManager : MonoBehaviour
{
    public int TrainingSinario = 0;
    public GameObject Player, Button, Button2, Button3, Button4, Button5, QuitButton, Text1, Text2, Text3, Text4, Text5, FirstArea;
    public Image Qtext;
    float a_Color;

    // Start is called before the first frame update
    void Start()
    {
        //Player.SetActive(false);
        a_Color = 0.3f;
        Player.GetComponent<UnityChanControlScriptWithRgidBody>().enabled = false;
        Qtext.color = new Color(255, 255, 255, a_Color);

    }

    // Update is called once per frame
    void Update()
    {
        if (TrainingSinario == 0)
        {
            Text1.SetActive(true);
            Button.SetActive(true);
            Text2.SetActive(false);
            Button2.SetActive(false);
            Text3.SetActive(false);
            Button3.SetActive(false);
            FirstArea.SetActive(false);
            Text4.SetActive(false);
            Button4.SetActive(false);
            Text5.SetActive(false);
            Button5.SetActive(false);
            QuitButton.SetActive(false);
        }
        if (TrainingSinario == 1)
        {
            Text1.SetActive(false);
            Button.SetActive(false);
            Text2.SetActive(true);
            Button2.SetActive(true);
            Qtext.color = new Color(255, 255, 255, 100);
        }
        if (TrainingSinario == 2)
        {
            Qtext.color = new Color(255, 255, 255, a_Color);
            Text2.SetActive(false);
            Button2.SetActive(false);
            FirstArea.SetActive(true);
            Text3.SetActive(true);
            Button3.SetActive(true);
        }
        if(TrainingSinario == 3)
        {
            Text3.SetActive(false);
            Button3.SetActive(false);
            Player.GetComponent<UnityChanControlScriptWithRgidBody>().enabled = true;
        }
        if(TrainingSinario == 4)
        {
            Player.GetComponent<UnityChanControlScriptWithRgidBody>().enabled = false;
            Text4.SetActive(true);
            Button4.SetActive(true);
        }
        if(TrainingSinario == 5)
        {
            Text4.SetActive(false);
            Button4.SetActive(false);
            Text5.SetActive(true);
            Button5.SetActive(true);
            QuitButton.SetActive(true);
        }
        if(TrainingSinario == 6)
        {
            Text5.SetActive(false);
            Button5.SetActive(false);
            Player.GetComponent<UnityChanControlScriptWithRgidBody>().enabled = true;
        }
    }

}
