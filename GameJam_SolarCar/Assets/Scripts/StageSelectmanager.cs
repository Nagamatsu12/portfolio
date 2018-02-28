using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

//ステージセレクトシーン用スクリプト
public class StageSelectmanager : MonoBehaviour {
	
	public GameObject[] stageButton;

	// Use this for initialization
	void Start () {
		int clearStageNum = PlayerPrefs.GetInt ("ClearStage", 0);　//既にクリアしたステージの数

		//挑戦できるステージのボタンだけ有効化
		for (int i = 0; i < 5; i++) {
			bool b;
			if (clearStageNum < i) {
				b = false;
			} else {
				b = true;
			}
			stageButton [i].GetComponent<Button> ().interactable = b; 
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	//押したボタンのステージを読み込む
	public void PushStageSelectButton(int stageNum){
		SceneManager.LoadScene ("GameScene" + stageNum);
		
	}
}
