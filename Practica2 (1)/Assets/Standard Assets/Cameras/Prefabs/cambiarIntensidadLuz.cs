using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class cambiarIntensidadLuz : MonoBehaviour {
    public Slider intensidad;
    Light myLight;
	// Use this for initialization
	void Start () {
        myLight = GameObject.FindWithTag("Fire").GetComponent<Light>();
    }
	
	// Update is called once per frame
	void Update () {
        myLight.intensity = intensidad.value;
	}
}
