using UnityEngine;
using System.Collections;
// Assert機能を利用するためのusing
using UnityEngine.Assertions;

[RequireComponent(typeof(Rigidbody))]
public class PlayerController : MonoBehaviour {



	private Rigidbody rb;
	private float moveHorizontal;
	private float moveVertical;
	public float speed;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody> ();
	}

	// Update is called once per frame
	void Update () {
		// Input系はUpdate関数内で
		moveHorizontal = Input.GetAxis ("Horizontal");
		moveVertical = Input.GetAxis ("Vertical");
	}

	// RigidBody系はfixedUpdateで
	void FixedUpdate(){
		Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);

		rb.AddForce (movement * speed);
	}

	// 接触時に1度だけ呼ばれる
	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.CompareTag("Item"))
		{
			other.gameObject.SetActive(false);
		}
	}
}
