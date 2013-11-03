using UnityEngine;
using System.Collections;

public class rota : MonoBehaviour {
	
	public Transform thisObj;
    public float rotSpeed = 1.0f;
	
	// Use this for initialization
	void Start () {
		thisObj = this.transform;
	}
	
	// Update is called once per frame
	void Update () {

		thisObj.Rotate(0, Time.deltaTime*rotSpeed, 0, Space.World);

	}
}
