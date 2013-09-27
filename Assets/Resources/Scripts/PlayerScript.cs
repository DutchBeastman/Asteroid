using UnityEngine;
using System.Collections;

public class PlayerScript : MonoBehaviour {
	
	public int Health = 3;
	public float thrusterSpeed;
	public float rotationSpeed;
	
	public GUIText HealthCounter;
	// Use this for initialization
	void Start () {
		Health = 3;
		HealthCounting();
		
			
	}
	void HealthCounting()
	{
		HealthCounter.text = "Health is: " + Health;	
	}
	void DamageMe()
	{
		
		Health --;
		HealthCounting();
		if(Health == 0)
		{
			killed();	
		}
	}
	void killed()
	{
		
		
			Destroy(gameObject, 2);	
			Instantiate(Resources.Load("Prefab/Explosion"), transform.position, Quaternion.identity);
		
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
			transform.position = new Vector3(transform.position.x,0,-22);	
		}
		else if(transform.position.z <= -22)
		{
			transform.position = new Vector3(transform.position.x,0,24);	
		}
		 if(transform.position.x >= 39)
		{
			transform.position = new Vector3(-40,0,transform.position.z);	
		}
		
		else if(transform.position.x <= -40)
		{
			transform.position = new Vector3(39,0,transform.position.z);	
		}
		
		
			
		
		
	}
	public void OnTriggerEnter(Collider col)
		 { 
		  // destroy the enemy
		  if(col.name == "Meteoor(Clone)")
		  { 
			
			Debug.Log ("Meteoor hit");	
			Destroy(col.collider.gameObject,1.5f);
			DamageMe();
			Instantiate(Resources.Load("Prefab/Explosion"), transform.position, Quaternion.identity);
		   
		  }
 	}
}
