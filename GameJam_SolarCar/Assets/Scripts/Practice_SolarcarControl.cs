﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

//プラクティス用のSolarcarスクリプト
public class Practice_SolarcarControl : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	//画面外に出たらシーンを再読み込み
	void OnTriggerEnter(Collider other){
		if (other.gameObject.tag == "OutArea") {
			SceneManager.LoadScene ("Practice");
		}
	}
}
