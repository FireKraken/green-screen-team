using UnityEngine;
using System.Collections;

public class HeadTrigger : MonoBehaviour 
{
	public bool head = false;

	// Use this for initialization
	void Start () 
	{
		head = false;
	}
	
	// Update is called once per frame
	void Update () 
	{
		
	}
	
	void OnTriggerStay (Collider other)
	{
		// Debug.Log ("Head in position!");
		head = true;
		renderer.material.color = Color.green;
	}
	
	void OnTriggerExit (Collider other)
	{
		// Debug.Log ("Head no longer in position.");
		head = false;
		renderer.material.color = Color.white;
	}

	public bool isHead ()
	{
		if (head == true)
			return true;
		else
			return false;
	}
}
