//UM Games 2016

using UnityEngine;
using System.Collections;

public class Stage : MonoBehaviour {


	//Clase que guarda en un contador los momentos del juego. GetStage es statico para ahorrar en codigo y que se vea mas claro algunos controles logicos.

	//REFERENCIA: 0 Primer tiro, 1 Pelota sale en movimiento, 
	//	2 Pelota va al segundo spawn para el segundo tiro con spring, 
	//	3 Movimiento 
	//	4 Ultimos movimientos de la pelota en el segundo disparo
	//  5 Fin

	public int stage = 0;
	static int stage_static;

	void Start (){
		stage_static = stage;
	}

	void Update (){
		stage_static = stage;
	}

	public void ShootButtonStage (){
		stage += 1;
	}

	public void ResetButtonStage(){
		stage -= 1;
	}

	public static int GetStage (){
		return stage_static;
	}

}
