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
		// Debug.Log ("Right hand in position!");
		rightHand = true;
		renderer.material.color = Color.green;
	}
	
	void OnTriggerExit (Collider other)
	{
		// Debug.Log ("Right hand no longer in position.");
		rightHand = false;
		renderer.material.color = Color.white;
	}

	public bool isRightHand ()
	{
		if (rightHand == true)
			return true;
		else
			return false;
	}
}
