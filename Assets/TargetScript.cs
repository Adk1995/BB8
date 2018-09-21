using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetScript : MonoBehaviour {
	public Score scoreManager;
	private void OnCollisionEnter(Collision collision)
	{
		scoreManager.AddPoint ();
		Debug.Log ("Collision Detected");
		Destroy (gameObject);
	}
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
