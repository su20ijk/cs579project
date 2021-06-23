using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravityControl : MonoBehaviour
{
	public GravityOrbit Gravity;
	private Rigidbody Rb;

	public float RotationSpeed = 20;
	
	// Called before the first frame update
	void Start()
    {
		Rb = GetComponent<Rigidbody>();
    }
	
	// Called once per frame
	void FixedUpdate()
    {
		if(Gravity)
        {
			Vector3 gravityUp = Vector3.zero;

			if(Gravity.FixedDirection)
            {
				gravityUp = Gravity.transform.up;
            }
            else
            {
				gravityUp = (transform.position - Gravity.transform.position).normalized;
            }
			
			//Gravity = (transform.position - Gravity.transform.position).normalized;

			Vector3 localUp = transform.up;

			Quaternion targetrotation = Quaternion.FromToRotation(localUp, gravityUp) * transform.rotation;

			transform.up = Vector3.Lerp(transform.up, gravityUp, RotationSpeed * Time.deltaTime);

			// Gravity pushes down
			Rb.AddForce((-gravityUp * Gravity.Gravity) * Rb.mass);
        }
    }
}
