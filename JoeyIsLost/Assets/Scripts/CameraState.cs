//UM Games 2016
//Clase que admistra las camaras y que cosas hacen segun el momento del juego.

using UnityEngine;
using System.Collections;

public class CameraState : MonoBehaviour {

	private GameObject go_object_ball;
	private Rigidbody rb_object_ball;
	public Transform trnsfrm_ball;
	public Camera cam_1, cam_2, cam_3;
	private Vector3 offset;

	void Start () {

		cam_1.enabled = true;
		cam_2.enabled = false;
		cam_3.enabled = false;

		if (go_object_ball == null && rb_object_ball == null) {
			go_object_ball = GameObject.FindGameObjectWithTag ("BallBaseJoey");
			rb_object_ball = go_object_ball.GetComponent<Rigidbody>();
		}
		offset = transform.position - go_object_ball.transform.position;

	}

	void Update () {

		if ( Stage.GetStage() == 0) {
			cam_1.enabled = true;
			cam_2.enabled = false;
			cam_3.enabled = false;

		}

		if ( Stage.GetStage() == 2){
			cam_1.enabled = false;
			cam_2.enabled = true;
			cam_3.enabled = false;
		}

		if ( Stage.GetStage() == 4) {
			cam_1.enabled = false;
			cam_2.enabled = false;
			cam_3.enabled = true;

		}

		//IMPORTANTE: Si no se deshabilitan todas las camaras en cada momento que sea necesario ocurre un error de renderizado.

	}

	void LateUpdate(){

		if (Stage.GetStage() == 0 || Stage.GetStage() == 1 ){
			cam_1.transform.position = go_object_ball.transform.position + offset;
		}

		if (Stage.GetStage() == 2 || Stage.GetStage() == 3){
			cam_2.transform.LookAt (trnsfrm_ball);
		}

		if (Stage.GetStage () == 4) {
			cam_3.transform.position = go_object_ball.transform.position + offset;
		}

	}
}
