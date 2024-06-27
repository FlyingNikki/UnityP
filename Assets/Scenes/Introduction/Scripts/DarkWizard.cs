using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;
using static UnityEngine.GraphicsBuffer;

public class DarkWizard : MonoBehaviour
{


    public GameObject DarkWizardPre;

    Vector3 lastMovement = Vector3.zero;
   



   

    public static bool PauseA = false;

    // Start is called before the first frame update
    void Start()
    {
        



        

    }

    // Update is called once per frame
    void Update()
    {


        if (PauseA)
        {
            return;

        }
        //
        // Movement 
        //


        Vector3 richtung = (Wizard.player.getPositionWizard() - transform.position).normalized;

        // Bewegung in Richtung des Spielers mit konstanter Geschwindigkeit
        float geschwindigkeit = 2f; // Geschwindigkeit des Gegners
        transform.position = (Vector3)transform.position + richtung * geschwindigkeit * Time.deltaTime;


        if (transform.position== Wizard.player.getPositionWizard()) { 
        
            
        }

        

       

        //
        // Animation
        // 
        /*
        if (movement.magnitude > 0)
        {
            animator.SetBool("Walking", true);
        }
        else
        {
            animator.SetBool("Walking", false);
        }
        */

        // Flip Character

        
        if (richtung.x < 0)
        {
            GetComponent<SpriteRenderer>().flipX = true;
        }
        if (richtung.x > 0)
        {
            GetComponent<SpriteRenderer>().flipX = false;
        }
        






      


        



    }


    void OnCollisionEnter2D(Collision2D collision2D)
    {
        string tag = collision2D.gameObject.tag;

        if (tag=="Player") {

            Destroy(Wizard.player);
            GameManager.GMstate = "Destroyed";
            Destroy(gameObject);
        }
        if (tag == "Fireball") {
            var position = new Vector3(Random.Range(-25f, 25f), Random.Range(-25f, 25f), 0);

            GameManager.Instance.Score = GameManager.Instance.Score + 2;
            Instantiate(DarkWizardPre, position, Quaternion.identity);
          
            Destroy(gameObject);
            
        }
        






    }
}

