using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TipoB : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public static void accion() {
        foreach (GameObject o in GameObject.FindGameObjectsWithTag("TipoB")) {
            Renderer rend;
            rend = o.GetComponent<Renderer>();
            //rend.material.color = new Color(Random.Range(0, 255), Random.Range(0, 255), Random.Range(0, 255), 1);
            rend.material.color = Color.black;

        }
        Ethan.disminuir();
    }
}
