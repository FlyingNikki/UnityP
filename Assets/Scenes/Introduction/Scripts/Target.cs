using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
    int YAchse=0;
    int XAchse;
    int ZAchse;
    // Start is called before the first frame update
    void Start()
    {
        YAchse = 
       transform.position = Vector3(YAchse,XAchse,ZAchse);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnCollisionEnter2D(Collision2D collision2D)
    { 
        Destroy(gameObject);
    }
}

   
