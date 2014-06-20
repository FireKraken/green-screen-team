using UnityEngine;
using System.Collections;

public class RightFootTrigger : MonoBehaviour 
{
	public bool rightFoot = false;
	
	// Use this for initialization
	void Start () 
	{
		rightFoot = false;
	}
	
	// Update is called once per frame
	void Update () 
	{
		
	}
	
	void OnTriggerStay (Collider other)
	{
		if (other.tag == "right_foot")
		{
			rightFoot = true;
			renderer.material.color = Color.green;
			// Debug.Log ("Right foot in position!");
		}
	}
	
	void OnTriggerExit (Collider other)
	{
		if (other.tag == "right_foot")
		{
			rightFoot = false;
			renderer.material.color = Color.white;
			// Debug.Log ("Right foot no longer in position.");
		}
	}

	public bool isRightFoot ()
	{
		if (rightFoot == true)
			return true;
		else
			return false;
	}
}
