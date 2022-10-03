// using System.Collections;
// using System.Collections.Generic;
using UnityEngine;

public class Camara_Direcctional : MonoBehaviour
{

    // int numero = 10;
    // float velocidad = 25f;
    // char caracteres = 'A';
    // string nombreJugador = "UserName";
    // bool EstaMuerto = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0f,0.01f,0f);
        transform.Rotate(0.15f,0,0);
    }
}
