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
		// Debug.Log ("Left foot in position!");
		leftFoot = true;
		renderer.material.color = Color.green;
	}

	void OnTriggerExit (Collider other)
	{
		// Debug.Log ("Left foot no longer in position.");
		leftFoot = false;
		renderer.material.color = Color.white;
	}

	public bool isLeftFoot ()
	{
		if (leftFoot == true)
			return true;
		else
			return false;
	}
}
