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
		// Debug.Log ("Right foot in position!");
		rightFoot = true;
		renderer.material.color = Color.green;
	}
	
	void OnTriggerExit (Collider other)
	{
		// Debug.Log ("Right foot no longer in position.");
		rightFoot = false;
		renderer.material.color = Color.white;
	}

	public bool isRightFoot ()
	{
		if (rightFoot == true)
			return true;
		else
			return false;
	}
}
