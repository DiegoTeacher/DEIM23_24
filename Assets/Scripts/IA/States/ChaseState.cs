using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

[CreateAssetMenu(fileName = "(S) Chase", menuName = "ScriptableObjects/States/ChaseState")]
public class ChaseState : State
{
    private GameObject target;

    public override void Init(GameObject owner)
    {
        base.Init(owner);
        target = FindObjectOfType<PlayerMovement>().gameObject;
    }

    public override State Run(GameObject owner)
    {
        Vector3 targetPos = target.transform.position;

        navMeshAgent.SetDestination(targetPos);

        return base.Run(owner);
    }
}
