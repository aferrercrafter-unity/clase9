using UnityEngine;
using System.Collections;

public class TankController : MonoBehaviour {

    private Rigidbody rb;
    private Transform tr;
    public float m_TurnInputValue;
    public float m_TurnSpeed;
    public float m_MovementInputValue;
    public float m_Speed;

	// Use this for initialization
	void Start () {
	    rb = gameObject.GetComponent<Rigidbody>();
        tr = gameObject.GetComponent<Transform>();
	}
	
	// Update is called once per frame
	void Update () {
        float turn = m_TurnInputValue * m_TurnSpeed * Time.deltaTime;
        Vector3 movement = transform.forward * m_MovementInputValue * m_Speed * Time.deltaTime;
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            Quaternion turnRotation = Quaternion.Euler(0f, -turn, 0f);
            rb.MoveRotation(rb.rotation * turnRotation);
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            Quaternion turnRotation = Quaternion.Euler(0f, turn, 0f);
            rb.MoveRotation(rb.rotation * turnRotation);
        }
        else if (Input.GetKey(KeyCode.UpArrow))
        {
            // Apply this movement to the rigidbody's position.
            rb.MovePosition(rb.position + movement);
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            // Apply this movement to the rigidbody's position.
            rb.MovePosition(rb.position - movement);
        }
        
	}
}
