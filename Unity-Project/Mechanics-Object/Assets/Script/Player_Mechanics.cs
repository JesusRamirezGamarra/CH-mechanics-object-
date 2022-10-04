// using System.Collections;
// using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player_Mechanics : MonoBehaviour
{
    private int life = 100;
    private float speedMove = 0.05f;
    private Vector3 direction;

    private bool isHPIncrementForKey = false;
    private bool isHPDecrementForKey = false;

    // private GameObject AssetParedIzquierda = GameObject.Find("Pared_Izquierda");
    // private GameObject AssetPareDerecha = GameObject.Find("Pared_Dereha");
    // private GameObject AssetPareFondo = GameObject.Find("Pared_Fondo");
    // private GameObject AssetPiso = GameObject.Find("Piso");
    

    void Start()
    {
    }

    void Update()
    {
        var input = Input.inputString;
        switch(input){
            case "-":
                print("- was pressed");
                isHPDecrementForKey =true;
                isHPDecrementForKey = (life>0)?HpDecrement():false;
                break;
            case "+":
                print("+ was pressed");      
                isHPIncrementForKey =true;
                isHPIncrementForKey = (life<100)?HpIncrement():false;     
                break;
            default:
                    MovementPlayer();
                break;
        }
    }

    void MovementPlayer()
    {
        float h = speedMove * Input.GetAxis("Mouse X") * -1f;            
        float v = speedMove * Input.GetAxis("Mouse Y");
        GameObject playerObject = GameObject.Find("Sphere");
        Vector3 playerPos = playerObject.transform.position;

        Debug.Log("playerPos.x : " + playerPos.x);
        if (  playerPos.x <= -9.5f ){
            Debug.Log("Colisiono :  Pared derecha");
            h= 0.5f;
        }
        if (  playerPos.x >= 9.5f ){
            Debug.Log("Colisiono :  Pared Izquierda"); 
            h= -0.5f;
        }    
        if (  playerPos.y <= 1.0f ){
            Debug.Log("Colisiono : Piso"); 
            v= 1.5f;
        }         

        // Solo para utilizar la funcionalidad de Debug.DrawRay
        Debug.DrawRay(transform.position,new Vector3( 1, 0, 0) * 5, Color.blue );
        Debug.DrawRay(transform.position,new Vector3( -1, 0, 0) * 5, Color.blue );
        Debug.DrawRay(transform.position,new Vector3( 0, 1, 0) * 5, Color.red );
        Debug.DrawRay(transform.position,new Vector3( 0, -1, 0) * 5, Color.red );
            
        transform.Translate( h , v, 0);
        
    }

    bool HpIncrement()
    {
        if( isHPIncrementForKey ){
            life++;
            if (life <=99){
                Debug.Log(  " Health UP . HP = " + life.ToString()  ) ;
            }else {
                Debug.Log(  " Oh Yeah ... Maximn Health :  HP =" + life.ToString()  ) ; 
            }
        }
        return false;     
    }

    bool HpDecrement()
    {
        if( isHPDecrementForKey ){
            life--;
            if (life >=1){
                Debug.Log(  " Health Down . HP = " + life.ToString()  ) ;
            }else {
                Debug.Log(  " tan tan tan ... Dead :  HP =" + life.ToString()  ) ; 
            }
        }
        return false;
    }
}
