using UnityEngine;
using System.Collections;

public class animacio : MonoBehaviour {
	
	//public Transform cam = Camera.main.transform;
    public Vector3 cameraRelative; 
	public Transform explosionPrefab;
	private float timer = 1.0f;
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		timer += Time.deltaTime;
		print ("hola1 "+timer);
		if (timer>1){
			print ("hola2 "+timer);
			Destroy(GameObject.Find("focs(Clone)"));
		}
	}
	
	void OnTriggerEnter (Collider col){
		
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
		timer = 0.0f;
		Instantiate(explosionPrefab,transform.position,Quaternion.identity);
		//explosionPrefab.animation=false;
		
		
	}
}
