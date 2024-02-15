using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour
{
    public GameObject target;
    private NavMeshAgent agentComponent;


    // Start is called before the first frame update
    void Start()
    {
        agentComponent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        agentComponent.destination = target.transform.position;   
    }
}
