using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Asteroid : MonoBehaviour
{
    [Range(1, 30)] public float speed = 30.0f;
    [Range(1, 360)] public float rotationRate = 180;
    public GameObject explosion;

    Vector3 direction;
    Vector3 rotation;

    private void OnDestroy()
    {
        Instantiate(explosion, transform.position, transform.rotation);
    }
    // Start is called before the first frame update
    void Start()
    {
        direction = Quaternion.AngleAxis(Random.Range(0, 360), Vector3.up) * Vector3.forward;
        rotation = new Vector3(Random.Range(-1, 1), Random.Range(-1, 1), Random.Range(-1, 1));
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += direction * speed * Time.deltaTime;
        transform.rotation = transform.rotation * Quaternion.Euler(rotation * rotationRate * Time.deltaTime);
    }
}
