using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraChanger : MonoBehaviour
{
    public GameObject Agent, Wave;
    public GameObject MainCamera, SubCamera;
    public int ChangerCount = 0;
    // Start is called before the first frame update
    void Start()
    {
        SubCamera.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Wave.transform.position.y - Agent.transform.position.y >= 0.6 && Wave.transform.position.z - Agent.transform.position.z < 250)
        {
            Debug.Log("あと2秒でGameOverです。");
            Invoke("CameraChange", 2);
        }
    }

    void CameraChange()
    {
        Debug.Log("CameraChangeが実行されました。");
        MainCamera.SetActive(false);
        SubCamera.SetActive(true);
        ChangerCount = 1;
    }
}
