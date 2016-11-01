//UM Games 2016
using UnityEngine;
using System.Collections;

public class Slingshot : Launcher{

	void Start () {
		ball_force_x = 2;
		ball_force_y = 3;
		ball_force_z = 0;
        forceAdded_x = 3;
        forceAdded_y = 3;
        xForceMin = 2;
        yForceMin = 3;
        zForceMin = 0;
	}
    	

	public void ShootSlingShot(){
       
		forceChargeOnClick ();
		if (ball_state_check == true) {
			if (ball_force_x > xForceMin || yForceMin > 3) {
				resetForce();
			}
		}
	}
}
