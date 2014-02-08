using UnityEngine;
using System.Collections;

public class touch : MonoBehaviour {

	Camera cam;
	
	void Start () {
		if (cam == null)
			cam = Camera.main;
	}
	
	void Update () {
		if (Input.GetMouseButtonDown(0)) {
			
			float distanceZ = transform.position.z - cam.transform.position.z;
			Vector3 position = new Vector3(Input.mousePosition.x, Input.mousePosition.y, distanceZ);
			position = cam.ScreenToWorldPoint(position);
			position= new Vector3(position.x, transform.position.y, position.z);
			//transform.Translate(position);
			transform.position = position;
		}
		if (Input.touchCount == 1){
			
			//Input.GetTouch(0).position.x
			
			
			Vector3 position = new Vector3(
				Input.GetTouch(0).deltaPosition.x, 
				Input.GetTouch(0).deltaPosition.y);
			//	Vector3 position_original = new Vector3(transform.position.x, transform.position.y, transform.position.z);
			//paso la posicio de la pantalla on ha tocat a la posicio al mon real
			position = cam.ScreenToWorldPoint(position);
			position= new Vector3(position.x, transform.position.y, transform.position.z);
			//canvio posicio objecte
			//transform.Translate(position * Time.deltaTime*2);
			transform.position = position;
		}
	}
	void OnGUI()
	{
		GUI.Label(new Rect(0,10,110,20), "X: "/*+touch.position.x*/);
		GUI.Label(new Rect(0,20,110,20), "Y: "/*+touch.position.x*/);
		GUI.Label(new Rect(0,30,110,20), "Z: "/*+touch.position.x*/);
		
	}
}
