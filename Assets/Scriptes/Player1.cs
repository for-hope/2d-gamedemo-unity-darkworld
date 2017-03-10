using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1 : MonoBehaviour {
    public float maxSpeed = 3f;
    public float speed = 50f;
    public float jumpPower = 150f;
    public bool grounded;
    public bool alive;
    private Rigidbody2D rb2d;
    private SpriteRenderer sprt;
    private Animator anim;
    public bool isDead1 = false;
    public bool res1 = false;
    private Player player;
    new AudioSource audio;
    public AudioClip impact;
    public SpriteRenderer spriteRenderer;
    public bool isKey = false;
    public bool isLeft = false;
    void Start () {
        rb2d = gameObject.GetComponent<Rigidbody2D>();
        anim = gameObject.GetComponent<Animator>();
        player = GameObject.Find("Player").GetComponent<Player>();
        audio = GetComponent<AudioSource>();
    }

    

	
	void Update () {
       

        if (isDead1 == true) { 
            anim.SetBool("Alive", alive = false);
            if (res1 == true)
            {

                player.transform.localPosition = new Vector3(-7, 0, 0);
                player.change = false;
                player.isDead = false;
                res1 = false;
                isKey = false;
            }

            return;
        }
        else  {
            if (player.change == true)
            {
               rb2d.simulated = true;
               spriteRenderer.enabled = true;
            }
            anim.SetBool("Grounded", grounded);
            anim.SetFloat("Speed", Mathf.Abs(Input.GetAxis("Horizontal")));
            anim.SetBool("Alive", alive = true);

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
        if (isDead1 == true)

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
