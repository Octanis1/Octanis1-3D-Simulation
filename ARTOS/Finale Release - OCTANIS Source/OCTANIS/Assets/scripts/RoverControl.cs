using UnityEngine;
using System.Collections;

public class RoverControl : MonoBehaviour 
{
	//Movement control
	public float speed;
	//Change position
	private Vector3 moveDirection;
	private Vector3 newPosition;
	//Change rotation
	private Vector3 startPos;
	private Quaternion startRot;
	
	void Start() 
	{
		startPos = transform.position;
		startRot = transform.rotation;
	}

	void FixedUpdate ()
	{
		if(Input.GetKey(KeyCode.D))
			gameObject.transform.Rotate(0, 90 * Time.deltaTime, 0);
		if(Input.GetKey(KeyCode.A))
			gameObject.transform.Rotate(0, -90 * Time.deltaTime, 0);
		if(Input.GetKey(KeyCode.W))
			rigidbody.AddForce (transform.forward * speed * Time.deltaTime);
		if(Input.GetKey(KeyCode.S))
			rigidbody.AddForce (transform.forward * -speed * Time.deltaTime);
		//Reset the rover's position
		if(Input.GetKey(KeyCode.R))
		{
			transform.position = startPos;
			transform.rotation = startRot;
		}
	}
}
