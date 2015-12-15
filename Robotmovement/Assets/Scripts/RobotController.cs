using UnityEngine;
using System.Collections;

public class RobotController : MonoBehaviour {

	float moveDistance;
	Rigidbody playerRigidbody;
	Animator animator;

	float speed;
	float moveSpeed;
	float rotationSpeed;

	bool sprint;
	bool crouch;

	float capsuleColliderHeight;
	Vector3 capsuleColliderCenter;

	CapsuleCollider capsuleCollider;

	// Use this for initialization
	void Start () {

		capsuleCollider = GetComponent<CapsuleCollider> ();
		capsuleColliderHeight = capsuleCollider.height;
		capsuleColliderCenter = capsuleCollider.center;

		playerRigidbody = GetComponent<Rigidbody> ();
		animator = GetComponent<Animator> ();

		moveDistance = 0.0f;
		speed = 0.0f;
		moveSpeed = 0.0f;
		rotationSpeed = 0.0f;

		sprint = false;
		crouch = true;
	}
	
	// Update is called once per frame
	void Update () {
		float h = Input.GetAxis("Horizontal");
		float v = Input.GetAxis("Vertical");

		speed = Mathf.Sqrt (h * h + v * v);

		Debug.LogError ("speed : " + speed);

		if (sprint) {
			speed += 0.5f;
		}
		animator.SetFloat ("speed", speed);
		animator.SetBool ("crouch", true);

		if (crouch) {
			capsuleCollider.height = capsuleColliderHeight/1.4f;
			capsuleCollider.center = capsuleColliderCenter/1.4f;
		}

		if (Input.GetKey (KeyCode.R)) {

			animator.applyRootMotion = true;

		} else {

			animator.applyRootMotion = false;

		}
	}
}
