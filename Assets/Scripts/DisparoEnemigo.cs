using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisparoEnemigo : MonoBehaviour {

    public Rigidbody rocketPrefab;
    public Transform barrelEnd;

    public float cont, frec;

    private void Start()
    {
        cont = 0;
        frec = 3;
    }

    void Update()
    {
        cont = cont + 1 * Time.deltaTime;

        if (cont > frec)
        {
            cont = 0;
            Rigidbody rocketInstance;
            rocketInstance = Instantiate(rocketPrefab, barrelEnd.position, barrelEnd.rotation) as Rigidbody;    // Función de instanciar bala
            rocketInstance.AddForce(barrelEnd.forward * 5000);

        }
    }
}
