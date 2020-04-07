using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookY : MonoBehaviour {

	// Use this for initialization
	[SerializeField]
	float _sensiivity = 5.0f;

	float _mouseY = 0.0f;
	
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		_mouseY = Input.GetAxis("Mouse Y");
		Vector3 rot = transform.localEulerAngles;
		rot.x -= _mouseY;
		transform.localEulerAngles = rot;
	}
}
