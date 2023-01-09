using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [Range(1, 10)] public float speed = 5.0f;
    public GameObject prefab;

    public void Awake()
    {
        Debug.Log("awake");
    }
    void Start()
    {
        Debug.Log("start");
    }

    void Update()
    {
        //  transform.position = new Vector3(2, 3, 2);
        // transform.rotation= Quaternion.Euler(30,30,30);
        //transform.localScale = Vector3.one * Random.value * 5;

        Vector3 direction = Vector3.zero;
        direction.x = Input.GetAxis("Horizontal");
        direction.z = Input.GetAxis("Vertical");


        transform.position += direction * speed * Time.deltaTime;

        if (Input.GetButton("Fire1"))
        {
            Debug.Log("shots fired! ");
            GetComponent<AudioSource>().Play();
            
            Instantiate(prefab, transform.position, transform.rotation);

        }

        Debug.Log("update");
    }
}
