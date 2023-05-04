using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    public MeshRenderer Renderer;
    public float colorSpeed = 1.0f;
    void Start()
    {
        transform.position = new Vector3(1, 4, 1);
        transform.localScale = Vector3.one * 1.5f;
        
        
    }
    
    void Update()
    {
        transform.Rotate(15.0f * Time.deltaTime, 0.0f, 0.0f);

        if (Input.GetMouseButtonDown(0)) {
            StartCoroutine(ColorChange());
        };
        if (Input.GetMouseButtonDown(1))
        {
            Material material = Renderer.material;
            material.color = new Color(0.1f, 0.1f, 0.1f);
        }
    }

    IEnumerator ColorChange()
    {
        Material material = Renderer.material;
        float t = 0.0f;
        Color startColor = material.color;
        Color endColor = Color.Lerp(Color.blue, Color.green, 0.5f);

        while (t < 3.0f)
        {
            t += Time.deltaTime * colorSpeed;
            float colorValue = Mathf.Sin(t * Mathf.PI);
            material.color = Color.Lerp(startColor, endColor, colorValue);
            yield return null;
        }

        material.color = endColor;
    }
}
