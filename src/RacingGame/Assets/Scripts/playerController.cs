using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class playerController : MonoBehaviour {
    private CharacterController controller;
    private Vector3 carVector;
    public float speed = 2.0f;
	public GameObject panelOfZaGame;
	private int score;
	private int score2;
	public Text text;
	public  AudioSource  myaudio;
	public AudioClip clip1;
	public AudioClip clip2;
	public AudioClip clip3;
	public AudioClip clip4;
	public  Camera cam1;
	public  Camera cam2;
	public Button toggleCamera;
	 void OnCollisionEnter(Collision c)
    {

        if (c.gameObject.CompareTag("coin"))
        {
			myaudio.PlayOneShot (clip3);
            score+=10;
            score2+=10;
			if(score2==50){
				speed=speed*1.05f;
				score2=0;
			}
			GameObject.Destroy(c.gameObject);

        }
		if (c.gameObject.CompareTag("EndGame"))
        {
					myaudio.PlayOneShot (clip4);

        SceneManager.LoadScene("GameOver");
        }
		if (c.gameObject.CompareTag("Radar"))
        {
					myaudio.PlayOneShot (clip4);

        if(score>=50){
			score-=50;
		}
		else{
			score=0;
		}

        }
		

    }
	// Use this for initialization
	void Start () {
		// myaudio.PlayOneShot (clip1);
		toggleCamera.GetComponent<Button>().onClick.AddListener(toggleCameraOfZaGame);
		score = 0;
		panelOfZaGame.SetActive(false);
	}
	
	void toggleCameraOfZaGame(){
		if (cam1.depth==0){
			cam1.depth=1;
			cam2.depth=0;
		}
		else{
			cam1.depth=0;
			cam2.depth=2;

		}
		}
	// Update is called once per frame
	void Update () {
		text.text=score+"";
		
		if(Input.GetKeyUp(KeyCode.Escape)){
			if(Time.timeScale==0){
				panelOfZaGame.SetActive(false);
				Time.timeScale=1;
			}
			else{
				panelOfZaGame.SetActive(true);
				Time.timeScale=0;
			}

		}

		transform.Translate(0, 0, (speed * Time.deltaTime));
		carVector.x = Input.GetAxis("Horizontal")*Time.deltaTime*speed;
		carVector.y = Input.GetAxis("Jump")* Time.deltaTime * speed * 2 ;
		carVector.z = (speed * Time.deltaTime);
		if(carVector.y>0){
			myaudio.PlayOneShot(clip2);

		}
		transform.Translate(carVector.x, carVector.y, carVector.z);
	}


}
