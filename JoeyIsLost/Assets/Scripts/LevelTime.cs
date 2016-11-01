//UM Games 2016
using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelTime : MonoBehaviour {

    public float time;
    public float maxTime = 120f;
    public Text timerText;
	void Start () {

        time = maxTime;
	}
	
	
	void Update () {

        time -= Time.deltaTime;
        string seconds = time.ToString("f0");
        timerText.text =  seconds;
        if(time <= 0.0f)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
	
	}
}
