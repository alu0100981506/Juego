using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AumentarPoder : MonoBehaviour {

	// Use this for initialization
	void Start () {
       // ControladorDeEscena.controlador.aumentar += Aumentar;
	}
	
	// Update is called once per frame
	void Update () {
		
	}


    public int Aumentar(float poder) {
        Debug.Log("entra en el delegado");
        return 10;
    }

}
