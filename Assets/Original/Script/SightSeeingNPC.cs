using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public class SightSeeingNPC : MonoBehaviour
{
    GameManager Gamemanager;
    GameObject Gamemana;
    public GameObject TargetObject1, TargetObject2 ,NPCObject;
    NavMeshAgent NPCAgent;
    private Animator anime;
    private Rigidbody rigid;
    private AnimatorStateInfo CurrentBaseState;
    // Start is called before the first frame update
    void Start()
    {
        //GameManager コンポーネントを取得
        Gamemana = GameObject.Find("GameManager");
        Gamemanager = Gamemana.GetComponent<GameManager>();
        // NavMeshAgent コンポーネントを取得 
        NPCAgent = GetComponent<NavMeshAgent>();
        //// Animatorコンポーネントを取得する
        anime = GetComponent<Animator>();
        rigid = GetComponent<Rigidbody>();
        anime.SetBool("Wait", true);
        anime.SetBool("Run", false);
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 Apos = NPCObject.transform.position;
        Vector3 Bpos = TargetObject1.transform.position;
        Vector3 Cpos = TargetObject2.transform.position;
        float dis1 = Vector3.Distance(Apos, Bpos);
        float dis2 = Vector3.Distance(Apos, Cpos);
        if (Gamemanager.SinarioFlag == 3)
        {
            anime.SetBool("Wait", false);
            anime.SetBool("Run", true);

            // NavMesh が準備できているなら 
            if (NPCAgent.pathStatus != NavMeshPathStatus.PathInvalid)
            {
                // NavMeshAgent に目的地をセット 
                NPCAgent.SetDestination(Bpos);

                //Debug.Log("Distance2 : " + dis2);

                if (dis1 < 1.0)
                {
                    anime.SetBool("Wait", true);
                    anime.SetBool("Run", false);
                }
            }
        }
        if (Gamemanager.SinarioFlag == 4)
        {
            anime.SetBool("Wait", false);
            anime.SetBool("Run", true);
            NPCAgent.SetDestination(Cpos);
        }
    }
}
