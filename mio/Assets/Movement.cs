using UnityEngine;

public class Movement : MonoBehaviour {

	public float movSpeed;
	public float rotSpeed;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKey (KeyCode.A)) {
			transform.Rotate (Vector3.down * Time.deltaTime * rotSpeed);
		}
		if (Input.GetKey (KeyCode.D)) {
			transform.Rotate (Vector3.up * Time.deltaTime * rotSpeed);
		}
		if (Input.GetKey (KeyCode.W)) {
			transform.Translate (Vector3.forward * Time.deltaTime * movSpeed);
		}
		if (Input.GetKey (KeyCode.S)) {
			transform.Translate (Vector3.back * Time.deltaTime * movSpeed);
		}
	}
}
