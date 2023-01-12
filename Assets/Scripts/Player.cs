using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [Range(1, 30)] public float speed = 30.0f;
    [Range(1, 360)] public float rotationRate = 180;

    public GameObject prefab;
    public Transform BulletSpawnLocation;

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
     
        Vector3 direction = Vector3.zero;
        direction.z = Input.GetAxis("Vertical");

        Vector3 roation = Vector3.zero;
        roation.y = Input.GetAxis("Horizontal");

        Quaternion rotate = Quaternion.Euler(roation * rotationRate * Time.deltaTime);
        transform.rotation = transform.rotation * rotate;

        transform.Translate(direction * speed * Time.deltaTime);
        // transform.position += direction * speed * Time.deltaTime;

        if (Input.GetButton("Fire1"))
        {
          
            GameObject go = Instantiate(prefab, BulletSpawnLocation.position, BulletSpawnLocation.rotation);
            
        }

        Debug.Log("update");
    }
}
