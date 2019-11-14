using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HinanAreaCount : MonoBehaviour
{
    public int AreaCount;
    // Start is called before the first frame update
    void Start()
    {
        AreaCount = 0;
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
                AreaCount = 1;
                Debug.Log("AreaCount : " + AreaCount);
            }

        }
    }
}
