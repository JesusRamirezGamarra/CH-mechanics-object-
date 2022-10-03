// using System.Collections;
// using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Vector3 changeScale = new Vector3(-0.001f,-0.001f,-0.001f);
    public Vector3 moveDirection = new Vector3(0f,0f,0f);
    public Vector3 moveSpeed =new Vector3(0f,0f,0f);
    

    void Start()
    {
        // Al darle play, cambie su escala a un nuevo valor (modificable por inspector ) . 
        transform.localScale += changeScale;
    }
    // Update is called once per frame
    void Update()
    {

        //con cada frame se mueva en una dirección y con una velocidad determinadas (también modificables desde el inspector).
        // https://www.youtube.com/watch?v=8rziy9rwQtI   :  Timne.time vs Time.DeltaTime
        transform.Translate(moveSpeed * Time.deltaTime , Space.World);
        
    }
}
