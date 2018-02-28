using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//ライト用スクリプト	
public class SpotLightControl : MonoBehaviour {

	public GameObject solarCar;

	private float windowSize_x=650f;
	private float windowSize_y=400f;
	private float zoom=3.5f; //ウィンドウサイズ(650x400)をステージのサイズ（186x114?）に調整するために使う

	private float move_Power=8000.0f;
	private float rotation_speed=10.0f;

	// Use this for initialization
	void Start () {

		}
	
	// Update is called once per frame
	void Update () {
		float x = Input.mousePosition.x;
		float y = Input.mousePosition.y;
		SpotLightMove (x, y);

		}

	void OnTriggerStay(Collider other){
		//光が左右のパネルに当たっていたらSolarcarを回転させる
		float v;
		if (other.gameObject.tag == "RightPanel") {
			v = -1.0f;
		} else if (other.gameObject.tag == "LeftPanel") {
			v = 1.0f;
		} else {
			v = 0.0f;
		}
		CarRotation (v * rotation_speed*Time.deltaTime);

		//光が真ん中のパネルに当たっていたらSolarcarを進まる
		if (other.gameObject.tag == "CentralPanel") {
			float currentCarAngle =solarCar.transform.eulerAngles.y * Mathf.PI / 180.0f;　//Solarcarの現在の角度を取得
			Vector3 currentCarVec = new Vector3 (Mathf.Sin (currentCarAngle), 0, Mathf.Cos (currentCarAngle));　//ベクトルに変換
			solarCar.GetComponent<Rigidbody> ().AddForce (currentCarVec*move_Power*Time.deltaTime);
		}
	}

	//光が左右のパネルに当たっていた時に呼び出されるメソッド
	void CarRotation(float rotate_direction){
		solarCar.transform.Rotate (0, rotate_direction* rotation_speed, 0);
	}

	//マウスの位置座標をゲーム内の座標に変換する
	void SpotLightMove(float mousepos_x,float mousepos_y){
		float x = (mousepos_x-windowSize_x/2)/zoom;
		float y = transform.position.y;
		float z = (mousepos_y-windowSize_y/2)/zoom;
		transform.position = new Vector3 (x, y, z);
	}
}

	
		
