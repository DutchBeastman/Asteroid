using UnityEngine;
using System.Collections;

public class Meteoor : MonoBehaviour {
	
	
	public float health = 15;
	public float damage = 5;
	private int randomNumb;
	private float randomNumb2;
	private bool number1 = false;
	private bool number2 = false;
	private bool number3 = false;
	private bool number4 = false;
	public float spawn;

	
	public void DamageMe() {
		health -= damage;
		Debug.Log(health);
		
		
	}
		void Start () {
		spawn = 1;
		
		randomNumb = Random.Range(0, 4);
		randomNumb2 = Random.Range(0, 100);
		Debug.Log(randomNumb2);
		if(randomNumb == 0)
		{
			transform.position = new Vector3(-25, 0.5f, (randomNumb2-50) * 0.15f);
			number1 = true;
		}
		if(randomNumb == 1)
		{
			transform.position = new Vector3(25, 0.5f, (randomNumb2-50) * 0.15f);
			number2 = true;
		}
		if(randomNumb == 2)
		{
			transform.position = new Vector3((randomNumb2-50) * 0.2f, 0.5f, -20);
			number3 = true;
		}
		if(randomNumb == 3)
		{
			transform.position = new Vector3((randomNumb2-50) * 0.2f, 0.5f, 20);
			number4 = true;
		}
	}
		void FixedUpdate () {
		spawn -= 0.001f;
		if(spawn <= 0)
		{
			GameObject newMeteoor = Instantiate(Resources.Load("Prefab/Meteoor"),transform.position, transform.rotation) as GameObject;
			newMeteoor.transform.Translate(20,0,0);
			spawn = 1;
		}
		
		if(health <= 0)
		{
			Destroy(gameObject, 0f);
		}
	
		if(number1)
		{
		transform.Translate(0.2f, 0, 0);
			if(transform.position.x > 35)
			{
			transform.position = new Vector3(-35,0,0);
			//Destroy(gameObject);
			Debug.Log("ds1");
			}
		}
		if(number2)
		{
		transform.Translate(-0.2f, 0, 0);
			if(transform.position.x < -35)
			{
				
			//Destroy(gameObject);
			Debug.Log("ds2");
			}
		}
		if(number3)
		{
		transform.Translate(0, 0, 0.2f);
			if(transform.position.z > 35)
			{
			Destroy(gameObject);
			Debug.Log("ds3");
			}
		}
		if(number4)
		{
		transform.Translate(0, 0, -0.2f);
			if(transform.position.z < -35)
			{
			Destroy(gameObject);
			Debug.Log("ds4");
			}
  }
	}
}