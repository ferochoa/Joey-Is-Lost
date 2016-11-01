//UM Games 2016
using UnityEngine;
using System.Collections;

public class SimpleEvents : MonoBehaviour {

//Esta hecho para simplificar a el componente event trigger de el boton de disparo o futuros botones.

	public Stage stage_for_custom_event;
	public Slingshot custom_event_slingshot_trigger;
	public Spring custom_event_spring_trigger;
	public PowerBar custom_event_power_bar_trigger;

	public void ClickUp (){
		if (Stage.GetStage() == 0) {
			custom_event_slingshot_trigger.ForceAddOnClick ();
			custom_event_power_bar_trigger.enabled = false;
			custom_event_power_bar_trigger.Clear ();
			stage_for_custom_event.ShootButtonStage ();
		}
		if (Stage.GetStage() == 2) {
			custom_event_spring_trigger.RevertedForceAddOnClick ();
			custom_event_power_bar_trigger.enabled = false;
			custom_event_power_bar_trigger.Clear ();
			stage_for_custom_event.ShootButtonStage ();
		}

		custom_event_spring_trigger.resetForce ();
		custom_event_slingshot_trigger.resetForce ();

	}

	public void ClickDown (){
		if (Stage.GetStage() == 0) {
			custom_event_slingshot_trigger.SetCheck ();
//			custom_event_power_bar_trigger.enabled = true;
			custom_event_slingshot_trigger.ShootSlingShot ();
		}

		if (Stage.GetStage() == 2) {
			custom_event_spring_trigger.SetCheck ();
//			custom_event_power_bar_trigger.enabled = true;
			custom_event_spring_trigger.ShootSpring ();
		}
	}
}
