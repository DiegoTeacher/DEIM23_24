using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audio3DOnLoop : MonoBehaviour
{
    public AudioClip clip;
    // Start is called before the first frame update
    void Start()
    {
        AudioManager.instance.PlayAudioOnLoop3D(clip, transform.position);
    }
}
