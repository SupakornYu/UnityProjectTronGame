using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {



	Animator playerAnimator;


	float speed;
	float moveSpeed;
	float jumpSpeed;
	float rotationSpeed;
	float groundDistance;
	float colliderHeight;

	bool onGround;
	bool canSprint;


	Vector3 colliderCenter;
	Vector3 moveDistance;

	RaycastHit groundHit;
	
	CapsuleCollider capsuleCollider;
	Rigidbody playerRigidbody;



	void Start () {


		playerAnimator = GetComponent<Animator>();
		playerRigidbody = GetComponent<Rigidbody>();

		capsuleCollider = GetComponent<CapsuleCollider>();
		colliderHeight = GetComponent<CapsuleCollider>().height;
		colliderCenter = GetComponent<CapsuleCollider>().center;


		speed = 0.0f;
		moveSpeed = 2.0f;
		jumpSpeed = 7.5f;
		rotationSpeed = 3.0f;

		onGround = false;

	}


	void Update () {

		CheckGround();


		float h = Input.GetAxis("Horizontal");
		float v = Input.GetAxis("Vertical");
		bool sprint = Input.GetKey(KeyCode.LeftShift);
		bool jump = Input.GetKey(KeyCode.Space);
		bool crouch = Input.GetKey(KeyCode.R);
	

		if (onGround) {
			playerAnimator.SetBool ("onGround", true);
			moveSpeed = 1.0f;
		} else {
			playerAnimator.SetBool ("onGround", false);
			moveSpeed = 2.0f;
		}

		if(crouch){
			playerAnimator.SetBool("crouch",true);
			capsuleCollider.center = colliderCenter/1.4f;
			capsuleCollider.height = colliderHeight/1.4f;

		}else{
			playerAnimator.SetBool("crouch",false);
			capsuleCollider.center = colliderCenter;
			capsuleCollider.height = colliderHeight;

		}

		speed = Mathf.Sqrt(h*h+v*v);

		if(sprint){
			speed = speed + 0.5f;
			moveSpeed = 4.5f;
		}else{

			moveSpeed = 2.0f;

		}

		//Debug.LogError("h = " + h + " v = " + v + " speed = " + speed + " moveSpeed : " + moveSpeed + " jump: " + jump);

		playerAnimator.SetFloat("speed",speed);

	
		if(jump && onGround){
			playerAnimator.SetBool("jump",true);
			playerRigidbody.velocity = new Vector3(playerRigidbody.velocity.x,jumpSpeed,playerRigidbody.velocity.z);
		}else{
			playerAnimator.SetBool("jump",false);
		}


		if(speed != 0.0f){

			moveDistance.Set (h,0.0f,v);

			moveDistance = transform.TransformDirection(moveDistance);

			moveDistance = moveDistance.normalized*moveSpeed*Time.deltaTime;
			playerRigidbody.MovePosition(transform.position + moveDistance);

			
			Quaternion rotation = Quaternion.LookRotation(moveDistance,Vector3.up);
			transform.rotation = Quaternion.Slerp(transform.rotation, rotation, rotationSpeed * Time.deltaTime);
			
		}

	}

	void CheckGround(){
		Ray ray = new Ray(transform.position + new Vector3(0, colliderHeight / 2, 0), Vector3.down);

		if (Physics.Raycast(ray, out groundHit, Mathf.Infinity))
			groundDistance = transform.position.y - groundHit.point.y;
		
		if(Mathf.Abs (groundDistance) <= 0.2f)
			onGround = true;
		else
			onGround = false;


	}




}
