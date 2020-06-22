using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlCamPlay : MonoBehaviour
{
    //Desplazamiento en los ejes X y Z
    float movX;
    float movZ;
    //rotación en el eje vertical (el FPC sólo va a rotar sobre este eje)
    float rotY;
    Vector3 mov;
    //las velocidades de movimiento y rotación
    public float vel = 8.0f;
    public float velRot = 180.0f;
 
    // Use this for initialization
    void Start () {
        Cursor.lockState = CursorLockMode.Locked;
    }
 
    // Update is called once per frame
    void Update (){
        rotY = Input.GetAxis("MouseX") * velRot * Time.deltaTime;
        transform.Rotate(0, rotY, 0);
        movX = Input.GetAxisRaw ("Horizontal") * vel * Time.deltaTime;
        movZ = Input.GetAxisRaw ("Vertical") * vel * Time.deltaTime;
        mov = new Vector3 (movX, 0.0f, movZ);
        transform.Translate (mov);
    }
}
