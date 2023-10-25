using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Source
{
    public class Bateria : MonoBehaviour
    {
        public int bateriasNecesarias = 3; // Cambia esto al n�mero deseado de bater�as necesarias.
        public GameObject ColliderPuerta;

        private int bateriasRecogidas = 0;

        void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("Player") && bateriasRecogidas < bateriasNecesarias)
            {
                bateriasRecogidas++;
                if (bateriasRecogidas == bateriasNecesarias)
                {
                    // Todas las bater�as necesarias han sido recogidas, activar el Collider de la puerta.
                    if (ColliderPuerta != null)
                    {
                        ColliderPuerta.SetActive(true);
                    }
                }
                // Destruir la bater�a actual.
                Destroy(gameObject);
            }
        }
    }
}
