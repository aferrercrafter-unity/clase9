using UnityEngine;

public class Movimiento : MonoBehaviour {

	public float moveSpeed;
	public float rotSpeed;

	public Transform salidaBala;

	public GameObject chispasPrefab;

	void Update ()
	{
		float h = Input.GetAxisRaw ("Horizontal");
		float z = Input.GetAxisRaw ("Vertical");

		transform.Rotate (Vector3.up * Time.deltaTime * rotSpeed * h);
		transform.Translate(Vector3.forward * Time.deltaTime * moveSpeed * z);

		if (Input.GetKeyDown (KeyCode.Space))
		{
			RaycastHit hitInfo;
			if (Physics.Raycast (salidaBala.position,
								 transform.forward, 
								 out hitInfo))
			{
				hitInfo.rigidbody.AddForceAtPosition (hitInfo.point - transform.position, hitInfo.point, ForceMode.Impulse);

				Instantiate (chispasPrefab, hitInfo.point, Quaternion.LookRotation (hitInfo.normal));
			}
		}
	}
}
