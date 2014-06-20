using UnityEngine;
using System.Collections;

public class LeftFootTrigger : MonoBehaviour 
{
	public bool leftFoot = false;

	// Use this for initialization
	void Start () 
	{
		leftFoot = false;
	}
	
	// Update is called once per frame
	void Update () 
	{
	
	}

	void OnTriggerStay (Collider other)
	{
		if (other.tag == "left_foot")
		{
			leftFoot = true;
			renderer.material.color = Color.green;
			// Debug.Log ("Left foot in position!");
		}
	}

	void OnTriggerExit (Collider other)
	{
		if (other.tag == "left_foot")
		{
			leftFoot = false;
			renderer.material.color = Color.white;
		}
		// Debug.Log ("Left foot no longer in position.");
	}

	public bool isLeftFoot ()
	{
		if (leftFoot == true)
			return true;
		else
			return false;
	}
}
