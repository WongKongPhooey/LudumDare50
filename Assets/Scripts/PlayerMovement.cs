using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

	public CharacterController2D controller;

	public float runSpeed = 40f;
	public Animator animator;

	float horizontalMove = 0f;
	bool jump = false;
	bool crouch = false;
    public bool dead = false;
	
	// Update is called once per frame
	void FixedUpdate () {

		// Move our character
		controller.Move(horizontalMove * Time.fixedDeltaTime,crouch, jump);
		jump = false;

		horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;
		animator.SetFloat("WalkSpeed",Mathf.Abs(horizontalMove));

		if (Input.GetButtonDown("Jump"))
		{
			jump = true;
			animator.SetBool("IsJumping",true);
		}

		//if (Input.GetButtonDown("Crouch"))
		//{
		//	crouch = true;
		//} else if (Input.GetButtonUp("Crouch"))
		//{
		//	crouch = false;
		//}

	}
	

	public void OnLanding()
	{
		animator.SetBool("IsJumping",false);
	}
}