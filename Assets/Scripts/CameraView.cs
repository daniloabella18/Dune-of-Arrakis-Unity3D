using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

public class CameraView : MonoBehaviour {

    [SerializeField]
    Camera FirstPCamera;
    [SerializeField]
    Camera SecondPCamera;

    public Text Muerto;
    public int newFontsize;
    public string Perder;
    public string Ganar;
    public float cont;
    public Color newColor;

    // Use this for initialization
    void Start ()
    {
        cont = 0;
        FirstPCamera.GetComponent<Camera>().enabled = true;
        SecondPCamera.GetComponent<Camera>().enabled = false;
    }

    void OnCollisionEnter(Collision col)
    {

        if (col.gameObject.tag == "Bala_Enemiga" || col.gameObject.tag == "Pared" )
        {
            FirstPCamera.GetComponent<Camera>().enabled = false;
            SecondPCamera.GetComponent<Camera>().enabled = true;
            Muerto.text = Perder;
            Muerto.fontSize = newFontsize;
            Muerto.color = newColor;

            for (cont = 0; cont < 7; cont = cont + 1 * Time.deltaTime)
            {
                if (cont > 6)
                {
                    SceneManager.LoadScene("Menu");
                }
            }
        }

        if (col.gameObject.tag == "Finish")
        {
            FirstPCamera.GetComponent<Camera>().enabled = false;
            SecondPCamera.GetComponent<Camera>().enabled = true;
            Muerto.text = Ganar;
            Muerto.fontSize = newFontsize;
            Muerto.color = newColor;

            for (cont = 0; cont < 7; cont = cont + 1 * Time.deltaTime)
            {
                if (cont > 6)
                {
                    SceneManager.LoadScene("Menu");
                }
            }
        }
    }
}
