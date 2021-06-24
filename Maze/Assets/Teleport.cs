using UnityEngine;
using System.Collections;

public class Teleport : MonoBehaviour
{
    //Public Variables
    //public GameObject camera;
    //Camera maincam = GameObject.Find("MainCamera").GetComponent<Camera>();
    //Private Variables
    private float maxHeight = 10;
    // Update is called once per frame
    void Update()
    {
        RaycastHit hit = new RaycastHit();
        if (Physics.Raycast(transform.position, Vector3.up, out hit))
        {
            var distanceToGround = hit.distance;
        }
        if (hit.distance >0 && hit.distance < 3) {
            Camera.main.transform.position = new Vector3(138.04f, -0.44f, -21.81f);
        }
        Debug.Log(hit.distance);
    }
}

