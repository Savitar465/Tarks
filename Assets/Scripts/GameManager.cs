using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private GameObject[] spawns;
    public List<GameObject> objts;
    public List<GameObject> objtsMov;
    private float speed;
    public GameObject obj;

    private int click1 =1;
    private GameObject originalTile;
    private GameObject targetTile;
    private bool t2 = true;
    private bool t1 = true;
    private Camera camera1;
    private bool iscameraNotNull;

    // Start is called before the first frame update
    private void Start()
    {
        camera1 = Camera.main;
        iscameraNotNull = camera1 != null;
    }

    void Awake()
    {
        speed = 10;
        spawns = GameObject.FindGameObjectsWithTag("Generator");
        foreach (var t in spawns)
        {
            CreateObject(t);
        }
    }

    // Update is called once per frame
    void Update() {
        
        for (int i = 0; i < spawns.Length; i++)
        {
            objtsMov[i].transform.position = Vector3.MoveTowards (objtsMov[i].transform.position, spawns[i].transform.position, speed * Time.deltaTime);
        }

        if (iscameraNotNull)
        {
            var ray = camera1.ScreenPointToRay (Input.mousePosition);
            if (!Input.GetMouseButtonDown(0)) return;
            if (!Physics.Raycast(ray, out var hit, Mathf.Infinity)) return;
            switch(click1)
            { 
               
                case 2: 
                    originalTile = hit.collider.gameObject;
  
                    click1= 1;
                    t1 =false;
                    break;
                case 1: 
                    targetTile = hit.collider.gameObject;
                    click1 = 2;
                    t2 = false;
                    break;
            }
                 
            if(t1 == false && t2 == false)
                Swap(originalTile, targetTile);
        }
    }

    private void  Swap(GameObject org, GameObject tar)
    {
        var position = org.transform.position;
        var temp =  new Vector3(position.x, position.y, position.z);
        position = tar.transform.position;
        org.transform.position = position;
        tar.transform.position= temp;
        t1 = true;
        t2 = true;
    }

    private void CreateObject(GameObject pos)
    {
        var newEnemy = Instantiate(obj,pos.transform.position, Quaternion.identity);
       // newEnemy.transform.SetParent (GameObject.FindGameObjectWithTag("Canvas").transform, false);
        objtsMov.Add(newEnemy);
        objts.Add(newEnemy);
    }
}
