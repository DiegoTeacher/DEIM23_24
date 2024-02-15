using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed;
    public float maxTime = 2;
    [HideInInspector]
    public Vector3 direction;

    private Rigidbody rb;
    private float currentTime;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = direction * speed;

        currentTime += Time.deltaTime;
        if (currentTime >= maxTime)
        {
            gameObject.SetActive(false);
            currentTime = 0;
        }
    }
}
