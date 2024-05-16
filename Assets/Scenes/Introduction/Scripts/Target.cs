using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using Unity.VisualScripting;
using Unity.VisualScripting.Antlr3.Runtime.Misc;
using UnityEditor.UIElements;
using UnityEngine;

public class Target : MonoBehaviour
{
    Wizard w;
    double Target_Exp = 100;
    double Exp_red =5;



    public GameObject target;
    // Start is called before the first frame update
    void Start()
    {
      

    }

    // Update is called once per frame
    void Update()
    {
        if (Target_Exp>10) {
            Target_Exp = Target_Exp - Time.deltaTime * Exp_red;
        }
        

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

           
           
            
            w.stats.GainEXP((int)Target_Exp);
            Destroy(gameObject);
        }
        if (tag == "Player")
        {
           
        }



    }
}

   
