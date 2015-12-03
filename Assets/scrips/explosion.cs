using UnityEngine;
using System.Collections;

public class explosion : MonoBehaviour {
	public float tiempoEntreExplosion;
	private float ultimaExplosion;
	// Use this for initialization
	void Start () {
		this.ultimaExplosion = Time.time ;
	}
	
	// Update is called once per frame
	void Update () {
		if (Time.time - this.ultimaExplosion >= this.tiempoEntreExplosion){
			Destroy(this.gameObject);
		}
	}
}