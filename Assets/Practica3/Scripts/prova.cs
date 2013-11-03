using UnityEngine;
using System.Collections;

public class prova : MonoBehaviour {
	
	public float lay = 5F;
	// Use this for initialization
	void Start () {
//		transform.localScale = Vector3(2,2,2);
	/*	Vector3 scale = transform.localScale;
    	scale.y = 1F; // your new value
    	transform.localScale = scale;
	*/	
		transform.localScale = new Vector3(transform.localScale.x, lay, transform.localScale.y);
		
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
