using UnityEngine;
using System.Collections;

public class RightHandTrigger : MonoBehaviour 
{
	public bool rightHand = false;

	// Use this for initialization
	void Start () 
	{
		rightHand = false;	
	}
	
	// Update is called once per frame
	void Update () 
	{
		
	}
	
	void OnTriggerStay (Collider other)
	{
		if (other.tag == "right_hand")
		{
			rightHand = true;
			renderer.material.color = Color.green;
			// Debug.Log ("Right hand in position!");
		}
	}
	
	void OnTriggerExit (Collider other)
	{
		if (other.tag == "right_hand")
		{
			rightHand = false;
			renderer.material.color = Color.white;
			// Debug.Log ("Right hand no longer in position.");
		}
	}

	public bool isRightHand ()
	{
		if (rightHand == true)
			return true;
		else
			return false;
	}
}
