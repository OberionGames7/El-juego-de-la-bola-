
using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class puntuacion : MonoBehaviour {
	private int score = 0;
	public Text puntos;

	// Use this for initialization
	void Start () {
		score = 0;
		puntos.text = "Score: " + score;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnCollisionStay2D (Collision2D other){
		if (other.gameObject.tag == "plataforma") {
			score = score +1;
			puntos.text = "Score: " + score;
		}

	}
}
