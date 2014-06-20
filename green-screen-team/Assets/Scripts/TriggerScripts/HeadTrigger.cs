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
		if (other.tag == "head")
		{
			head = true;
			renderer.material.color = Color.green;
			// Debug.Log ("Head in position!");
		}
	}
	
	void OnTriggerExit (Collider other)
	{
		if (other.tag == "head")
		{
			head = false;
			renderer.material.color = Color.white;
			// Debug.Log ("Head no longer in position.");
		}
	}

	public bool isHead ()
	{
		if (head == true)
			return true;
		else
			return false;
	}
}
