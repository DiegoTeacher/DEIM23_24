using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DashScript : MonoBehaviour
{
    public enum Hola { kk, adios, aaa};
    public Hola tipo;

    [HideInInspector]
    public GameObject acc;
    // Start is called before the first frame update
    void Start()
    {
        print(acc);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
