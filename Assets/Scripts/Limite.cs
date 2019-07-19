using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Limite : MonoBehaviour {

    void OnCollisionEnter(Collision col)
    {

        if (col.gameObject.tag != "Dunas")
        {
            Destroy(col.gameObject);
        }
    }
}
