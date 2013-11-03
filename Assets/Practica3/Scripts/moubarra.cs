using UnityEngine;
using System.Collections;

public class moubarra : MonoBehaviour {

	public float velocitat = 3.0F;
	
	// Update is called once per frame
	void Update () {
		transform.Translate(Vector3.down/*.forward*/ * Time.deltaTime * Input.GetAxis("Horizontal")*velocitat);
	}
}
