using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeCubeColor : MonoBehaviour
{
    private MeshRenderer _rend;

    private void Start()
    {
        _rend = GetComponent<MeshRenderer>();    
    }

    // Update is called once per frame
    void Update()
    {
#if UNITY_STANDALONE_WIN || UNITY_EDITOR_WIN
        if(Input.GetKeyDown(KeyCode.Space))
        {
            _rend.material.color = Color.magenta;
            AdDisplayManager.instance.ShowAd();
        }
#elif UNITY_ANDROID
        foreach(Touch t in Input.touches)
        {
            if(t.phase == TouchPhase.Began)
            {
                _rend.material.color = Color.yellow;
                AdDisplayManager.instance.ShowAd();
            }
        }
#endif
    }
}
