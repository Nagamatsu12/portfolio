using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Practice_GameManager : MonoBehaviour {
	public float gravitational_Acceleration; //重力加速度

	public GameObject solarCar;
	public GameObject spotLight;

	public GameObject miniBackButton;



	// Use this for initialization
	void Start () {
		//落下速度を上げて落下の挙動をスピーディーに
		gravitational_Acceleration = -100;
		Physics.gravity = new Vector3 (0, gravitational_Acceleration, 0);


		miniBackButton.SetActive (true);

		spotLight.SetActive (true);
	}
	
	// Update is called once per frame
	void Update () {
	}

	public void PushExitButton(){
		SceneManager.LoadScene ("TitleScene");
	}
		

}
