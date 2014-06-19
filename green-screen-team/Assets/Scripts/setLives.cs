using UnityEngine;
using System.Collections;

public class setLives : MonoBehaviour {
	public static int lives = 3;
	public Texture2D buttonImage = null;
	public string title = string.Empty;
	Rect position = new Rect(Screen.width/2 - Screen.width * 0.1f, Screen.height/2 - Screen.height * 0.05f, Screen.width * 0.2f, Screen.height * 0.12f);

	public GUISkin skin = null;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnGUI (){
		GUI.skin = skin;
		if (GUI.Button(position, title))
		{
			Application.LoadLevel(1);
		}

	}

}
