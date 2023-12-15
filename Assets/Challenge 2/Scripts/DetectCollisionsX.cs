using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisionsX : MonoBehaviour
{

    private void OnTriggerEnter(Collider ball)
    {
        Destroy(ball.gameObject);
        Destroy(gameObject);
        Debug.Log("Game End");
    }
}
