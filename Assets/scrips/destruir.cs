using UnityEngine;
using System.Collections;

public class destruir : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnCollisionStay2D (Collision2D other){
		if (other.gameObject.tag == "enemigo") {
			Destroy (this.gameObject); //especificar que objeto quiero destruir
			//Application.LoadLevel (Application.loadedLevel); //para recargar el nivel del principio
		}
	}
	}

