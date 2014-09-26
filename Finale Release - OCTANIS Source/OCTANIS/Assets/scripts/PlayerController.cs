using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour
{
	public float speed;

	void Update ()
	{
		float MoveHorozontal = Input.GetAxis ("Horizontal");
		float MoveVertical = Input.GetAxis ("Vertical");

		Vector3 movement = new Vector3(MoveHorozontal, 0.0f, MoveVertical);

		rigidbody.AddForce (movement * speed * Time.deltaTime);
	}
}
