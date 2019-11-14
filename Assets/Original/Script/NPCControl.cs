using UnityEngine;
using System.Collections;
using UnityEngine.AI;

public class NPCControl:MonoBehaviour{

    public GameManager Gamemanager;
    public GameObject TargetObject;
    public GameObject TargetObject2, TargetObject3; ///目標位置
    NavMeshAgent m_navMeshAgent; /// NavMeshAgent
    private Animator anim;
    private Rigidbody rb;
    private AnimatorStateInfo currentBaseState;
    // Use this for initialization 
    void Start() {
        // NavMeshAgent コンポーネントを取得 
        m_navMeshAgent =GetComponent<NavMeshAgent>();
        //// Animatorコンポーネントを取得する
        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody>();
        

    }

    // Update is called once per frame 
    void Update()
    {
        int SFlag = Gamemanager.SinarioFlag;
        //if(SFlag == 0)
        //{
        //    // NavMesh が準備できているなら 
        //    if (m_navMeshAgent.pathStatus != NavMeshPathStatus.PathInvalid)
        //    {
        //        // NavMeshAgent に目的地をセット 
        //        m_navMeshAgent.SetDestination(TargetObject2.transform.position);
        //    }
        //    if (!m_navMeshAgent.pathPending && m_navMeshAgent.remainingDistance < 0.5f)
        //    {
        //        // NavMeshAgent に目的地をセット 
        //        m_navMeshAgent.SetDestination(TargetObject3.transform.position);
        //    }
        //}

        if (SFlag == 1)
        {
            // NavMesh が準備できているなら 
            if (m_navMeshAgent.pathStatus != NavMeshPathStatus.PathInvalid)
            {
                // NavMeshAgent に目的地をセット 
                m_navMeshAgent.SetDestination(TargetObject.transform.position);
            }
            if (!m_navMeshAgent.pathPending && m_navMeshAgent.remainingDistance < 0.5f)
            {

            }

        }   
    }
}

