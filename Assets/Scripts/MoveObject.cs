using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObject : MonoBehaviour // : dos puntos significa que la clase MoveObject hereda de MonoBehaviour
{
    float z, x, y;
    public Vector3 speed;
    
    // Update is called once per frame
    void Update() // 120 fps, 20 fps
    {
        
        //z += speed * Time.deltaTime; // Potente = 0.008, Pobre = 0.050
        x += speed.x * Time.deltaTime;
        y += speed.y * Time.deltaTime;
        z += speed.z * Time.deltaTime;
        transform.position = new Vector3(x, y, z);
    }
}
