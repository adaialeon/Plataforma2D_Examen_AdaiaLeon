using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;


public class playermovement : MonoBehaviour
{

    public Animator anim;
    public PlayableDirector director;
    private Rigidbody2D rb;
    float dirX;
    public bool isGorounded;
    public float jumpForce = 10f;
    public GameObject star;

    private void Awake() 
    {
        rb = GetComponent<Rigidbody2D>();   
        anim = GetComponent<Animator>();    
        playerTransform = GetComponent<Transform>();
    }

    private void FixedUpdate() 
    {
        rb.velocity = new Vector2 (horizontal * speed, rb.velocity.y);
    }

    public float speed = 5.5f; 
    private float horizontal;
    private Transform playerTransform;

    void Update()
    {

        dirX = Input.GetAxisRaw("Horizontal");
        Debug.Log(dirX);

        horizontal = Input.GetAxisRaw("Horizontal");     
        
        //Rotacion del personaje
        if(dirX ==-1)
        {
            anim.SetBool("Correr", true);
            transform.rotation = Quaternion.Euler(0, 180, 0);
        }
        else if(dirX == 1)
        {
            anim.SetBool("Correr", true);
            transform.rotation = Quaternion.Euler(0, 0, 0);
        }
        else
        {
            anim.SetBool("Correr", false);
        }


        if(Input.GetButtonDown("Jump") && isGorounded)
        {
            rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
            anim.SetBool("Saltar", true);
        }
        
        
        if(playerTransform.gameObject.layer == 3)
        {
            Debug.Log("SumarEstrella");
            gamemanager.Instance.SumarEstrellas();
            Destroy(star.gameObject);
         }
        
    }


    /*if(other.gameObject.layer == 6)
     {
        Debug.Log("estrella");
        gamemanager.Instance.SumarEstrellas();
        Destroy(other.gameObject);
        Destroy(other.gameObject);
            
    }*/
        
}   

  

