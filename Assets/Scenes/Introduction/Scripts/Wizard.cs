using System.Collections;
using System.Collections.Generic;
using System.Threading;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class Wizard : MonoBehaviour
{
   
    float movementSpeed = 3.0f;
    public GameObject Fireball;
    public GameObject Target;
    float Casttimer = 2;
    public Vector3 lastMovement;

    // Start is called before the first frame update
    void Start()
    {
        Instantiate(Fireball,Vector3.zero,Quaternion.identity);
      
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 movement = Vector3.zero;

        if (Input.GetKey("w"))
        {
            movement += Vector3.up;
        }
        if (Input.GetKey("s"))
        {
            movement += Vector3.down;
        }
        if (Input.GetKey("a"))
        {
            movement += Vector3.left;
        }
        if (Input.GetKey("d"))
        {
            movement += Vector3.right;
        }

        float sprintSpeedFactor = 1.0f;
        if (Input.GetKey(KeyCode.LeftShift))
        {
            sprintSpeedFactor = 3.0f;
        }

        /*  if (movement.x<0 || movement.x<0) {
              lastMovement = movement;  
          }
        */

        //CastTimer
        Casttimer -= Time.deltaTime;
        if (Casttimer < 1)
        {
            /////Fireball

            if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.DownArrow))
            {


                GameObject obj = Instantiate(Fireball, transform.position, Quaternion.identity);
                // obj.GetComponent<Fireball>().direction = lastMovement * 4 * Time.deltaTime; // für änderung von komponenten             

                Casttimer = +2;
            }







        }

        transform.position += movement.normalized * Time.deltaTime * movementSpeed * sprintSpeedFactor;


        if (Target == false) {
            Instantiate(Target, Vector3.zero, Quaternion.identity);
        }
        
    }
}
