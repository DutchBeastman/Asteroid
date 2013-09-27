using UnityEngine;
using System.Collections;

public class Meteoor : MonoBehaviour {
	
	
	private float score = 0;
	public float health = 15;
	public float damage = 5;
	private int randomNumb;
	private float randomNumb2;
	private bool number1 = false;
	private bool number2 = false;
	private bool number3 = false;
	private bool number4 = false;
	public GUIText ScoreCounter;
	
	
	void ScoreCounting()
	{
		ScoreCounter.text = "Score is: " + score;	
	}
	
	public void DamageMe() {
		health -= damage;
		Debug.Log(health);
		
		
		
	}
	public void RemoveMeteoor()
	{
		Destroy(gameObject, 1.5f);
		Debug.Log("It be gauown");
		score += 1;
		Instantiate(Resources.Load("Prefab/Explosion"), transform.position, Quaternion.identity);
	}
	void Start () {
		
		score = 0;
		ScoreCounting();
		
		randomNumb = Random.Range(0, 4);
		randomNumb2 = Random.Range(0, 100);
		
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
		if(health <= 0)
		{
			RemoveMeteoor();	
		}
		
		
	
		if(number1)
		{
		transform.Translate(0.2f, 0, 0);
			if(transform.position.x > 35)
			{
			transform.position = new Vector3(-35,0,0);
			//Destroy(gameObject);
			
			}
		}
		if(number2)
		{
		transform.Translate(-0.2f, 0, 0);
			if(transform.position.x < -35)
			{
				
			//Destroy(gameObject);
			
			}
		}
		if(number3)
		{
		transform.Translate(0, 0, 0.2f);
			if(transform.position.z > 35)
			{
			Destroy(gameObject);
			
			}
		}
		if(number4)
		{
		transform.Translate(0, 0, -0.2f);
			if(transform.position.z < -35)
			{
			Destroy(gameObject);
			
			}
  		}
	}
	
	

}