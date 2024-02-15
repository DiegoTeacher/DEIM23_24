using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "(A) See", menuName = "ScriptableObjects/Actions/SeeAction")]
public class SeeAction : Action
{
    public string searchedTag;
    public override bool Check(GameObject owner)
    {
        List<string> tags = owner.GetComponentInChildren<VisionScript>().tags;

        return tags.Contains(searchedTag);
    }
}
