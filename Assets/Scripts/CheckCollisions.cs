using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckCollisions : MonoBehaviour
{
    //OnTriggerEnter se llamará automáticamente cuando un objeto físico entre dentro del trigger del Game Object
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Enemy"))
        {
            //El animal choca contra una bala
            this.gameObject.transform.position = new Vector3(0, 0.5f, 0);
            other.gameObject.transform.position = new Vector3(-7, 0.5f, -8);
            //Destroy(this.gameObject); //Destruye el jugador
            //Destroy(other.gameObject); //Destruye al enemigo
        }
    }
}
