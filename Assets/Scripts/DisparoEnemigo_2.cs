using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisparoEnemigo_2 : MonoBehaviour {

    public Rigidbody rocketPrefab;
    public Transform barrelEnd;

    public float cont, frec;

    private void Start()
    {
        cont = 1;
        frec = 2;
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
