using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {

	public GameObject player;
	private Vector3 offset;


	// Use this for initialization
	void Start () {
		// 差を取っておく
		offset = this.transform.position - player.transform.position;
	}
	
	// カメラの設定はLateUpdate関数内で行うこと
	void LateUpdate () {
		// 毎フレーム毎に加算
		this.transform.position = player.transform.position + offset;
	}
}
