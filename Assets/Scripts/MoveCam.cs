using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCam : MonoBehaviour
{
    //public GameObject player;
    //public float sensitivity;
    //private Vector3 offset;
    //private Rigidbody rb;
    void Start () 
    {
      //  offset = transform.position - player.transform.position;
       // rb = GetComponent<Rigidbody> ();
    }
    void LateUpdate () 
    {
        //transform.position = player.transform.position + offset;
        
    }
    void FixedUpdate ()
    {
        //float rotateHorizontal = Input.GetAxis ("MouseX");
        //float rotateVertical = Input.GetAxis ("MouseY");
        //transform.RotateAround (player.transform.position, -Vector3.up, rotateHorizontal * sensitivity); //use transform.Rotate(-transform.up * rotateHorizontal * sensitivity) instead if you dont want the camera to rotate around the player
        //transform.RotateAround (Vector3.zero, transform.right, rotateVertical * sensitivity); // again, use transform.Rotate(transform.right * rotateVertical * sensitivity) if you don't want the camera to rotate around the player
    }
    // Update is called once per frame
    void Update()
    {
        Camera mycam = GetComponent<Camera>();
        transform.LookAt(mycam.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, mycam.nearClipPlane)), Vector3.up);
    }
}
