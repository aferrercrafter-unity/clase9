using UnityEngine;

public class CameraRay : MonoBehaviour {

	public GameObject player;
	GameObject[] betwen;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
		RaycastHit[] rays;	
		rays = Physics.RaycastAll (transform.position, player.transform.position - transform.position);
		print (rays.Length);
		Debug.DrawRay (transform.position, player.transform.position - transform.position, Color.red);
		foreach (RaycastHit ray in rays) {
			Color color = ray.collider.GetComponent<Renderer> ().material.color;
			color.a = 0.1f;
			ray.collider.GetComponent<Renderer> ().material.color = color;
		}

	}
}
