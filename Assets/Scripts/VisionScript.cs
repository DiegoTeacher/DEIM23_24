using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VisionScript : MonoBehaviour
{
    public List<string> tags;
    private void OnTriggerEnter(Collider other)
    {
        tags.Add(other.gameObject.tag);
    }

    private void OnTriggerExit(Collider other)
    {
        tags.Remove(other.gameObject.tag);
    }
}
