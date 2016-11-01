//UM Games 2016
using UnityEngine;
using System.Collections;

public abstract class Launcher : MonoBehaviour {

	public GameObject gameobj_ball_in_launcher;
	public Rigidbody rigidbdy_ball_in_launcher;
	public float ball_force_x, ball_force_y, ball_force_z, accum_force_x, accum_force_y, accum_force_z;
    public float forceAdded_x;
    public float forceAdded_y;
    public float forceAdded_z;
    public float xForceMin;
    public float yForceMin;
    public float zForceMin;
	protected bool ball_state_check;
	public Vector3 ball_force_vector;

	public void SetCheck(){
		ball_state_check = false;
	}

	public void ForceAddOnClick(){
		if (ball_state_check == false) {
			rigidbdy_ball_in_launcher.isKinematic = false;
			ball_force_vector = new Vector3 (ball_force_x, ball_force_y, ball_force_z);
			rigidbdy_ball_in_launcher.AddForce (ball_force_vector);
			ball_state_check = true;
		}
	}

	public void RevertedForceAddOnClick(){
		if (ball_state_check == false) {
			rigidbdy_ball_in_launcher.isKinematic = false;
			ball_force_vector = new Vector3 (ball_force_x*-1, ball_force_y*-1, ball_force_z*-1);
			rigidbdy_ball_in_launcher.AddForce (ball_force_vector);
			ball_state_check = true;
		}
	}

    public void forceChargeOnClick()
    {
        if (Input.GetMouseButton(0))
        {
            ball_force_x += forceAdded_x;
            ball_force_y += forceAdded_y;
        }
    }
    public void resetForce()
    {
        ball_force_x = xForceMin;
        ball_force_y = yForceMin;
        ball_force_z = zForceMin;
    }

}
