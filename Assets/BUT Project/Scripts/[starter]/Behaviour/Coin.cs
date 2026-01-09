using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    public int value = 1;

    private void OnTriggerEnter(Collider other)
    {
        CoinCounter counter = other.GetComponent<CoinCounter>();

        if (counter != null)
        {
            counter.AddCoins(value);
            Destroy(gameObject);
        }
    }


    public float rotationSpeed = 90f;

    void Update()
    {
        transform.Rotate(Vector3.up, rotationSpeed * Time.deltaTime, Space.World);
    }
}



