//UM Games 2016
using UnityEngine;
using System.Collections;

public class TableControl : MonoBehaviour {
	//Esto rota el tablero en algun eje, segun que metodo se llame.
	//Falta que el movimiento sea fijo, es decir que siempre se mueva a cierto grado. Ej 90 Grados.
	//Falta que segun la rotacion del tablero se mantenga "leal" al movimiento que haga el usuario.
	//REFERENCIA: left (-1,0,0), right (1,0,0), up (0,1,0), down (0,-1,0), foward (0,0,1), back (0,0,-1)

	public Transform play_cube;

	public void MovRight (){
		if (Input.GetButton ("Fire1")) {
			play_cube.transform.Rotate (Vector3.right * 2);
		}
	}

	public void MovLeft (){
		if (Input.GetButton ("Fire1")) {
			play_cube.transform.Rotate (Vector3.left * 2);
		}
	}

	public void MovUp (){
		if (Input.GetButton ("Fire1")) {
			play_cube.transform.Rotate (Vector3.up * 2);
		}
	}

	public void MovDown (){
		if (Input.GetButton ("Fire1")) {
			play_cube.transform.Rotate (Vector3.down * 2);
		}
	}

	public void MovFowd (){
		if (Input.GetButton ("Fire1")) {
			play_cube.transform.Rotate (Vector3.forward * 4);
		}
	}

	public void MovBack (){
		if (Input.GetButton ("Fire1")) {
			play_cube.transform.Rotate (Vector3.back * 4);
		}
	
	}

}
