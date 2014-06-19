using UnityEngine;
using System.Collections;

public class LivesLeft : MonoBehaviour {
	public GameObject battery;
	public Sprite batfull;
	public Sprite batmid;
	public Sprite batlow;
	public int batnum;


	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		batnum = setLives.lives;
		if (batnum == 3)
		{
			battery.GetComponent<SpriteRenderer>().sprite = batfull;
		}
		else if (batnum == 2)
		{
			battery.GetComponent<SpriteRenderer>().sprite = batmid;
		}
		else if (batnum == 1)
		{
			battery.GetComponent<SpriteRenderer>().sprite = batlow;
		}
	
		//end game on 0 lives
		if (batnum == 0)
		{
			Application.LoadLevel(0);
		}
	}
}
