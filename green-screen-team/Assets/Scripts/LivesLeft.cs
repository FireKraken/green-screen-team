using UnityEngine;
using System.Collections;

public class LivesLeft : MonoBehaviour {
	public int lives = 3;
	public GameObject battery;
	public Sprite batfull;
	public Sprite batmid;
	public Sprite batlow;

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
			
	}
}
