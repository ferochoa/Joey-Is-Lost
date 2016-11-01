//UM Games 2016
using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class LevelWon : MonoBehaviour {
    public Text youWon;
	public GameObject you_won_btn_pause;
	public GameObject you_won_btn_unpause;
	public GameObject you_won_btn_mov_group;

	void Start () {
		youWon.text = "";
	
	}

    public void ShowLabel()
    {
        youWon.text = "Has Ganado";
		you_won_btn_pause.gameObject.SetActive (false);
		you_won_btn_unpause.gameObject.SetActive (false);
		you_won_btn_mov_group.gameObject.SetActive (false);
        Time.timeScale = 0;
    }
}
