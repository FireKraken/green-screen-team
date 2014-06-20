using UnityEngine;
using System.Collections;

public class Winscene : MonoBehaviour {
	public float sceneTimer = 5.0f;
	public GUIStyle newStyle;

	// Use this for initialization
	void Start () {

	
	}
	
	// Update is called once per frame
	void Update () {
		sceneTimer -= Time.deltaTime;
		if (sceneTimer <= 0 & Application.loadedLevel == 3)
		{
			Application.LoadLevel(4);
		}
		else if (sceneTimer <= 0 & Application.loadedLevel == 1)
		{
			Application.LoadLevel(2);
		}
		else if (sceneTimer <= 0 & Application.loadedLevel == 5)
		{
			Application.LoadLevel(0);
		}

	}

	void OnGUI (){

		if (Application.loadedLevel == 1)
		{
		GUILayout.BeginArea (new Rect (Screen.width*(2/3), Screen.height * 0.90f, Screen.width/3, 100));

		GUILayout.Label ("Loading...", newStyle);
				
		GUILayout.EndArea ();
		}
	}
}
