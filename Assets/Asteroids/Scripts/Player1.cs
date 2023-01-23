using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;
using UnityEngine.UIElements;

public class Player1 : MonoBehaviour
{
    [Range(1, 30)] public float speed = 30.0f;
    [Range(1, 360)] public float rotationRate = 180;

    public GameObject prefab;
    public Transform BulletSpawnLocation;
    public Transform BulletSpawnLocation1;
    public Transform BulletSpawnLocation2;
    public Transform BulletSpawnLocation3;

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

        Vector3 rotation = Vector3.zero;
        rotation.y = Input.GetAxis("Horizontal");

 /*       //tilt ship based on direction
        if (rotation.y != 0)
        {
            transform.Rotate(0, 0, 22.5f * Time.deltaTime);
        }
        else
        {
            _ = rotation.y == 0;
        }*/

        Quaternion rotate = Quaternion.Euler(rotation * rotationRate * Time.deltaTime);
        transform.rotation = transform.rotation * rotate;

        transform.Translate(direction * speed * Time.deltaTime);
        // transform.position += direction * speed * Time.deltaTime;

        if (Input.GetButton("Fire1"))
        {

            GameObject go = Instantiate(prefab, BulletSpawnLocation.position, BulletSpawnLocation.rotation);
            go = Instantiate(prefab, BulletSpawnLocation1.position, BulletSpawnLocation1.rotation);
            go = Instantiate(prefab, BulletSpawnLocation2.position, BulletSpawnLocation2.rotation);
            go = Instantiate(prefab, BulletSpawnLocation3.position, BulletSpawnLocation3.rotation);

        }

        Debug.Log("update");
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            FindObjectOfType<AsteroidGameManager>()?.SetGameOver();
        }
    }
}
