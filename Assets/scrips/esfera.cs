using UnityEngine;
using System.Collections;

public class esfera : MonoBehaviour {
	public float izquierda;
	public float derecha;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		  
	{
		// Para ir a la derecha
		if (Input.GetAxis ("Horizontal") >= 0.0f) {
			this.transform.Translate (Vector2.right * this.derecha * Time.deltaTime, Space.World);
		}
		//Para ir a la izquierda
		if (Input.GetAxis ("Horizontal") <= 0.0f) {
			this.transform.Translate (Vector2.left * this.izquierda * Time.deltaTime, Space.World);
		}
	
	}
}
}