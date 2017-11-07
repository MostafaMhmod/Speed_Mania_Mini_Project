using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tileManger : MonoBehaviour {
	public GameObject[] tilePrefabs;

	private Transform playerTransform;
	private float spawnZ = 0.0f;
	private float tileLength = 25.0f;
	private int numOfTilesOnScreen = 3;
	private List<GameObject> prefabsOfZaGame ;
	

	void spawnTile (int prefabIndex = -1)
	{
		GameObject go;
		System.Random rnd = new System.Random();
		int indexOfPrefabs = rnd.Next(0,tilePrefabs.Length);
		go = Instantiate(tilePrefabs[indexOfPrefabs]) as GameObject;
		go.transform.SetParent(transform);
		go.transform.position= new Vector3(0, 0, spawnZ) ;
		prefabsOfZaGame.Add(go);
		spawnZ += tileLength;
		
	}
	// Use this for initialization
	void Start () {
		prefabsOfZaGame = new List<GameObject>();
		playerTransform = GameObject.FindGameObjectWithTag("Player").transform;
		for (int i = 0; i < numOfTilesOnScreen; i++)
		{
			spawnTile();
		}

	}
	
	// Update is called once per frame
	void Update () {

		if(playerTransform.position.z >(spawnZ - numOfTilesOnScreen * tileLength))
		{
			if(prefabsOfZaGame.Count>4){
				GameObject.Destroy(prefabsOfZaGame[0].gameObject);
							prefabsOfZaGame.RemoveAt(0);

			}
			spawnTile();
		}
	}
}
