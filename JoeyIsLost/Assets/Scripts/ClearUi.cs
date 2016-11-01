//UM Games 2016
using UnityEngine;
using UnityEngine.UI;
using System.Collections;

//Clase para ocultar todo el ui.

public class ClearUi : MonoBehaviour {

	public GameObject gameobj_btn_shoot;
	public GameObject gameobj_btn_mov_group;
	public RectTransform bar_clearpow;
	public bool btn_shoot_enable = true;
	public bool btn_mov_group_enable = false;


	void Start(){
		bar_clearpow.GetComponent<Image> ().fillAmount = 0;
	}
		
	void Update () {
		if ( Stage.GetStage() == 0 || Stage.GetStage() == 2)
			btn_mov_group_enable = false;
			btn_shoot_enable = true;
		if ( Stage.GetStage() == 1)
			btn_shoot_enable = false;
		if ( Stage.GetStage() == 3) {
			btn_shoot_enable = false;
		}
		if ( Stage.GetStage() == 4) {
			btn_shoot_enable = false;
			btn_mov_group_enable = true;
		}
		if ( Stage.GetStage() == 5) {
			btn_shoot_enable = false;
			btn_mov_group_enable = false;
		}

		if (btn_shoot_enable == true) {
			gameobj_btn_shoot.gameObject.SetActive (true);
			if (Time.timeScale.Equals (0)) {
				gameobj_btn_shoot.gameObject.SetActive (false);
			}
		}

		if (btn_shoot_enable == false) {
			gameobj_btn_shoot.gameObject.SetActive(false);
		}

		if (btn_mov_group_enable == true) {
			gameobj_btn_mov_group.gameObject.SetActive (true);
			if (Time.timeScale.Equals (0)) {
				gameobj_btn_mov_group.gameObject.SetActive (false);
			}
		}

		if (btn_mov_group_enable == false) {
			gameobj_btn_mov_group.gameObject.SetActive(false);
		}

	}

}
