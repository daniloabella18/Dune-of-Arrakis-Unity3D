using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalaEnemiga : MonoBehaviour {

    public float cont;

    private void Start()
    {
        cont = 0;
    }

    void OnCollisionEnter(Collision col)
    {

        if (col.gameObject.tag == "Player")
        {
            Destroy(col.gameObject);
        }

    }

    private void Update()
    {
        cont = cont + 1 * Time.deltaTime;
        if ( cont > 6 )
        {
            Destroy(this.gameObject);
        }
    }
}
