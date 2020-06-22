using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CuboRespawn : MonoBehaviour
{
    public List<GameObject> spawnPositions;
    public List<GameObject> spawnObjects;
    void Start()
    {
        SpawnObjects();
    }

    void SpawnObjects()
    {
        foreach(GameObject spawnPosition in spawnPositions)
        {
            int selection = Random.Range(0, spawnObjects.Count);
            Instantiate(spawnObjects[selection], spawnPosition.transform.position, spawnPosition.transform.rotation);
        }
    }

    /*public float Count;
    public float _count;
    private int CuboCount;
    public GameObject Cubo;
    public List<GameObject> Cubo1;
    public bool Reverse;
    // Start is called before the first frame update
    void Start()
    {
        _count = Count;
    }

    // Update is called once per frame
    void Update()
    {
        Count -= Time.deltaTime;
        if (Cubo1.Count>5)
        {
            Reverse = true;
            return;
        }

        if (Count<= 0 && !Reverse)
        {
            GameObject newEnemy = Instantiate(Cubo, transform.position, Quaternion.identity);
            Cubo1.Add(newEnemy);
            Count = _count;
        }else if (Count <=0 && Reverse)
        {
            Cubo1.RemoveAt(0);
            if (Cubo1.Count==0)
            {
                Reverse = false;
            }
        }
    }*/
}
