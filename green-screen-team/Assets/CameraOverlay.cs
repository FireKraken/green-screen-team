using UnityEngine;
using System.Collections;

public class CameraOverlay : MonoBehaviour {
	public bool isRec ;
	// Use this for initialization
	void Start () {
		var isRec = false;
	}
	
	// Update is called once per frame
	void Update () {
		if (isRec = false)
		{
			GameObject.Find("Lens").GetComponent<SpriteRenderer>().enabled = false;
		}
		else
		{
			GameObject.Find("Lens").GetComponent<SpriteRenderer>().enabled = true;
		}
	}
}
