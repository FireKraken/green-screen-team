using UnityEngine;
using System.Collections;

public class RecFlash : MonoBehaviour {
	public bool isActive = false;
	public bool lightOn = true;
	public float timer = 0.5f;
	public GameObject rec;
	public int heldTimes = 0;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		GameObject Lens = GameObject.Find ("Lens");
		var lensActive = Lens.GetComponent<DisplayCamUI>();
		isActive = lensActive.isPosed;
		if (isActive == true) 
		{
			timer -= Time.deltaTime;
		}
		else if (isActive == false)
		{
			timer = 0.5f;
			rec.GetComponent<SpriteRenderer>().enabled = false;
			heldTimes = 0;
		}

		if (timer <= 0 & lightOn == true & isActive == true)
		{
			rec.GetComponent<SpriteRenderer>().enabled = false;
			lightOn = false;
			timer = 0.5f;
		}
		else if (timer <= 0 & lightOn == false & isActive == true)
		{
			rec.GetComponent<SpriteRenderer>().enabled = true;
			lightOn = true;
			timer = 0.5f;
			heldTimes += 1;
		}
	
	}
}
