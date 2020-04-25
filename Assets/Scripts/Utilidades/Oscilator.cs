using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Oscilator : MonoBehaviour {

	public float oscilationFactor = 0.1f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		this.transform.position = new Vector3(this.transform.position.x, this.transform.position.y + ((Vector3.up * Mathf.Cos(Time.time*2.0f)).y * oscilationFactor),this.transform.position.z);
	}
}
