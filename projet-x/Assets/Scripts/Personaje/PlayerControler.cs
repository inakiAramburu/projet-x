using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControler : MonoBehaviour
{
    public CharacterControler2D controler;

    private float horizontalMove = 0f;
    public float speed = 300f;
    private bool jump = false;

    // Update is called once per frame
    void Update() {
        horizontalMove = Input.GetAxisRaw("Horizontal") * speed;

        if (Input.GetKeyDown("space") || Input.GetKeyDown("w")) {
            jump = true;
        }
    }

    void FixedUpdate() {
        controler.Move(horizontalMove * Time.deltaTime, jump);
        jump = false;
    }
}
