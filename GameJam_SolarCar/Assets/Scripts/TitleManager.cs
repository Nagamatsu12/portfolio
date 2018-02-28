using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

//タイトルシーン用スクリプト
public class TitleManager : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void PushGameStartButton(){
		SceneManager.LoadScene ("StageSelectScene");
	}
	public void PushPracticeButton(){
		SceneManager.LoadScene ("Practice");
	}
}
