using UnityEngine;
using System.Collections;

public class playVideo : MonoBehaviour {
	public MovieTexture movTexture;
	public MovieTexture movTexture2;
	public MovieTexture movTexture3;
	public int chosenVid;
	public GameObject screen;
	public float movTime = 3.0f;

	// Use this for initialization
	void Start () {
		renderer.material.mainTexture = movTexture;
		movTexture.Play ();
	}

	// Update is called once per frame
	void Update () {
		movTime -= Time.deltaTime;
		if (movTime <= 0)
		{
			chosenVid = Random.Range(1, 4);
			movTime = 3.0f;
			//stop old vid
			if (renderer.material.mainTexture == movTexture)
			{
				movTexture.Stop ();
			}
			else if (renderer.material.mainTexture == movTexture2)
			{
				movTexture2.Stop ();
			}
			else if (renderer.material.mainTexture == movTexture3)
			{
				movTexture3.Stop ();
			}
			//set new vid
			if (chosenVid == 1)
			{
				renderer.material.mainTexture = movTexture;
				movTexture.Play ();
			}
			else if (chosenVid == 2)
			{
				renderer.material.mainTexture = movTexture2;
				movTexture2.Play ();
			}
			else if (chosenVid == 3)
			{
				renderer.material.mainTexture = movTexture3;
				movTexture3.Play ();
			}
		}

	}
}
