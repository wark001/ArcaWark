using UnityEngine;
using System.Collections;

public class eliminaMaoGris : MonoBehaviour {

	public int duresa=2;
	public Vector3 cameraRelative; 
	
	// Update is called once per frame
	/*void Update () {
		
		cameraRelative = gameObject.transform.InverseTransformPoint(transform.position);
		GameObject ball = GameObject.Find("bola");
		GameObject ballclone = GameObject.Find("bola(clone)");
		

	    if (cameraRelative.y > 0) {	
			ball.SendMessage("canviy");	
	    } else {	
			ball.SendMessage("canviy");
	    } 
	}*/
	
	
	
	void OnTriggerEnter (Collider col){
		
		if (duresa==2){
			gameObject.renderer.material.color=Color.blue;
			duresa--;
		}else{
			GameObject punts = GameObject.Find("CameraJoc");
			punts.SendMessage("sumaUnPunt");
			Destroy(gameObject);;
		}
		
		cameraRelative = gameObject.transform.InverseTransformPoint(transform.position);
		GameObject ball = GameObject.Find("bola");
			
	    if (cameraRelative.y != 0) {	
			ball.SendMessage("canviy");	
	    } else if (cameraRelative.x != 0){	
			ball.SendMessage("canvix");	
	    }
		
		if (cameraRelative.x > 0) {	
			ball.SendMessage("canvix");	
	    } else {	
			ball.SendMessage("canvix");	
	    }
		//canviar el shader  mes que color
		//col.gameObject.renderer.material.shader= Shader.Find("toon/basic out");
		
	//	public transform efecte;
		
	//	efecte.gameObject.
	}
	
	//en cub
	
}
