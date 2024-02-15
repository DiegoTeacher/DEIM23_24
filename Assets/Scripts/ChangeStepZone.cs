using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeStepZone : MonoBehaviour
{
    public AudioClip grassclip;
    private void OnTriggerEnter(Collider other)
    {
        WalkingSound walkingSound = other.GetComponentInChildren<WalkingSound>();
        if(other)
        {
            walkingSound.clip = grassclip;
        }
    }
}
