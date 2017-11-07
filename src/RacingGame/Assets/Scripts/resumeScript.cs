using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class resumeScript : MonoBehaviour {
	public Button Resume;
	public Button Restart;
	public Button Quit;
	public GameObject panelOfZaGame;


	// Use this for initialization
	void Start () {
		Resume.GetComponent<Button>().onClick.AddListener(ResumeZaGame);
		Restart.GetComponent<Button>().onClick.AddListener(RestartZaGame);
		Quit.GetComponent<Button>().onClick.AddListener(QuitZaGame);
		
	}
	void ResumeZaGame(){
		// SceneManager.LoadScene("main");
		panelOfZaGame.SetActive(false);
		Time.timeScale=1;

	}
	void RestartZaGame(){
		SceneManager.LoadScene("main");
	}
	
	void QuitZaGame(){
		Application.Quit();

	}
	

	// Update is called once per frame
	void Update () {
		
	}
}
