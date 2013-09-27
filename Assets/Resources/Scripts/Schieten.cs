using UnityEngine;
using System.Collections;

public class Schieten : MonoBehaviour {
	
	bool shooting = false;
	float score;
	
	 void Update() {
        RaycastHit hit;
		if(Input.GetAxis("Fire1")== 1){
			if(!shooting)
				
      			if (Physics.Raycast(transform.position,Vector3.forward, out hit)){
				//Debug.Log("Send");
															
          			if (hit.transform.tag == Tags.Meteoor) {
					Debug.Log("Hitted");
						hit.transform.GetComponent<Meteoor>().DamageMe();
						Debug.Log ("Damged");
						shooting = true;
				}
					
        	}
		} else {
			shooting = false;
		}
	
	}
}
