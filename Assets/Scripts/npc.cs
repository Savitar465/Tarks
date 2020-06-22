using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class npc : MonoBehaviour
{

    public Transform Point1;
    public Transform Point2;
    public float Speed;
    public Transform CurrentPoint;
    private bool a;
    public int vida=100;
    // Update is called once per frame
    private void Start()
    {
        CurrentPoint = Point1;
    }

    void Update () {
        if (DetectPlayer())
        {
            Transform Player = GameObject.FindGameObjectWithTag("Player").transform;
            transform.position = Vector3.MoveTowards(transform.position, Player.position, Speed * Time.deltaTime);

        }
        else
        {
            transform.position = Vector3.MoveTowards(transform.position, CurrentPoint.position, Speed * Time.deltaTime);
            if (Vector3.Distance(transform.position, CurrentPoint.position)<0.1f)
            {
            
                if (CurrentPoint==Point1)
                {
                    CurrentPoint = Point2;
                }
                else
                {
                    CurrentPoint = Point1;
                }
            }
        }
    }

    bool DetectPlayer()
    {
        Transform Player = GameObject.FindGameObjectWithTag("Player").transform;
        if (Vector3.Distance(transform.position,Player.position)<5)
        {
            return true;
        }

        return false;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            other.gameObject.GetComponent <PlayerController>().Life -= 10;
            Debug.Log("Colision");
        }

    }
}
