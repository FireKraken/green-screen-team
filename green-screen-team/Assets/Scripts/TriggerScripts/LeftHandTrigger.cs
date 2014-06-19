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
		Debug.Log ("Left hand in position!");
		leftHand = true;
		renderer.material.color = Color.green;
	}
	
	void OnTriggerExit (Collider other)
	{
		Debug.Log ("Left hand no longer in position.");
		leftHand = false;
		renderer.material.color = Color.white;
	}
}
