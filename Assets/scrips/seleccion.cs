using UnityEngine;
using System.Collections;

public class seleccion : MonoBehaviour {
	public LayerMask capa;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		Ray rayo = Camera.main.ScreenPointToRay(Input.mousePosition);
		RaycastHit hit;
		if (Physics.Raycast (rayo, out hit, Mathf.Infinity, this.capa)){
			if (hit.transform.tag == "jugar") {
				Application.LoadLevel (PlayerPrefs.GetString ("nivel"));
			}
		}
	}
}
