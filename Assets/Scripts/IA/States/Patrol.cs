using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

[CreateAssetMenu(fileName = "(S) Patrol", menuName = "ScriptableObjects/States/PatrolState")]

public class Patrol : State
{
    public override void Init(GameObject owner)
    {
        owner.GetComponent<PatrolPoints>()._currentIndex = 0;
        base.Init(owner);
    }

    public override State Run(GameObject owner)
    {
        NavMeshAgent agentComponent = owner.GetComponent<NavMeshAgent>();
        PatrolPoints patrolPointsComponent = owner.GetComponent<PatrolPoints>();

        if(agentComponent.remainingDistance <= agentComponent.stoppingDistance)
        {
            patrolPointsComponent._currentIndex++;
            patrolPointsComponent._currentIndex %= patrolPointsComponent.patrolPoints.Length;
        }
        agentComponent.SetDestination(
            patrolPointsComponent.patrolPoints
            [patrolPointsComponent._currentIndex].transform.position);

        return base.Run(owner);
    }
}
