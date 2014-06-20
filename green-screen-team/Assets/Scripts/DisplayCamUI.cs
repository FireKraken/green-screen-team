using UnityEngine;
using System.Collections;

public class DisplayCamUI : MonoBehaviour {
	public bool isPosed = false;
	public int seconds = 30;
	private float milliseconds = 1.0f;
	public GUIStyle newStyle;
	public bool canTimer = true;

	public GameObject PlayerOne;
	public Material superSquamby;
	public Material bBoySquamby;

	public HeadTrigger headCheck;
	public LeftHandTrigger leftHandCheck;
	public RightHandTrigger rightHandCheck;
	public LeftFootTrigger leftFootCheck;
	public RightFootTrigger rightFootCheck;

	// Use this for initialization
	void Start () 
	{
		isPosed = false;
		newStyle.fontSize = Screen.width / 25;
		if (Application.loadedLevel == 0)
		{
			canTimer = false;
		}
	}
	
	// Update is called once per frame
	void Update ()
	{

		if (headCheck.isHead () && leftHandCheck.isLeftHand() && rightHandCheck.isRightHand () && leftFootCheck.isLeftFoot () && rightFootCheck.isRightFoot ())
		{
			isPosed = true;
		}

		else
		{
			isPosed = false;
		}


		if (isPosed == true)
		{
			StartCoroutine ("loadNextLevel");
		}

		//timer
		if (canTimer == true)
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

	IEnumerator loadNextLevel ()
	{
		canTimer = false;
		if (Application.loadedLevel == 1)
		{
			PlayerOne.renderer.material = superSquamby;
			yield return new WaitForSeconds (3);
			Application.LoadLevel (2);
		}
		else if (Application.loadedLevel == 2)
		{
			PlayerOne.renderer.material = bBoySquamby;
			yield return new WaitForSeconds (3);
			Application.LoadLevel (4);
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