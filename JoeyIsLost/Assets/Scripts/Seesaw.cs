//UM Games 2016
using UnityEngine;
using System.Collections;

public class Seesaw : Launcher{

	void Start () {
		ball_force_x = 1;
		ball_force_y = 10;
		ball_force_z = 0;
        forceAdded_x = 1.5f;
        forceAdded_y = 10;
        xForceMin = 1;
        yForceMin = 10;
        zForceMin = 0;
	}


	public void ShotSeesaw (){

		forceChargeOnClick ();
		if (ball_state_check == true) {
			if (ball_force_x > xForceMin || yForceMin > 10) {
				resetForce();
			}
		}
	}
}
