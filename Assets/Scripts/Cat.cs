using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cat : MonoBehaviour
{
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

        if (currentTime >= maxTime) {
            gameObject.SetActive(false);
            currentTime = 0;
        }
        int a = 3, b = 5;
        Swap(ref a, ref b);

        string c = "aaa", d = "fff";
        Swap(ref c, ref d);

    }

    void Swap<T>(ref T a, ref T b) // where T : MonoBehaviour
    {
        T temp = a;
        b = a;
        a = temp;
    }
}
