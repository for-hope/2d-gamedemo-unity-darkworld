using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {
    public float maxSpeed = 3f;
    public float speed = 50f;
    public float jumpPower = 150f;
    public bool grounded;
    public bool alive;
    private  Rigidbody2D rb2d;
    private Animator anim;
    public bool isDead = false;
    public bool change = false;
    public bool res = false;
    private Player1 player1;
    public AudioClip impact;
    new AudioSource audio;
    public bool isKey = false;
    public bool isLeft = false;
    void Start () {
        rb2d = gameObject.GetComponent<Rigidbody2D>();
        anim = gameObject.GetComponent<Animator>();
        player1 = GameObject.Find("Player1").GetComponent<Player1>();
        audio = GetComponent<AudioSource>();
    }




    void Update () {

        
        if (isDead == true && change == true ) { 
            anim.SetBool("Alive", alive = false);
            
            if (res == true)
            {

                player1.transform.localPosition = new Vector3(-7, 0, 0);
                change = true;
                player1.isDead1 = false;
                res = false;
                isKey = false;
            }
            return;

        }
        else  {
            anim.SetBool("Alive", alive = true);
            anim.SetBool("Grounded", grounded);
            anim.SetFloat("Speed", Mathf.Abs(Input.GetAxis("Horizontal")));
            

            if (Input.GetAxis("Horizontal") < -0.1f)
            {
                transform.localScale = new Vector3(-1, 1, 1);
                isLeft = true;
            }
            if (Input.GetAxis("Horizontal") > 0.1f)
            {
                transform.localScale = new Vector3(1, 1, 1);
                isLeft = false;
            }
            if (Input.GetButtonDown("Jump") && grounded)
            {
                audio.PlayOneShot(impact, 0.7F);
                rb2d.AddForce(Vector2.up * jumpPower);

            }

        }
    }

    private void FixedUpdate()
    {
        if (isDead == true && change == true)

            return;



        float h = Input.GetAxis("Horizontal");
        //player movements
        rb2d.AddForce((Vector2.right * speed) * h);
       
        
        //speed limit
        if (rb2d.velocity.x > maxSpeed)
        {
            rb2d.velocity = new Vector2(maxSpeed, rb2d.velocity.y);
        }
        if (rb2d.velocity.x < -maxSpeed)
        {
            rb2d.velocity = new Vector2(-maxSpeed, rb2d.velocity.y);
        }
    }


}
