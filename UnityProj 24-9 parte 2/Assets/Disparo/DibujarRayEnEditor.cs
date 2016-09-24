using UnityEngine;

public class DibujarRayEnEditor : MonoBehaviour
{

	void Update ()
	{
		Debug.Log ("Hola"); // igual a print

		Debug.DrawRay (Vector3.zero,
					   new Vector3(0,0.5f,0.5f) * 50,
					   Color.green);
	}
}
