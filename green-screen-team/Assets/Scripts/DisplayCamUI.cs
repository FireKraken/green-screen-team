using UnityEngine;
using System.Collections;

public class DisplayCamUI : MonoBehaviour {
	public bool isPosed = false;
	public GameObject Lens;
	public int seconds = 30;
	private float milliseconds = 1.0f;
	public GUIStyle newStyle;
	public bool cantimer = true;

	// Use this for initialization
	void Start () 
	{
		isPosed = false;
		newStyle.fontSize = Screen.width / 25;
		if (Application.loadedLevel == 0)
		{
			cantimer = false;
		}
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

		//timer
		if (cantimer = true)
		{
			milliseconds -= Time.deltaTime;
		}
		if (milliseconds < 0)
		{
			seconds -= 1;
			milliseconds = 1f;
		}

		if (seconds == 0)
		{
			levelOver ();
		}
	}

	void levelOver ()
	{
		setLives.lives -= 1;
		if (Application.loadedLevel == 1)
		{
			Application.LoadLevel (2);
		}
	}

	void OnGUI ()
	{

		GUILayout.BeginArea (new Rect (0, Screen.height * 0.93f, Screen.width, 100));

		if (seconds >= 10)
		{
			GUILayout.Label ("00:" + seconds, newStyle);
		}
		else if (seconds < 10)
		{
			GUILayout.Label ("00:0" + seconds, newStyle);
		}

		GUILayout.EndArea ();
	}
}