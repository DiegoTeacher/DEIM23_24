using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

[CreateAssetMenu(fileName = "(S) Guard", menuName = "ScriptableObjects/States/GuardState")]
public class GuardState : State
{
    public Vector3 guardPoint;

    public override void Init(GameObject owner)
    {
        base.Init(owner);
    }

    public override State Run(GameObject owner)
    {
        navMeshAgent.SetDestination(guardPoint);

        return base.Run(owner);
    }
}
