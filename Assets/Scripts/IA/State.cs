using UnityEngine;
using UnityEngine.AI;

[System.Serializable]
public struct ActionParameter
{
    public Action action;
    public bool actionValue;
}

[System.Serializable]
public struct StateParameter
{
    public ActionParameter[] actionParameters;
    [Tooltip("Only one action must be true or every action must be true")]
    public bool or;
    public State nextState;
}

public abstract class State : ScriptableObject
{
    public StateParameter[] parameters;
    protected NavMeshAgent navMeshAgent;

    public virtual void Init(GameObject owner)
    {
        navMeshAgent = owner.GetComponent<NavMeshAgent>();

        foreach (StateParameter parameter in parameters)
        {
            foreach (ActionParameter actionParameter in parameter.actionParameters)
            {
                actionParameter.action.Init(owner);
            }
        }
    }

    public virtual State Run(GameObject owner)
    {
        foreach(StateParameter actualParameter in parameters)
        {
            bool andResult = true;
            foreach(ActionParameter actualActionParameter in actualParameter.actionParameters)
            {
                bool currentActionCheck = actualActionParameter.action.Check(owner) == actualActionParameter.actionValue;
                andResult &= currentActionCheck; // andResult = andResult && currentActionCheck;

                if (actualParameter.or && currentActionCheck)
                {
                    return actualParameter.nextState;
                }
            }

            if(andResult) // &&
            {
                return actualParameter.nextState;
            }
        }

        return null;
    }

    public virtual void DrawAllGizmos(GameObject owner)
    {
        Gizmos.color = Color.yellow;
        foreach (StateParameter parameter in parameters)
        {
            foreach (ActionParameter actionParameter in parameter.actionParameters)
            {
                actionParameter.action.DrawGizmo(owner);
            }
        }
    }
}
