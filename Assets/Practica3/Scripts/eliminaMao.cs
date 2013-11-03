using UnityEngine;
using System.Collections;

public class eliminaMao : MonoBehaviour {
	
	//public Transform cam = Camera.main.transform;
    public Vector3 cameraRelative; 
	public Transform explosionPrefab;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
	/*	cameraRelative = gameObject.transform.InverseTransformPoint(transform.position);
		GameObject ball = GameObject.Find("bola");
		GameObject ballclone = GameObject.Find("bola(clone)");
		
		if (cameraRelative.x > 0) {
	    	ball.SendMessage("canvix");
			ballclone.SendMessage("canvix");
	    } else {	
	    	ball.SendMessage("canvix");
			ballclone.SendMessage("canvix");	
	    }
	    if (cameraRelative.y > 0) {	
			ball.SendMessage("canviy");
		//	ballclone.SendMessage("canviy");
	   		//print ("The object is above.");	
	    } else {	
			ball.SendMessage("canviy");
		//	ballclone.SendMessage("canviy");
	    	//print ("The object is below.");	
	    }*/
	    
	}
	
	void OnTriggerEnter (Collider col){
		
		//string hola=gameObject.transform.InverseTransformPoint.ToString();
		//print (""+ gameObject.transform.InverseTransformPoint.ToString());
		GameObject punts = GameObject.Find("CameraJoc");
		punts.SendMessage("sumaUnPunt");
		Destroy(gameObject);
		
		cameraRelative = gameObject.transform.InverseTransformPoint(transform.position);
		GameObject ball = GameObject.Find("bola");
			
	    if (cameraRelative.y > 0) {	
			ball.SendMessage("canviy");	
	    } else {	
			ball.SendMessage("canviy");	
	    }
		if (cameraRelative.x > 0) {	
			ball.SendMessage("canvix");	
	    } else {	
			ball.SendMessage("canvix");	
	    }
		
		focsartificials();

	}
	
	/*void exemple(Collision collision){
	    
		Vector3 relativePosition = gameObject.transform.InverseTransformPoint(collision.position);
	
	    if (relativePosition.x > 0) {
	    	print ("The object is to the right");	
	    } else {	
	    	print ("The object is to the left");	
	    }	
	    if (relativePosition.y > 0) {	
	   		print ("The object is above.");	
	    } else {	
	    	print ("The object is below.");	
	    }
	}*/
	
	/*
	 public Transform cam = Camera.main.transform;
    public Vector3 cameraRelative = cam.InverseTransformPoint(transform.position);
    void Example() {
        if (cameraRelative.z > 0)
            print("The object is in front of the camera");
        else
            print("The object is behind the camera");
    }*/
	void focsartificials(){
	
		///Quaternion rot = Quaternion.FromToRotation (Vector3.up, contact.normal);
		//Vector3 pos = transform.position;
	//	Instantiate(explosionPrefab,transform.position,Quaternion.identity);
	//	explosionPrefab.particleEmitter.
	//	Destroy(explosionPrefab);
		
	}
}
