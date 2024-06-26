using System;
using System.Collections;
using System.Collections.Generic;
using System.Resources;
using Unity.VisualScripting.Antlr3.Runtime.Misc;
using UnityEditor.PackageManager.Requests;
using UnityEngine;

public class Wizard : MonoBehaviour
{
    public static Wizard player;

    public GameObject fireballPrefab;
    float castTimer = 0f;
  
    Vector3 lastMovement = Vector3.zero;
    private Animator animator;

    public static PlayerStats stats;

    
    
    public float hp;
    public float mana;

    public static bool PauseA=false;

    // Start is called before the first frame update
    void Start()
    {
        if (stats == null)
        {
            stats = new PlayerStats();
           
        }
       
             
        
        mana = stats.maxMana;
        hp= stats.maxHP;
        
        player = this;
        animator = GetComponent<Animator>();
        
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

        if (movement.x > 0 || movement.y > 0 || movement.x < 0 || movement.y < 0)
        {
            lastMovement = movement;
        }

        float sprintSpeedFactor = 1.0f;
        if (Input.GetKey(KeyCode.LeftShift))
        {
            sprintSpeedFactor = 2.0f;
        }

        transform.position += movement.normalized * Time.deltaTime * stats.movementSpeed * sprintSpeedFactor;

        //
        // Animation
        // 
        if (movement.magnitude > 0)
        {
            animator.SetBool("Walking", true);
        }
        else
        {
            animator.SetBool("Walking", false);
        }

        // Flip Character
        if (movement.x < 0)
        {
            GetComponent<SpriteRenderer>().flipX = true;
        }
        if (movement.x > 0)
        {
            GetComponent<SpriteRenderer>().flipX = false;
        }





        //
        // Casting
        //

        castTimer -= Time.deltaTime;
        if (Input.GetKeyDown(KeyCode.Space) && castTimer <= 0 && mana > 0)
        {
            mana -= 10;
            GameObject obj = Instantiate(fireballPrefab, transform.position, Quaternion.identity);
            obj.GetComponent<Fireball>().direction = lastMovement;
            castTimer =stats.castingTime;
            animator.SetBool("Attack", true);
        }
        if (Input.GetKeyUp(KeyCode.Space))
        {
            animator.SetBool("Attack", false);
        }


        // Mana Handling
        if (mana < stats.maxMana) {
            mana = mana + Time.deltaTime * stats.manaRegeneration;
        }
        // Health Handling

        if (hp < stats.maxHP)
        {
            hp = hp + Time.deltaTime * stats.healthRegeneration;
        }


        
    }



    public static PlayerStats GetStats()
    {
        return stats;
    }

    public Vector3 getPositionWizard() {

        
        return transform.position;
    
    }
}
