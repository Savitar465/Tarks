using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using  UnityEngine.SceneManagement;
public class PlayerController : MonoBehaviour
{
    public float Life;
    private  Rigidbody _rigidbody;

    public float Speed;

    public GameObject GameOverPanel;
    // Start is called before the first frame update
    void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float Horizontal = Input.GetAxis("Horizontal");
        float Vertical = Input.GetAxis("Vertical");
        _rigidbody.velocity = new Vector3(Horizontal*Speed, _rigidbody.velocity.y,Vertical*Speed);
        if (Life<=0)
        {
            GameOverPanel.SetActive(true);
            //Destroy(gameObject);
        }
    }
}
