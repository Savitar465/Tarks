using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager1 : MonoBehaviour
{
    public Movement Cube1;

    public Text winText;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(Cube1.gameObject.transform.position,Cube1.Goal.transform.position)<0.5)
        {
            winText.text = Cube1.gameObject.name + "WIN";
            Debug.Log("Llego ahi");
        }
        
    }
}
