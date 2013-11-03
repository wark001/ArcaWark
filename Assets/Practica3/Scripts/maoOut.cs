using UnityEngine;
using System.Collections;

public class maoOut : MonoBehaviour {
	
	public float sizey = 2F;
	public Transform segonabola;
	public Transform powerUp;
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void OnTriggerEnter (Collider col){
	
		caupotenciador();
		Destroy(gameObject);
		
		col.gameObject.renderer.material.color=Color.green;
		
		//potenciadorgran();
	//	potenciadordosboles();
	//	caupotenciador();
	}
	
/*	void OnTriggerExit(Collider col){
		col.gameObject.renderer.material.color=Color.blue;
		GameObject go = GameObject.Find("T");
		go.renderer.material.color=Color.grey;
	}*/

	void potenciadorgran(){

		GameObject nau = GameObject.Find("nau");
        nau.transform.localScale = new Vector3(transform.localScale.x, sizey, transform.localScale.y);
	}
	void potenciadordosboles(){
		
		GameObject bola = GameObject.Find("bola");
		//bola.transform.localScale.x
		Instantiate(segonabola, new Vector3(bola.transform.localPosition.x, bola.transform.localPosition.z, bola.transform.localPosition.y),Quaternion.identity);
	}
	void caupotenciador(){
		
		print ("entrat");
		GameObject bloc = GameObject.Find("bloc1");
		Instantiate(powerUp, new Vector3(bloc.transform.localPosition.x, bloc.transform.localPosition.z, bloc.transform.localPosition.y),Quaternion.identity);
		powerUp.gameObject.renderer.material.color=Color.red;
		
	}
}
