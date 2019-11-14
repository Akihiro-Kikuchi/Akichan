using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HighHinanAreaCount : MonoBehaviour
{
    public int HighHinanCount;
    // Start is called before the first frame update
    void Start()
    {
        HighHinanCount = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.tag == "Agent")
        {
            if (Input.GetKeyDown(KeyCode.Q))
            {
                HighHinanCount = 1;
                Debug.Log("AreaCount : " + HighHinanCount);
            }

        }
    }
}
