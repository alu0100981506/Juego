using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ethan : MonoBehaviour {
    public Text texto;
    public static int puntos = 0;
    private Light luz;

    void Start () {
        luz = GameObject.FindWithTag("Linterna").GetComponent<Light>();
	}
	

	void Update () {
        texto.text = puntos.ToString();

        
    }
    public static void aumentar()
    {
        puntos += 10;
 
    }

    public static void disminuir()
    {
        puntos -= 10;
    }

    private void OnTriggerStay(Collider other) {
        if(other.tag == "Apagar") {
            if (Input.GetKey(KeyCode.F)) {
                luz.enabled = !luz.enabled;
            }
        }
    }
}
