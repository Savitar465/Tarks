using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamaraController : MonoBehaviour
{
    //velocidad de rotación
    public float velRot = 180.0f;
    //vector para almacenar la rotación de la cámara
    Vector3 currentRot;
    float rotX;
    // Use this for initialization
    void Start () {
        currentRot = transform.eulerAngles;
    }
 
    // Update is called once per frame
    void Update () {
        currentRot.y -= Input.GetAxis ("MouseY") * velRot * Time.deltaTime;
        transform.localEulerAngles = currentRot;
    }
}
//