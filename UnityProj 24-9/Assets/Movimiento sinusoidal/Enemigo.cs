using UnityEngine;

public class Enemigo : MonoBehaviour
{
	public float distancia;

	private float posY;

	void Start ()
	{
		posY = transform.position.y;
	}

	void Update ()
	{
		float posX = Mathf.Sin (Time.time);
		posY -= Time.deltaTime;

		transform.position = new Vector3 (posX * distancia, posY, 0);
	}
}
