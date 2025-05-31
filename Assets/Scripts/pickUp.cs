using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pickUp : MonoBehaviour
{
void OnTriggerEnter2D(Collider2D other)
 {
if (other.CompareTag("Player"))
    {

        Debug.Log("Монета підібрана!");
        Destroy(gameObject);
    }
 }
}
