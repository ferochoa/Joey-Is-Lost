//UM Games 2016
using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class LevelSelect : MonoBehaviour {

	public void StartGame(){
		Time.timeScale = 1;
		SceneManager.LoadScene("SceneTest02");
	}

	public void LevelOne(){
	
		Time.timeScale = 1;
		SceneManager.LoadScene("SceneTestLevel01");

	}

}
