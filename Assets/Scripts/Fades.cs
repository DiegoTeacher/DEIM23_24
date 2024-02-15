using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fades : MonoBehaviour
{
    private MeshRenderer m_Renderer;
    // Start is called before the first frame update
    void Start()
    {
        m_Renderer = GetComponent<MeshRenderer>();
        StartCoroutine("FadeOut");
    }

    IEnumerator FadeIn()
    {
        Color matColor = m_Renderer.materials[0].color;
        for (float alpha = 0f; alpha < 1f;  alpha += 0.1f)
        {
            m_Renderer.materials[0].color = 
                new Color(matColor.r, matColor.g, matColor.b, alpha);
            yield return new WaitForSeconds(0.05f);
        }
        StartCoroutine("FadeOut");
    }

    IEnumerator FadeOut()
    {
        Color matColor = m_Renderer.materials[0].color;
        for (float alpha = 1f; alpha > 0f; alpha -= 0.1f)
        {
            m_Renderer.materials[0].color =
                new Color(matColor.r, matColor.g, matColor.b, alpha);
            yield return new WaitForSeconds(0.05f);
        }
        StartCoroutine("FadeIn");
    }
}
