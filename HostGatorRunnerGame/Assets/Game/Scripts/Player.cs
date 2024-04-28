using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Rigidbody2D plyRB;
    private Animator animator;
    private bool canJump;

    public float jumpFactor = 5f;
    public float forwardFactor = 0.2f;
    void Start()
    {
        plyRB = gameObject.GetComponent<Rigidbody2D>();
        animator = gameObject.GetComponent<Animator>();
        canJump = true;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space)){
            Jump();
        }
    }

    void Jump(){
        if(canJump){
            canJump = false;
            plyRB.velocity = new Vector2(forwardFactor,jumpFactor);
            animator.Play("player_jumping");
        }
    }

    private void OnCollisionEnter2D(Collision2D collision){
        canJump = true;
        animator.Play("player_running");
    }
}
