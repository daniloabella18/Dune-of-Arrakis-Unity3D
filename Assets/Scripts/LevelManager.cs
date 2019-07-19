using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class LevelManager : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

	}

	public void CargaNivel(string pNombreNivel){
        SceneManager.LoadScene(pNombreNivel);
	}

    public void salir()
    {
        Application.Quit();
    }
}
