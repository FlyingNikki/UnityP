using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Fireball : MonoBehaviour
{
    //float timer = 0;
    int Rota = 0;
    public Vector3 direction;
    // Start is called before the first frame update
    void Start()
    {
        /* Test Angel
        float angle = Vector3.Angle(direction, Vector3.right);
        if (direction.y > 0)
        {
            transform.Rotate(new Vector3(0, 0, angle));
        }
        if(direction.y < 0) {
            transform.Rotate(new Vector3(0, 0, angle+180));
        }
      */
        
        //transform.rotate(Egal,egal,2d)

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            Rota = 180;
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            Rota = 0;
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            Rota = 90;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            Rota = 270;
        }
        switch (Rota){
            case 0: transform.Rotate(0, 0, 0); ; break;
            case 90: transform.Rotate(0, 0, 90); ; break;
            case 180: transform.Rotate(0, 0, 180); ; break;
            case 270: transform.Rotate(0, 0, 270); ; break;

        }
       
    }

    // Update is called once per frame
    void Update()
    {
         
        switch (Rota)
        {
            case 0:   transform.position = transform.position + new Vector3(4, 0, 0) * Time.deltaTime; ; break;
            case 90:  transform.position = transform.position + new Vector3(0, 4, 0) * Time.deltaTime; ; break;
            case 180: transform.position = transform.position + new Vector3(-4, 0, 0) * Time.deltaTime; ; break;
            case 270: transform.position = transform.position + new Vector3(0, -4, 0) * Time.deltaTime; ; break;

        }
        

         transform.position = transform.position +direction * Time.deltaTime;

        /*
             timer = timer + Time.deltaTime;
             if (timer > 3)
             {
                 Destroy(gameObject);
             }
             
        */

    }

    void OnCollisionEnter2D(Collision2D collision2D)
    {


        
        Destroy(gameObject);
    }



}
