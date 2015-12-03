using UnityEngine;
using System.Collections;

public class plataformaMovimiento : MonoBehaviour {
	public float velocidad;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		this.transform.Translate (Vector3.up * this.velocidad * Time.deltaTime, Space.World);
	}
	void OnCollisionEnter2D (Collision2D other){
		if (other.gameObject.tag == "enemigo") {
			Destroy (this.gameObject); 
		}	
	}
}