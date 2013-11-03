using UnityEngine;
using System.Collections;

public class powerUp2boles : MonoBehaviour {
	
	public Transform segonabola;
	
	void Update () {
	
	}
	
	void OnCollisionEnter (Collision collision){
	
		if (collision.gameObject.name=="colliderBottom"){
			Destroy(gameObject);
		}else if(collision.gameObject.name=="nau"){
			GameObject bola = GameObject.Find("bola");
			Instantiate(segonabola, new Vector3(bola.transform.localPosition.x, bola.transform.localPosition.y, 3.5f),Quaternion.identity);
			Destroy(gameObject);
		}
		
	}
}
