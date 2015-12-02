using UnityEngine;
using System.Collections;

public class cargar : MonoBehaviour {

	// Use this for initialization
	void Start () {
		// Pone el Nivel a 0.
		// por si quiero volver a jugar el juego desde el principio
		// PlayerPrefs.SetInt("Nivel", 0);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	/*esto es para que cuando el valor de nivel valga 0 pues que sea 1, y que coja el archivo de guardado 
	 * que en el GetInt ("Nivel")*/
	public void cargarNivel() {
		int nivel = PlayerPrefs.GetInt("Nivel");
		if (nivel == 0) {
			nivel = 1;
			PlayerPrefs.SetInt("Nivel", 1);
		} 
		Application.LoadLevel(nivel);
	}
	public void salir(){
		Application.Quit();
	}
	public void creditos(){
		Application.LoadLevel("creditos");
	}
}
