using UnityEngine;
using System.Collections;

public class triggerTest : MonoBehaviour 
{
	void OnTriggerEnter (Collider other)
	{
		Debug.Log ("You entered the trigger");
	}

	void OnTriggerStay (Collider other)
	{
		Debug.Log ("You are within the trigger");
	}

	void OnTriggerExit (Collider other)
	{
		Debug.Log ("You exited the trigger");
	}
}
