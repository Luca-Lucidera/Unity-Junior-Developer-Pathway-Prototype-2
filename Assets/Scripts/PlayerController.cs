using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float horizontalInput;
    private float speed = 10;
    private readonly int xRange = 10;

    public GameObject projectilePrefab;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        MoveLogic();
        ThrowPizzaSliceLogic();
    }

    private void MoveLogic()
    {
        var xPosition = transform.position.x;
        if (xPosition < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }
        if (xPosition > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }

        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizontalInput * speed * Time.deltaTime);
    }
    private void ThrowPizzaSliceLogic()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            var cloneProjectile = Object.Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
        }
    }
}
