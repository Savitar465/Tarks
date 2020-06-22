using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGenerate : MonoBehaviour
{
    public float Counter;

    public float _counter;

    private int EnemyCounter;

    public GameObject Enemy;

    public List<GameObject> Enemies;

    public bool Reverse;
    // Start is called before the first frame update
    void Start()
    {
        _counter = Counter;
    }

    // Update is called once per frame
    void Update()
    {
        Counter -= Time.deltaTime;
        if (Enemies.Count>5)
        {
            Reverse = true;
            return;
        }

        if (Counter<= 0 && !Reverse)
        {
            GameObject newEnemy = Instantiate(Enemy, transform.position, Quaternion.identity);
            Enemies.Add(newEnemy);
            Counter = _counter;
        }else if (Counter <=0 && Reverse)
        {
            Enemies.RemoveAt(0);
            if (Enemies.Count==0)
            {
                Reverse = false;
            }
        }
    }
}
