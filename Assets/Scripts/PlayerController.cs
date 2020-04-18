using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	public float speed = 300.0F;
	public float jumpSpeed = 7.0F;
	public float jumpMultiplier = 1.0f;
	public float gravity = 9.8F;
    public float rotationSpeed = 180;


	private Vector3 moveDirection = Vector3.zero;
    private Vector3 rotation = Vector3.zero;

	public Vector3 getMoveDirection() {
		return this.moveDirection;
	}

	void FixedUpdate() {
		CharacterController controller = GetComponent<CharacterController>();
		this.rotation = new Vector3(0, Input.GetAxisRaw("Horizontal") * rotationSpeed * Time.deltaTime, 0);
 		this.transform.Rotate(this.rotation);

		if (controller.isGrounded) {
			moveDirection = new Vector3(0, 0, Input.GetAxisRaw("Vertical") * Time.deltaTime);
			moveDirection = this.transform.TransformDirection(moveDirection);
			moveDirection *= speed;

			jumpMultiplier = 1.0f;
			if (Input.GetButton("Fire3")) {
				moveDirection *= 2.0f;
				jumpMultiplier = 1.2f;
			}
	
			if (Input.GetButton("Jump")) {
				moveDirection.y = jumpSpeed * jumpMultiplier;
			}
		}

		moveDirection.y -= gravity * Time.deltaTime;
		controller.Move(moveDirection * Time.deltaTime);
	}
}
