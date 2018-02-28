using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

//ゲームシーン用スクリプト
public class GameManager : MonoBehaviour {

	public int stageNumber;

	public float gravitational_Acceleration; //重力加速度

	public GameObject solarCar;
	public GameObject solarCarPrefab;
	public GameObject spotLight;

	public GameObject retryButton;
	public GameObject exitButton;
	public GameObject nextStageButton;
	public GameObject miniRetryButton;
	public GameObject miniBackButton;

	public GameObject clearText;
	public GameObject gameOverText;

	// Use this for initialization
	void Start () {

		//落下速度を上げて落下の挙動をスピーディーに
		gravitational_Acceleration = -100;
		Physics.gravity = new Vector3 (0, gravitational_Acceleration, 0);

		retryButton.SetActive (false);
		exitButton.SetActive (false);
		nextStageButton.SetActive (false);

		miniRetryButton.SetActive (true);
		miniBackButton.SetActive (true);

		clearText.SetActive (false);
		gameOverText.SetActive (false);

		spotLight.SetActive (true);
			
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void PushRetryButton(){
		SceneManager.LoadScene ("GameScene"+stageNumber);
	}

	public void PushExitButton(){
		SceneManager.LoadScene ("TitleScene");
	}
	public void PushNextStageButton(){
		SceneManager.LoadScene ("GameScene" + (stageNumber+1));
		
	}

	//ゲームオーバー時、Solarcarのスクリプトから呼び出す
	public void GameOver(){
		Destroy (solarCar);
		spotLight.SetActive (false);
		retryButton.SetActive (true);
		exitButton.SetActive (true);
		miniRetryButton.SetActive (false);
		miniBackButton.SetActive (false);
		gameOverText.SetActive (true);
	}
		
	//ゲームクリア時、Solarcarのスクリプトから呼び出す	
	public void StageClear(){
		Destroy (solarCar);

		spotLight.SetActive (false);
		miniRetryButton.SetActive (false);
		miniBackButton.SetActive (false);

		//最終ステージの時はＮＥＸＴボタンを表示しない
		if (stageNumber != 5) {　　　　　　　　　
			nextStageButton.SetActive (true);
		}

		exitButton.SetActive (true);
		clearText.SetActive (true);

		if (PlayerPrefs.GetInt ("ClearStage", 0) < stageNumber) {
			PlayerPrefs.SetInt ("ClearStage", stageNumber);
		}
	}
}
