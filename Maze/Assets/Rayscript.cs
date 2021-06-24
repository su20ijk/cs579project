using UnityEngine;
using System.Collections;

public class Rayscript : MonoBehaviour
{
    //Public Variables
    public GameObject camera;
    //Private Variables
    private float maxHeight = 10;
    private Vector3 newPosition;
    private float height = 2;
    // Update is called once per frame
    void Update()
    {
        RaycastHit hit = new RaycastHit();
        if (Physics.Raycast(transform.position, -Vector3.up, out hit))
        {
            var distanceToGround = hit.distance;
        }
        if (hit.distance < height)
        {
            newPosition = transform.position;
            newPosition.y += (height - hit.distance);
            transform.position = newPosition;
        }
        else if (hit.distance > height)
        {
            newPosition = transform.position;
            newPosition.y -= (hit.distance - height);
            transform.position = newPosition;
        }
    }
}

