using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EjemploSimpleMove : MonoBehaviour
{
    public float speed = 6.0f;
    public float speedRotation = 90.0f;
    public float jumpforce = 8.0f;
    public float gravity = 0.3f;
    private CharacterController _controlador;
    public bool NoMove = false;

    private Vector3 movement = Vector3.zero;


    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        _controlador = GetComponent<CharacterController>();
    }
    
    void Update()
    {
        if (NoMove == false)
        {
            if (_controlador.isGrounded)
            {
                float h = Input.GetAxis("Horizontal") * speed;
                float v = Input.GetAxis("Vertical") * speed;
                movement = transform.forward * v + transform.right * h;
                if (Input.GetButton("Jump")) 
                {
                    movement.y = jumpforce;
                }
            }
            else
            {
                movement.y -= gravity;
            }

            _controlador.Move(movement * Time.deltaTime);
            float rotation = Input.GetAxis("MouseX") * speedRotation * Time.deltaTime;
            rotation += transform.localRotation.eulerAngles.y;
            transform.localRotation = Quaternion.Euler(0f, rotation,0f);
            //_controlador.SimpleMove(movement);

        }
        
    }

    public void noMovement(bool bo)
    {
        NoMove = bo;
    }
    
}
