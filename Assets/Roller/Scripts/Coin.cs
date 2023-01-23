using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : Collidable
{
    [SerializeField] GameObject pickupFX;

    void Start()
    {
        onEnter += OnCoinPickup;
    }

    void Update()
    {

    }

    void OnCoinPickup(GameObject go)
    {
        if (go.TryGetComponent<RollerPlayer>(out RollerPlayer player))
        {
            player.AddPoints(20);
        }

        Debug.Log("pickup");
        Instantiate(pickupFX, transform.position, Quaternion.identity);
        Destroy(gameObject);

    }

}
