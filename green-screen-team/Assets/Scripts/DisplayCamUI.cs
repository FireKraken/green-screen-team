using UnityEngine;
using System.Collections;

public class DisplayCamUI : MonoBehaviour {
	public bool isPosed = false;
	public GameObject Lens;

	// Use this for initialization
	void Start () 
	{
		isPosed = false;
	}
	
	// Update is called once per frame
	void Update ()
	{

		if (isPosed == true)
		{
			Lens.GetComponent<SpriteRenderer>().enabled = true;
		}
		else if (isPosed == false)
		{
			Lens.GetComponent<SpriteRenderer>().enabled = false;
		}
		else
		{
			Lens.GetComponent <SpriteRenderer> ().enabled = false;
		}
	}
}