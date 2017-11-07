using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class GameOver : MonoBehaviour {
	public Button Restart;
	public Button Quit;

	// Use this for initialization
	void Start () {
		Restart.GetComponent<Button>().onClick.AddListener(RestartZaGame);
		Quit.GetComponent<Button>().onClick.AddListener(QuitZaGame);
		
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
