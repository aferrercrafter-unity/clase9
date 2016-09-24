using UnityEngine;
using System.Collections;

public class Spawner : MonoBehaviour {

	public GameObject enemy;

	// Use this for initialization
	void Start () {
		InvokeRepeating ("Spawn", 2, 2);
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void Spawn(){

		Instantiate (enemy, new Vector3 (Random.Range (-10, 10), 1, Random.Range (-10, 10)), Quaternion.identity);

	}

}
