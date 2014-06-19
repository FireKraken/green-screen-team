using UnityEngine;
using System.Collections;

public class playVideo : MonoBehaviour {
	public MovieTexture movTexture;

	// Use this for initialization
	void Start () {
		renderer.material.mainTexture = movTexture;
		movTexture.loop = true;
		movTexture.Play ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
