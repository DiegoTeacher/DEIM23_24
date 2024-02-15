using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public abstract class Action : ScriptableObject
{
    public abstract bool Check(GameObject owner);
    public virtual void DrawGizmo(GameObject owner)
    {

    }

    public virtual void Init(GameObject owner)
    {

    }
}
