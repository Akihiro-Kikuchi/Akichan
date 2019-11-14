using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraAngle : MonoBehaviour
{
    public GameObject MainCamera;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        //PlayerRotation();
        if (Input.GetKey(KeyCode.T))
        {
            transform.Rotate(50 * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey(KeyCode.G))
        {
            transform.Rotate(-50 * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey(KeyCode.H))
        {
            transform.Rotate(0, 0, -50 * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.F))
        {
            transform.Rotate(0, 0, 50 * Time.deltaTime);
        }
    }

    //void OnCollisionStay(Collision collision)
    //{
    //    if(collision.gameObject.tag == "UpLoad")
    //    {
    //        Debug.Log("上っている。");
    //        MainCamera.transform.Rotate(0, 0, 24);
    //    }
    //}

    //キャラクター回転
    void PlayerRotation()
    {


        //回転速度
        float RotX = 0f, RotY = 0f;

        /////キー入力確認 各キーが押されているか
        if (Input.GetKey(KeyCode.F))
        {
            RotY = -1f;
        }
        else if (Input.GetKey(KeyCode.H))
        {
            RotY = 1f;
        }
        if (Input.GetKey(KeyCode.T))
        {
            RotX = -1f;
        }
        else if (Input.GetKey(KeyCode.G))
        {
            RotX = 1f;
        }

        //タッチされている
        if (Input.touchCount > 0)
        {

            //タッチされている指の数だけループ
            foreach (Touch touch in Input.touches)
            {

                //画面の半分より上
                if (touch.position.y > Screen.height * 0.5f)
                {

                    //指が移動した分だけ画面を回転
                    RotX = -touch.deltaPosition.y;
                    RotY = touch.deltaPosition.x;

                }
            }
        }


        float RotSpeed = 10f;
        //回転予定角度X
        float NextRotX = transform.eulerAngles.x + RotX * RotSpeed * Time.deltaTime;
        float LimitRotX = 0f;

        //x方向の回転を制限  回転可能角度外
        if (NextRotX > LimitRotX && NextRotX < 360f - LimitRotX)
        {
            //下と上のどちらから可能角度を超えたか それに応じて制限
            NextRotX = NextRotX > 180f ? 360f - LimitRotX : LimitRotX;
        }


        //回転
        transform.rotation = Quaternion.Euler(
            NextRotX,
            transform.eulerAngles.y + RotY * RotSpeed * Time.deltaTime,
            transform.eulerAngles.z
            );

    }

    
}
