using UnityEngine;
using System.Collections;

public class instanciar : MonoBehaviour {
	public GameObject objeto;
	public float tiempoEntreObjetos;
	
	private float tiempoUltimoObjeto;
	
	// Use this for initialization
	void Start () {
		this.tiempoUltimoObjeto = Time.time;
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Time.time - this.tiempoUltimoObjeto >= this.tiempoEntreObjetos) {
			Instantiate (objeto, this.transform.position, this.transform.rotation);
			this.tiempoUltimoObjeto = Time.time;
		}
	}
}
