using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "(A) Random Number", menuName = "ScriptableObjects/Actions/RandomNumberAction")]
public class RandomNumberAction : Action
{
    public int number, minRange, maxRange;

    public override bool Check(GameObject owner)
    {
        return Random.Range(minRange, maxRange) == number;
    }
}
