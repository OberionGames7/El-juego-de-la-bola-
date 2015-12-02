using UnityEngine;
using System.Collections;

public class animacionDeScript : MonoBehaviour {
	public float framesPorSegundo;
	public Sprite [ ] sprites;
	private SpriteRenderer sr;

	// Use this for initialization
	void Start () {
		this.sr = GetComponent<Renderer>() as SpriteRenderer;
	}
	
	// Update is called once per frame
	void Update () {
		int index = (int) (Time.time * framesPorSegundo);
		index = index % sprites.Length;
		sr.sprite =sprites [index];
	}
}
