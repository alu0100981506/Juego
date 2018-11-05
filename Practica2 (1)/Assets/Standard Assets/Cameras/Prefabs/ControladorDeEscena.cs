using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//public delegate int actualizarPoder();
//public delegate int actualizarPoderCambiar();
//public delegate void OnCollisionEnter(Collision other);
public class ControladorDeEscena : MonoBehaviour {
    // public static event OnCollisionEnter poderUpDown;
    // public actualizarPoder aumentar;
    //public actualizarPoderCambiar DisminuirCambiar;
    
    public Slider intensidad;
    public static ControladorDeEscena controlador;
    int points;
    private Light myLight;
    public Text textoPantalla;
    bool StayCollition;
    // Use this for initialization
    void Start () {
    
        StayCollition = false;
        myLight = GameObject.FindWithTag("Fire").GetComponent<Light>(); 
        //Debug.Log(DisminuirCambiar);
        setPoints(100);
    }
	
	// Update is called once per frame
	void Update () {
        if ((Input.GetKeyUp(KeyCode.F)) && (StayCollition))
        {   
            myLight.enabled = !myLight.enabled;
        }


    }

    void OnCollisionEnter(Collision other)
    {

        //Debug.Log("entra en el delegado");
        if (other.gameObject.CompareTag("DisminuirPoder"))
        {
            setPoints(-10);
            modificarObjetos();
            //setPoints(DisminuirCambiar(10));
        }
        else if (other.gameObject.CompareTag("AumentarPoder"))
        {
            //Debug.Log("entra en el delegado22222222222222222");
            //setPoints(aumentar(10));
            setPoints(10);
        }
        
    }
    
    private void OnTriggerStay(Collider other)
    {
        Debug.Log(" StayOncollision" + StayCollition);
        if (other.gameObject.CompareTag("apagar"))
        {
            Debug.Log(" StayOncollision" + StayCollition);
            StayCollition = !StayCollition;
        }
    }
    private  void OnTriggerExit(Collider other)
    {
        Debug.Log(" StayOncollision" + StayCollition);
        if (other.gameObject.CompareTag("apagar"))
        {
            StayCollition = false;
            Debug.Log(" StayOncollision" + StayCollition);
        }
    }
    void setPoints(int point)
    {
        points += point;
        textoPantalla.text = "puntos : " + points ;
    }

    void Awate() {

        if (controlador == null)
        {
            controlador = this;
            DontDestroyOnLoad(this);
        }
        else if(controlador != this){
            Destroy(controlador);
        }
    }
    void modificarObjetos() {
        foreach (GameObject o in GameObject.FindGameObjectsWithTag("DisminuirPoder"))
        {
            o.transform.localScale = new Vector3(2, 2, 2);
        }
    }

   
}
