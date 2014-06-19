using UnityEngine;
using System.Collections;

public class LivesLeft : MonoBehaviour {
	public int lives = 3;
	public GameObject battery;
	public Sprite batfull;
	public Sprite batmid;
	public Sprite batlow;
	public static LivesLeft Instance;

	void Awake() {
		DontDestroyOnLoad(battery);
		DontDestroyOnLoad (this);
		
		if (FindObjectsOfType(GetType()).Length > 1)
		{
			Destroy(gameObject);
		}
	}

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		if (lives == 3)
		{
			battery.GetComponent<SpriteRenderer>().sprite = batfull;
		}
		else if (lives == 2)
		{
			battery.GetComponent<SpriteRenderer>().sprite = batmid;
		}
		else if (lives == 1)
		{
			battery.GetComponent<SpriteRenderer>().sprite = batlow;
		}
	
		//end game on 0 lives
		if (lives == 0)
		{
			lives = 3;
			Application.LoadLevel(0);
		}
	}
}
