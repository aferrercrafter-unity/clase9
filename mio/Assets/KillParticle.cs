using UnityEngine;
using System.Collections;

public class KillParticle : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Invoke ("killParticle", 3);
	}

	void killParticle(){
		Destroy (gameObject);
	}
}
