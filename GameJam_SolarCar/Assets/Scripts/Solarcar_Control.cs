using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Solarcar用スクリプト
public class Solarcar_Control : MonoBehaviour {


	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {


	}
		
	void OnTriggerEnter(Collider other){
		
		//ゲームシーン用のスクリプトからクリアメソッドやゲームオーバーメソッドを呼び出す
		GameObject gameManager = GameObject.Find ("GameManager");
		if (other.gameObject.tag == "OutArea") {
			gameManager.GetComponent<GameManager> ().GameOver ();
		}else if (other.gameObject.tag == "Goal") {
			gameManager.GetComponent<GameManager> ().StageClear ();
		}
	}

	
		
}
