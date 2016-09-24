using UnityEngine;
using System.Collections;

public class EjemploLerp : MonoBehaviour {

	public Transform objeto1;
	public Transform objeto2;

	private float timer = 0.0f;

	void Update ()
	{
		timer += Time.deltaTime;

		transform.position = Vector3.Lerp (objeto1.position,
										   objeto2.position, 
									     	timer);
	}
}
