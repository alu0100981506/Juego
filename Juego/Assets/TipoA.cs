using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TipoA : MonoBehaviour {
    GameObject player;
    
	// Use this for initialization
	void Start () {
		player = GameObject.FindWithTag("Player");
    }
	
	// Update is called once per frame
	void Update () {
		
	}
    public static void accion() {

        foreach (GameObject o in GameObject.FindGameObjectsWithTag("TipoA")) {
            Renderer rend;
            rend = o.GetComponent<Renderer>();
            //rend.material.color = new Color(Random.Range(0, 255), Random.Range(0, 255), Random.Range(0, 255), 1);
            rend.material.color = Color.blue;

        }

        Ethan.aumentar();

        

    }
}
