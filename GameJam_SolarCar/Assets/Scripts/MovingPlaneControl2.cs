using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//左右に動く床用のスクリプト
public class MovingPlaneControl2 : MonoBehaviour {

	private Rigidbody rb;
	private float move_Value=40.0f;　//床が往復する幅
	private float time;
	private Vector3 pos;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody> ();
		time = 0;
		pos = transform.position;//初期位置 誤差修正用
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		MovePlaneBothWays ();
	}

	//床を左右に往復させるように動かす
	private void MovePlaneBothWays(){
		time += Time.deltaTime;
		rb.velocity = new Vector3 ((Mathf.PingPong (time, 2) - 1)*move_Value, 0, 0);
		if (time > 4) {
			time = 0;
			transform.position = pos;//誤差修正　これがないと徐々に左にずれていく
		}
	}
}
