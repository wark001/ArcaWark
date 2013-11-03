using UnityEngine;
using System.Collections;

public class powerUpNauGran : MonoBehaviour {
	
	public float sizey = 2F;
	
	void OnCollisionEnter (Collision collision){

		if (collision.gameObject.name=="colliderBottom"){
			Destroy(gameObject);
		}else if(collision.gameObject.name=="nau"){
			GameObject nau = GameObject.Find("nau");
        	nau.transform.localScale = new Vector3(transform.localScale.x, sizey, transform.localScale.y);
			Destroy(gameObject);
		}
	}

}
