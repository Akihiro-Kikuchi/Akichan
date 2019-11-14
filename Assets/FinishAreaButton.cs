using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishAreaButton : MonoBehaviour
{
    public GameObject Image1, Button1, Image2, Button2, Image3, Button3;
    CameraChanger Camerachanger;
    GameObject Changer;
    // Start is called before the first frame update
    void Start()
    {
        //Changer = GameObject.Find("MainCamera");
        //Camerachanger = Changer.GetComponent<CameraChanger>();
        Image1.SetActive(false);
        Button1.SetActive(false);
        Image3.SetActive(false);
        Button3.SetActive(false);
       
        //Text1.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnClick()
    {
        Image1.SetActive(true);
        Button1.SetActive(true);
        //Text1.SetActive(true);
    }

    public void Onclick2()
    {
        Image1.SetActive(false);
        Button1.SetActive(false);
        //Text1.SetActive(false);
    }

    public void OnClick3()
    {
        Image2.SetActive(false);
        Button2.SetActive(false);
    }

    public void OnClick4()
    {
        Image3.SetActive(true);
        Button3.SetActive(true);
    }

    public void Onclick5()
    {
        Image3.SetActive(false);
        Button3.SetActive(false);
    }


}
