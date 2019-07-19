using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bala : MonoBehaviour {

	void OnCollisionEnter(Collision col) {

        if (col.gameObject.tag == "Enemigo")
        {
            Destroy(col.gameObject);
        }
    }
}
