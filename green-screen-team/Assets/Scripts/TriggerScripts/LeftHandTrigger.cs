using UnityEngine;
using System.Collections;

public class LeftHandTrigger : MonoBehaviour 
{
	public bool leftHand = false;

	// Use this for initialization
	void Start () 
	{
		leftHand = false;
	}
	
	// Update is called once per frame
	void Update () 
	{
		
	}
	
	void OnTriggerStay (Collider other)
	{
		if (other.tag == "left_hand")
		{
			leftHand = true;
			renderer.material.color = Color.green;
			// Debug.Log ("Left hand in position!");
		}
	}
	
	void OnTriggerExit (Collider other)
	{
		if (other.tag == "left_hand")
		{
			leftHand = false;
			renderer.material.color = Color.white;
			// Debug.Log ("Left hand no longer in position.");
		}
	}

	public bool isLeftHand ()
	{
		if (leftHand == true)
			return true;
		else
			return false;
	}
}
