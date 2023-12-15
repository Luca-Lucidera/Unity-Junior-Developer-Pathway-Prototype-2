using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    private float topBoundry = 30;
    private float lowerBoundry = -15;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z > topBoundry)
            Destroy(gameObject);
        else if (transform.position.z < lowerBoundry)
        {
            Debug.Log("Fine gioco");
            Destroy(gameObject);
        }


    }
}
