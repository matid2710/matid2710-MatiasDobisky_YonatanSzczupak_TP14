using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ConoPickup : MonoBehaviour
{
    public static int conosRecolectados = 0;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            conosRecolectados++;
            Debug.Log("¡Encontraste el cono! Total: " + conosRecolectados);
            Destroy(gameObject);
        }
    }
}
