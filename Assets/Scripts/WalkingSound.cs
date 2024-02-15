using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WalkingSound : MonoBehaviour
{
    public AudioClip clip;
    public void Step()
    {
        AudioManager.instance.PlayAudio(clip);
    }
}
