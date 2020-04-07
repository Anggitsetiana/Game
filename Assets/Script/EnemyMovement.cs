using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour {

	// Use this for initialization
	CharacterController _controller;
	Transform _player;
	
	[SerializeField]
	float _moveSpeed = 5.0f;
	
	void Start () {
		GameObject playerObject = GameObject.FindGameObjectWithTag("Player");
		_player = playerObject.transform;
		_controller = GetComponent<CharacterController>();
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 direction = _player.position - transform.position;
		direction.Normalize();
		Vector3 velocity = direction * _moveSpeed;
		_controller.Move (velocity * Time.deltaTime);
	}
}
