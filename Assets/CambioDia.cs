using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CambioDia : MonoBehaviour
{
    public GameObject dia;
    public GameObject noche;
    
    private void OnTriggerEnter2D(Collider2D other) {
        if (other.gameObject.tag=="Player") {
            dia.SetActive(false);
            noche.SetActive(true);
        }
    }

}
