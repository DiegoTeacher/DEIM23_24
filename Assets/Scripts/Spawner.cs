using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObjectPool pool;
    public float maxTime;

    private float currentTime;
    // Start is called before the first frame update
    void Start()
    {
        currentTime = 0;
    }

    // Update is called once per frame
    void Update()
    {
        currentTime += Time.deltaTime;
        if(currentTime >= maxTime)
        {
            GameObject go = pool.GetInactiveGameObject();
            go.SetActive(true);
            go.transform.position = transform.position;
            go.GetComponent<MeshRenderer>().
                material.color = 
                new Color(Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f));
            
            currentTime = 0;
        }
    }
}
