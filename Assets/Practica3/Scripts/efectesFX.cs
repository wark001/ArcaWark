using UnityEngine;
using System.Collections;

public class efectesFX : MonoBehaviour {
	
	
	public Transform guanya;
	public Transform perd;
//	public Adioclip audioObertura;

	// Use this for initialization
	void Start () {
	//	gameObject.audio.PlayOneShot(audioObertura);
	}
	
	// Update is called once per frame
	void Update () {
		if (!GameObject.Find("bola") && !(GameObject.Find("bola(Clone)"))){
			//print ("dins bola");
			if (!GameObject.Find("bloc")){
				//print ("1bola");
				animacionsGuanyar();
			}else{
			//	print ("2bola");
				animacionsPerdre();
			}
		}
	}	
		
	void animacionsGuanyar(){
/*		Quaternion rot = Quaternion.FromToRotation (Vector3.up, contact.normal);
		Vector3 pos =  new Vector3(0,0,4);
		Instantiate(explosionPrefab,pos,rot);
		
*/
		if (!GameObject.Find("focs(Clone)")){
			Instantiate(guanya,transform.position,Quaternion.identity);
		}
		
		
		//print ("dins1");
	}
	void animacionsPerdre(){
		
		if (!GameObject.Find("perd(Clone)")){
			Instantiate(perd,transform.position,Quaternion.identity);
		}
		//Instantiate(perd,transform.position,Quaternion.identity);
		//print ("dins2");
	/*	Quaternion rot = Quaternion.FromToRotation (Vector3.up, contact.normal);
		Vector3 pos = new Vector3(0,0,4);;
		Instantiate(explosionPrefab,pos,rot);
		*/
	}
	
}
