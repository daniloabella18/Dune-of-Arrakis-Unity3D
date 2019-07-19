using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disparo : MonoBehaviour
{
    public Rigidbody rocketPrefab;
    public Transform barrelEnd;

    void Update()
    {
        if (Input.GetKeyDown("a"))
        {
            Rigidbody rocketInstance;
            rocketInstance = Instantiate(rocketPrefab, barrelEnd.position, barrelEnd.rotation) as Rigidbody;    // Función de instanciar bala
            rocketInstance.AddForce(barrelEnd.forward * 5000);
        }
    }
}