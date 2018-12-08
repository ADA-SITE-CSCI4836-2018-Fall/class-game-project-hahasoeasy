using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
    float speed = 10f;
    float jumpspeed = 12f;
    private float movement = 0f;
    private Rigidbody2D rigidbody;
    public Transform groundcheckpoint;
    public float groundcheckradius;
    public LayerMask groundlayer;
    public bool isTouchingGround;
    
    // Use this for initialization

   
    

    void Start () {
        rigidbody = GetComponent<Rigidbody2D>();
	}
    void OnTriggerEnter2D (Collider2D col){

        isTouchingGround=true;
    }

	void OnTriggerStay2D(Collider2D col){
        isTouchingGround=true;
    }
    void OnTriggerExit2D(Collider2D col){
        isTouchingGround=false;

    }
	// Update is called once per frame
	void Update () {
        // isTouchingGround= Physics2D.OverlapCircle(groundcheckpoint.position,groundcheckradius,groundlayer);
        movement = Input.GetAxis("Horizontal");
        Vector2 newScale = transform.localScale;
        if(movement>0f){
            
            rigidbody.velocity = new Vector2(movement * speed, rigidbody.velocity.y);
            transform.localScale= new Vector2(1.0258f,0.7586f);
            
        }
        if(movement<0f){
            rigidbody.velocity = new Vector2(movement * speed, rigidbody.velocity.y);
            transform.localScale= new Vector2(-1.0258f,0.7586f);

        }

        if (Input.GetButtonDown("Jump") && isTouchingGround )
        {
            rigidbody.velocity = new Vector2(rigidbody.velocity.x, jumpspeed);
        }
    }

    



}
