using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    private float cooldown = 0f;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            spawnDog();
        }

        /*
            Il cooldown parte da 1 secondo
            Ogni frame che passa toglie a quel secondo il tempo passato tra un frame e l'altro
            Quando arriva a 0 o più basso potrà riutilizzare la barra spaziatrice
        */
        cooldown -= Time.deltaTime;
        Debug.Log($"{cooldown} | {Time.deltaTime}");
    }

    void spawnDog()
    {
        if (cooldown <= 0)
        {
            //Per 1 secondo non può essere premuta la barra spaziatrice
            cooldown = 1;
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
        }
    }
}
