using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class gameOver : MonoBehaviour {
	public Image Fin;

	// Use this for initialization
	void Start () {
		Fin.gameObject.SetActive (false);
	}
	
	// Update is called once per frame
	void Update () {
		if (GameObject.FindGameObjectsWithTag ("player").Length == 0)
			Fin.gameObject.SetActive (true);
	
	}
}
