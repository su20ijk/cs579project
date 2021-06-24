using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravityOrbit : MonoBehaviour
{
	public float Gravity;

	public bool FixedDirection; // gravity on this section only pulls the player down

	private void OnTriggerEnter(Collider other)
    {
		if(other.GetComponent<GravityControl>())
        {
			// When an object has a gravity script, it will be set as the planet
			other.GetComponent<GravityControl>().Gravity = this.GetComponent<GravityOrbit>();
        }
    }

}
