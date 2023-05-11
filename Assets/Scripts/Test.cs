using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    private int age;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(GenerateRandomAge());
    }

    // Update is called once per frame
    private int GenerateRandomAge()
    {
         age = Random.Range(1, 101);
        return age;
       
        
    }
}
