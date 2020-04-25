using UnityEngine;
using UnityEngine.EventSystems;
using System.Collections;

public class PlayerController : MonoBehaviour {

	public float speed = 300.0F;
	public float jumpSpeed = 7.0F;
	public float jumpMultiplier = 1.0f;
	public float gravity = 9.8F;
    public float rotationSpeed = 180;
	public Animator animator;


	private Vector3 moveDirection = Vector3.zero;
    private Vector3 rotation = Vector3.zero;
	private bool teleport = false;
	private Vector3 teleportPosition = Vector3.zero;

	public Vector3 getMoveDirection() {
		return this.moveDirection;
	}

	private void teleportar(Vector3 posicion) {
		EventSystem.current.SetSelectedGameObject(null);
		this.teleport = true;
		this.teleportPosition = posicion;
	}

	public void teleportEntradaPrincipal() {
		this.teleportar(new Vector3(10.0f,43.1f,-73.2f));
    }

	public void teleportAulas1() {
		this.teleportar(new Vector3(84.30f,23.08f,234.58f));
    }

	public void teleportAulas2() {
		this.teleportar(new Vector3(48.57f,23.08f,356.14f));
    }

	public void teleportAulas3() {
		this.teleportar(new Vector3(-4.25f,23.08f,428.93f));
    }

	public void teleportAulas4() {
		this.teleportar(new Vector3(-74.41f,23.08f,493.49f));
    }

	public void teleportCafeteria() {
		this.teleportar(new Vector3(29.80f,23.08f,639.99f));
    }

	void FixedUpdate() {
		CharacterController controller = GetComponent<CharacterController>();
		this.rotation = new Vector3(0, Input.GetAxisRaw("Horizontal") * rotationSpeed * Time.deltaTime, 0);
 		this.transform.Rotate(this.rotation);

		if (controller.isGrounded) {
			animator.SetBool("isRunning",false);
			moveDirection = new Vector3(0, 0, Input.GetAxisRaw("Vertical") * Time.deltaTime);
			moveDirection = this.transform.TransformDirection(moveDirection);
			moveDirection *= speed;

			if (moveDirection == Vector3.zero) {
				animator.SetBool("isWalking",false);
			} else {
				animator.SetBool("isWalking",true);
			}

			jumpMultiplier = 1.0f;
			if (Input.GetButton("Fire3")) {
				moveDirection *= 2.0f;
				jumpMultiplier = 1.2f;
				animator.SetBool("isRunning",true);
			}
	
			if (Input.GetButton("Jump")) {
				moveDirection.y = jumpSpeed * jumpMultiplier;
			}
		}

		moveDirection.y -= gravity * Time.deltaTime;
		controller.Move(moveDirection * Time.deltaTime);
		
		if (this.teleport) {
			this.transform.position = this.teleportPosition;
			this.teleport = false;
		}
	}
}
