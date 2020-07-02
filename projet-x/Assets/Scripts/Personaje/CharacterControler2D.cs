using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterControler2D : MonoBehaviour
{
    [SerializeField] private float jumpForce = 500f;                    //Characters Jump Force
    [SerializeField] private int amountJumps = 2;

    [SerializeField] private Transform groundCheck;                     //An object to chek characters collision with Ground (OverlapCircleAll)
    [SerializeField] private LayerMask ground;                          //Defines what is Gorund (OverlapCircleAll)
    const float radious = 0.2f;                                         //Radious of action (OverlapCircleAll)
    private bool isGrounded = false;                                    //A boolean to set when character is touching ground

    private Rigidbody2D rb;                                             //Players Rigidbody2D

    private bool facingRight = true;                                    //A boolean for seeing when character is facing right

    // Start is called before the first frame update
    void Start() {
        rb = GetComponent<Rigidbody2D>();
    }
    // Update is called once per frame
    void Update() {
        if (isGrounded) {
            amountJumps = 2;
        }
    }
    //Fixed Update is used for physics
    private void FixedUpdate() {
        isGrounded = false;
        Collider2D[] collider = Physics2D.OverlapCircleAll(groundCheck.position, radious, ground);
        for(int i=0; i<collider.Length; i++) {
            if (collider[i].gameObject != gameObject) {
                isGrounded = true;
            }
        }
    }
    //Method to control characters movement
    public void Move(float movement, bool jump) {
        rb.velocity = new Vector2(movement, rb.velocity.y);

        if (isGrounded && jump && amountJumps > 1) {
            amountJumps--;
            rb.AddForce(new Vector2(0f, jumpForce));
        }
        else if (!isGrounded && jump && amountJumps > 1) {
            amountJumps--;
            rb.AddForce(new Vector2(0f, jumpForce));
        }
        //amountJumps = 2;


        //Condition to flips the sprite
        if (facingRight == false && movement > 0) {
            Flip();
        }
        else if (facingRight == true && movement < 0) {
            Flip();
        }
    }
    //Method that flips the character depending on the horizontal move you preform
    private void Flip() {
        facingRight = !facingRight;

        transform.Rotate(0f, 180f, 0f);
    }
}
