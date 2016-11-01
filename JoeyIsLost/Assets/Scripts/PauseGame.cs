//UM Games 2016
using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class PauseGame : MonoBehaviour {
    public Transform pause_btn;
	public Transform unpause_btn;
	public Transform shoot_btn;
	public GameObject mov_btns;
	
//	void Update () {
//
//        if (Input.GetKeyDown(KeyCode.Escape))
//        {
//           
//            pause();
//        }
//       
//	}

    public void pause(){
		pause_btn.gameObject.SetActive (false);
		unpause_btn.gameObject.SetActive (true);
		shoot_btn.gameObject.SetActive (false);
		mov_btns.gameObject.SetActive (false);
        Time.timeScale = 0;
    }

	public void unpause(){
		pause_btn.gameObject.SetActive (true);
		unpause_btn.gameObject.SetActive(false);
		Time.timeScale = 1;
	}
} 