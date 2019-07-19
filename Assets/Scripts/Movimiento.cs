using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento : MonoBehaviour {

    public float moveSpeed = 10f;
    public float turnSpeed = 50f;

    void Start () {}

	void Update () {

        // Traslaciones
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(new Vector3( 0, 0, -moveSpeed) * Time.deltaTime);       //transform.Translate(-Vector3.forward * moveSpeed * Time.deltaTime);

            // Rotaciones
            if (Input.GetKey(KeyCode.LeftArrow))
                transform.Rotate(Vector3.up, -turnSpeed * Time.deltaTime);

            if (Input.GetKey(KeyCode.RightArrow))
                transform.Rotate(Vector3.up, turnSpeed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(new Vector3(0, 0, moveSpeed) * Time.deltaTime);          //transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);

            // Rotaciones
            if (Input.GetKey(KeyCode.LeftArrow))
                transform.Rotate(Vector3.up, turnSpeed * Time.deltaTime);

            if (Input.GetKey(KeyCode.RightArrow))
                transform.Rotate(Vector3.up, -turnSpeed * Time.deltaTime);
        }
    }
}
