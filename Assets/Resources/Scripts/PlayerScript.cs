using UnityEngine;
using System.Collections;

public class PlayerScript : MonoBehaviour {
	public float Health;
	public float thrusterSpeed;
	public float rotationSpeed;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		
		float z = Input.GetAxis("Vertical");
		Vector3 movement = new Vector3(0,0,z);
		
		rigidbody.AddRelativeForce(movement * thrusterSpeed * Time.deltaTime);	
		
		float x = Input.GetAxis("Horizontal");
		Vector3 movementX = new Vector3(0,x,0);
		
		transform.Rotate( movementX * rotationSpeed * Time.deltaTime);	
		
		if(transform.position.z >= 24)
		{
			transform.position = new Vector3(transform.position.x,0,-21);	
		}
		if(transform.position.x >= 37)
		{
			transform.position = new Vector3(-34,0,transform.position.z);	
		}
		if(transform.position.z <= -22)
		{
			transform.position = new Vector3(transform.position.x,0,22);	
		}
		if(transform.position.x <= -38)
		{
			transform.position = new Vector3(36,0,transform.position.z);	
		}
		
		
			
		
		
	}
}
