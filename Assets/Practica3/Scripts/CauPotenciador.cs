using UnityEngine;
using System.Collections;

public class CauPotenciador : MonoBehaviour {
	
	public Transform powerUp;
	
	void OnTriggerEnter (Collider col){
		
		GameObject bloc = gameObject;
		Instantiate(powerUp, new Vector3(bloc.transform.localPosition.x, 3.5f, bloc.transform.localPosition.y),Quaternion.identity);
		//powerUp.gameObject.renderer.material.color=Color.red;
		
		
	}
}
