//UM Games 2016
using UnityEngine;
using System.Collections;

//Script que detecta las collisiones de la pelota. Se podria volver public a "ball_state" que usa un tag parar encontrar el rigidbody de la pelota.
//Tambien cambia el respawn de joey.

public class CollisionBall : MonoBehaviour {
	private Rigidbody ball_state;
	public GameObject respawn_spot_one, respawn_spot_two, respawn_spot_three;
	public Stage stage_script_for_coll;
	public LevelWon level_won_script;
	public RestartLevel restart_level_script;

	void Start (){
		ball_state = GameObject.FindGameObjectWithTag ("BallBaseJoey").GetComponent<Rigidbody> ();
	}

	void OnCollisionEnter (Collision ball_col) {
		
		if (Stage.GetStage() == 1) {
			if (ball_col.gameObject.name == "Barrier") {
				ball_state.transform.position = respawn_spot_one.transform.position;
				ball_state.isKinematic = true;
				stage_script_for_coll.ResetButtonStage ();
			}
		}
			

		if (Stage.GetStage() == 3) {
			if (ball_col.gameObject.name == "Barrier" || ball_col.gameObject.name == "TriggerTwo") {
				ball_state.transform.position = respawn_spot_two.transform.position;
				ball_state.isKinematic = true;
				stage_script_for_coll.ResetButtonStage ();
			}
				
		}

		if (Stage.GetStage() == 4) {
			if (ball_col.gameObject.name == "TriggerTwo" || ball_col.gameObject.name == "Barrier") {
				restart_level_script.restart ();
			}

		}

	}

	void OnTriggerEnter (Collider ball_triggr){
		if (ball_triggr.gameObject.name == "WinZone") level_won_script.ShowLabel ();

		if (Stage.GetStage() == 1) {

			if (ball_triggr.gameObject.name == "TriggerZero") {
				ball_state.transform.position = respawn_spot_two.transform.position;
				ball_state.isKinematic = true;
				stage_script_for_coll.ShootButtonStage ();
			}

			if (ball_triggr.gameObject.name == "TriggerThree") {
				ball_state.transform.position = respawn_spot_three.transform.position;
				ball_state.isKinematic = false;
				stage_script_for_coll.stage = 4;
			}

		}

		if (Stage.GetStage() == 3) {

			if (ball_triggr.gameObject.name == "TriggerOne") {
				stage_script_for_coll.ShootButtonStage ();
			}

			if (ball_triggr.gameObject.name == "TriggerZero") {
				ball_state.transform.position = respawn_spot_two.transform.position;
				ball_state.isKinematic = true;
				stage_script_for_coll.ResetButtonStage ();
			}

		}

		if (Stage.GetStage() == 4){
			if (ball_triggr.gameObject.name == "TriggerDeadMansHand") {
				restart_level_script.restart ();
			}
		}

	}

}
