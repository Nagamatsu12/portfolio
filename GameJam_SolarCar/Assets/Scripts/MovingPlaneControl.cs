using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//左に動く床用のスクリプト
public class MovingPlaneControl : MonoBehaviour {

	private Rigidbody rb;
	private float move_Speed=2000.0f;
	private float z;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody> ();
		z = transform.position.z;
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		MovePlaneLeft ();
	}

	//床を左に移動させる
	private void MovePlaneLeft(){
		Vector3 moveVec = Vector3.left * move_Speed * Time.deltaTime;
		rb.velocity = moveVec;

		//画面外に出たら再び右からスタート
		if (transform.position.x < -110f) {
			transform.position = new Vector3 (110f, -100f, z);
		}
	}
}
