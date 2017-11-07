using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Intro : MonoBehaviour {
	public Button start;
	public Button howToPlay;
	public Button credits;
	public Button mute;

	// Use this for initialization
	void Start () {
		start.GetComponent<Button>().onClick.AddListener(startZaGame);
		howToPlay.GetComponent<Button>().onClick.AddListener(howToPlayZaGame);
		credits.GetComponent<Button>().onClick.AddListener(creditsOfZaGame);
		mute.GetComponent<Button>().onClick.AddListener(muteZaGame);
		
	}
	void startZaGame(){
		SceneManager.LoadScene("main");
	}
	
	void howToPlayZaGame(){
		SceneManager.LoadScene("HowToPlay");

	}
	void creditsOfZaGame(){
		SceneManager.LoadScene("Credits");

	}
	void muteZaGame(){
		AudioListener.pause = !AudioListener.pause;
	}

	// Update is called once per frame
	void Update () {
		
	}
}
