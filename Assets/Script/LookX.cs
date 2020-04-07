using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookX : MonoBehaviour {

	// Use this for initialization
	[SerializeField]
	float _mouseX = 0.0f;
	
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		_mouseX = Input.GetAxis("Mouse X");
		Vector3 rot = transform.localEulerAngles;
		rot.y += _mouseX;
		transform.localEulerAngles = rot;
	}
}
