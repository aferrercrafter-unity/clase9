using UnityEngine;

public class Linea : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		RaycastHit hitInfo;

		if (Physics.Linecast (new Vector3 (0, 0, 0),
							    new Vector3 (0, 0, 3),
							    out hitInfo))
		{
			
		}

	}
}
