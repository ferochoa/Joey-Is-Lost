//UM Games 2016
using UnityEngine;
using System.Collections;

public class Spring : Launcher{

	void Start () {
		ball_force_x = 10;
		ball_force_y = 0;
		ball_force_z = 0;
        forceAdded_x = 10;
        forceAdded_y = 0;
        xForceMin = 10;
        yForceMin = 0;
        zForceMin = 0;
	}


	public void ShootSpring (){

		forceChargeOnClick ();
		if (ball_state_check == true) {
			if (ball_force_x > xForceMin || yForceMin > 10) {
				resetForce();
			}
		}
	}
}
