using UnityEngine;
using System.Collections;

public class presentacio : MonoBehaviour {

	public Texture2D textura;
	public float amplada  = 240;
	public float altura = 512;
	//private float timer = 0.0f;
	
	
	//GameObject.Find("cpresentacio").camera.GetScreenHeight;
	void Start(){
		
		amplada = GameObject.Find("cpresentacio").camera.GetScreenWidth();
		altura = GameObject.Find("cpresentacio").camera.GetScreenHeight();
	//	GameObject.Find("cpresentacio").camera. = altura;
	}
		
	void Update () {
		
		//altura = GameObject.Find("cpresentacio").camera.GetScreenHeight();
		//print ("hola: "+ altura);
	}
	
	void OnGUI()
	{
	
    	GUI.Label(new Rect(0,0, textura.width, altura), textura);
		if (GUI.Button(new Rect(115,168,100,20), ""))
		{
			Application.LoadLevel(1);
		};

	}

}
