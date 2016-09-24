using UnityEngine;
public class Shooting : MonoBehaviour {

	public GameObject sparkles;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKeyDown (KeyCode.Space)) {
			RaycastHit ray;
			bool hit = Physics.Raycast (transform.position, transform.TransformDirection(Vector3.forward), out ray);
			print (hit);

			if (hit) {
				ray.collider.GetComponent<Renderer> ().material.color = Color.red;
				ray.rigidbody.AddForceAtPosition (ray.point - transform.position, ray.point, ForceMode.Impulse);
				Instantiate (sparkles, ray.point, Quaternion.LookRotation(ray.point - transform.position));

			}
		}

	}
}
