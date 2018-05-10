using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotation : MonoBehaviour {

	/*public float speed ;
	// Update is called once per frame
	void Update () {
		transform.Rotate(Vector3.left, speed , Space.Self);
		transform.Translate (Vector3.back * Time.deltaTime * speed);


		//transform.Rotate((Vector3.forward* Time.deltaTime), Space.Self);
	}*/
	public float speed;

	private Rigidbody rb;

	void Start ()
	{
		rb = GetComponent<Rigidbody>();
	}

	void FixedUpdate ()
	{
		

		Vector3 movement = new Vector3 (0.0f,0.0f,-1.0f);

		rb.AddForce (movement * speed);
	}
}
