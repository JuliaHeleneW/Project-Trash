using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class TrashAI : MonoBehaviour
{
    public Transform endPoint;
    public NavMeshAgent navMeshAgent;

    // Start is called before the first frame update
    void Start()
    {
        //navMeshAgent = this.gameObject.GetComponent<NavMeshAgent>();
        //endPoint = GameObject.FindGameObjectWithTag("Endpoint").transform;
    }

    // Update is called once per frame
    void Update()
    {
        navMeshAgent.SetDestination(endPoint.position);
    }

    public void SetEndpoint(Transform e)
    {
        endPoint = e;
    }

    public void SetNavAgent(NavMeshAgent n)
    {
        navMeshAgent = n;
    }
}
