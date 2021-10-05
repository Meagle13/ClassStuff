using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class DemoAI : MonoBehaviour
{
    //AI
    NavMeshAgent agent = null;
    GameObject TargetPoint = null;

    //Raycast
    public float dist = 10;
    public LayerMask mask = 0;
    private GameObject hitTarget = null;

    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        TargetPoint = new GameObject("TargetPoint");
        hitTarget = TargetPoint;
    }

    // Update is called once per frame
    void Update()
    {
        //Vector3 direction = new Vector3(Mathf.Sin(Time.time), 0, 1);
        //agent.Move(transform.forward * Time.deltaTime); 

        
        RaycastHit hit;
        Debug.DrawRay(transform.position, transform.forward * dist, Color.magenta);
        if(Physics.Raycast(transform.position,transform.forward, out hit, dist,  mask))
        {
            hitTarget = hit.transform.gameObject;
        }
        agent.SetDestination(hitTarget.transform.position);

    }

}
