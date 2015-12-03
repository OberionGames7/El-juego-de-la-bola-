using UnityEngine;
using System.Collections;

public class AgujeroNegroParte2 : MonoBehaviour {
	public GameObject objeto;



	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (GameObject.FindGameObjectsWithTag ("player").Length == 0) {
			Instantiate (objeto, this.transform.position, this.transform.rotation);
		

		}
	}
}
