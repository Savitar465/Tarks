using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement1 : MonoBehaviour {
   // public GameObject Goal;
    private float Speed;

    // Start is called before the first frame update
    void Start () {
        Speed = Random.Range (2, 7);
    }

    // Update is called once per frame
    void Update ()
    {
        var position = transform.position;
        position = Vector3.MoveTowards (position, position, Speed * Time.deltaTime);
        transform.position = position;
    }
}