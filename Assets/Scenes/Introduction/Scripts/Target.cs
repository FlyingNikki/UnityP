using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using Unity.VisualScripting;
using UnityEngine;

public class Target : MonoBehaviour
{
    Wizard w;


    public GameObject target;
    // Start is called before the first frame update
    void Start()
    {

       

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnCollisionEnter2D(Collision2D collision2D)
    {
        string tag = collision2D.gameObject.tag;

        if (tag == "Fireball")
        {
            var position = new Vector3(Random.Range(-9f, 9f), Random.Range(-5f, 5f), 0);

         
            Instantiate(target, position, Quaternion.identity);
            Hud.score = Hud.score + 1;
            w = Wizard.player;
            w.stats.GainEXP(50);
            Destroy(gameObject);
        }
       


        
    }
}

   
