using UnityEngine;
using System.Collections;

public class Schieten : MonoBehaviour {
	
	bool shooting = false;
	
	 void Update() {
        RaycastHit hit;
		if(Input.GetAxis("Fire1")==1){
			if(!shooting)
      			if (Physics.Raycast(transform.position, Vector3.forward, out hit)){
          			if (hit.transform.tag == "Meteoor") {
					Debug.Log ("yo mama");
						hit.transform.GetComponent<Meteoor>().DamageMe();
						shooting = true;
				}
					
        	}
		} else {
			shooting = false;
		}
	
	}
}
