//UM Games 2016
using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PowerBar : MonoBehaviour {

	private float div_power = 5f;
	public float full_power = 10f;
	public float bar_fill = 80f;
	private float power_charge = 0f;
	public bool increasing = false;
	public RectTransform bar;

	public void ChargeBar (){

		if (Input.GetButton ("Fire1")) {
			if (power_charge < full_power) {
				power_charge += bar_fill * Time.deltaTime;
			}
		}

		bar.GetComponent<Image> ().fillAmount = power_charge / div_power;
	}

	public void Clear (){
		power_charge = 0;
		bar.GetComponent<Image> ().fillAmount = 0;

	}
}
