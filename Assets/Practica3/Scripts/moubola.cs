using UnityEngine;
using System.Collections;

public class moubola : MonoBehaviour {
	
	public float velocitat= 1f;
	public float velocitatx=2f;
	public float velocitaty=2f;
	
	void Start () {

		/*GameObject escenari = GameObject.Find("pantalla");
		transform.Translate (Time.deltaTime*velocitat, Time.deltaTime*velocitat, 0);
		
		Instantiate(segonabola, new Vector3(escenari.transform.position.x, 
			escenari.transform.position.y, 
			escenari.transform.position.z),Quaternion.identity);
			*/
	}
	void Update () {
	 
		transform.Translate (Time.deltaTime*velocitatx, Time.deltaTime*velocitaty, 0);
		
	}
	void OnCollisionEnter (Collision collision){
		if (collision.gameObject.name=="colliderDret"){
			velocitatx=velocitatx*-1;
		}else if (collision.gameObject.name=="colliderEsquerra"){
			velocitatx=velocitatx*-1;
		}else if (collision.gameObject.name=="colliderTop"){
			velocitaty=velocitaty*-1;
		}else if (collision.gameObject.name=="nau"){
			velocitaty=velocitaty*-1;
		}else if (collision.gameObject.name=="colliderBottom"){
			Destroy(gameObject);
		}else if (GameObject.Find("bloc")){
		//	costatbloc(collision);
		}
	}
	
	//void costatbloc(Collision collision){
	
    	//var relativePosition = transform.InverseTransformPoint(collision.contacts);
	   /* if (relativePosition.x > 0) {
	    	print ("The object is to the right");	
	    } else {	
	    	print ("The object is to the left");	
	    }	
	    if (relativePosition.y > 0) {	
	   		print ("The object is above.");	
	    } else {	
	    	print ("The object is below.");	
	    }	
	/*    if (relativePosition.z > 0) {	
	    	print ("The object is in front.");	
	    } else {	
	    	print ("The object is behind.");
	    }*/
	//}
	void canviy(){
		velocitaty=velocitaty*-1;
	}
	void canvix(){
		velocitatx=velocitatx*-1;
	}
	
}
