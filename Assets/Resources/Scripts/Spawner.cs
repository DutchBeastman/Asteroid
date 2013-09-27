using UnityEngine;
using System.Collections;

public class Spawner : MonoBehaviour {
	
	public float speed;
	
	private float xMovement;
	private float zMovement;
	public float spawn = 3;
	
	void Start()
	{
		
		// bepaal x richting
		xMovement = 1f;//Random.Range(-1f, 1f);
		
		// bepaal y richting
		zMovement = Random.Range(-1f, 1f);
	}
	void Update()
	{
		spawn = spawn - Time.deltaTime;
		if(spawn <= 0){
			GameObject newMeteoor = Instantiate(Resources.Load("Prefab/Meteoor")) as GameObject;
			
			
		
		// beweeg
		transform.Translate(new Vector3(xMovement, 0f, zMovement) * speed * Time.deltaTime);
		
		// wrap
		Wrap();
		spawn = 2;
		}
	}
	public void Wrap()
	{
		if (transform.position.x < -40)
		{
			Vector3 temp = transform.position;
			temp.x = 20;
			transform.position = temp;
		}
		else if (transform.position.x > 40)
		{
			Vector3 temp = transform.position;
			temp.x = -40;
			transform.position = temp;
		}
			if (transform.position.z < -40)
		{
			Vector3 temp = transform.position;
			temp.z = 40;
			transform.position = temp;
		}
		else if (transform.position.z > 40)
		{
			Vector3 temp = transform.position;
			temp.z = -40;
			transform.position = temp;
		}
	}
}
