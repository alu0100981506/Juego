using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class DisminuirCambiar : MonoBehaviour {
    public Slider tamaño;
    // Use this for initialization
    void Start () {
       // ControladorDeEscena.controlador.DisminuirCambiar += disminuirCambiarObjetos;
    }
	
	// Update is called once per frame
	void Update () {
        this.gameObject.transform.localScale = new Vector3(tamaño.value ,tamaño.value ,tamaño.value);
	}
   
    public int disminuirCambiarObjetos() {
        Debug.Log("entra en el delegado");
        return -10;
    }
}
