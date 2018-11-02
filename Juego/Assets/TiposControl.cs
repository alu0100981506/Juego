using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TiposControl : MonoBehaviour {

    private delegate void Delegado();
   

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player")  ) {
            if (gameObject.tag == "TipoA") {
                Delegado delegado = new Delegado(TipoA.accion);
                delegado();
            }
            else if(gameObject.tag == "TipoB") {
                Delegado delegado = new Delegado(TipoB.accion);
                delegado();
            }
        
    }
    }
}
