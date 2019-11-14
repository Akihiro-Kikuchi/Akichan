using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SIya : MonoBehaviour
{
    public GameObject Agent, Wave, maincamera;
    float a_Color;
    float b_Color;
    public Image Qtext;
    // Start is called before the first frame update
    void Start()
    {
        a_Color = 0;
        Qtext = GetComponent<Image>();
        InvokeRepeating("Touka", 1, 1);
    }

    // Update is called once per frame
    void Update()
    {
        if (Wave.transform.position.y - Agent.transform.position.y >= 0.1 && Wave.transform.position.z - Agent.transform.position.z < 250)
        {
            a_Color = (Wave.transform.position.y - Agent.transform.position.y) / 2;
        }
        else
        {
            a_Color = 0;
        }
        if(a_Color > 50)
        {
            a_Color = 50;
        }
        
        if(a_Color > 0.5)
        {
            a_Color = 0.5f;
        }

        
        //if (Wave.transform.position.y - Agent.transform.position.y > 150)
        //{
        //    Application.Quit();
        //}
        Qtext.color = new Color(255, 0, 0, a_Color);
    }

    void Touka()
    {
        //b_Color = (Wave.transform.position.y - Agent.transform.position.y);
        Debug.Log("透過率：" + a_Color);
    }


}
