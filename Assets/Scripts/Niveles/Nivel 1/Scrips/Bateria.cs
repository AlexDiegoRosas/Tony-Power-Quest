using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Source
{
    public class Bateria : MonoBehaviour
    {
        public int bateriasNecesarias = 3; // Cambia esto al número deseado de baterías necesarias.
        public GameObject ColliderPuerta;

        private int bateriasRecogidas = 0;

        void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("Player") && bateriasRecogidas < bateriasNecesarias)
            {
                bateriasRecogidas++;
                if (bateriasRecogidas == bateriasNecesarias)
                {
                    // Todas las baterías necesarias han sido recogidas, activar el Collider de la puerta.
                    if (ColliderPuerta != null)
                    {
                        ColliderPuerta.SetActive(true);
                    }
                }
                // Destruir la batería actual.
                Destroy(gameObject);
            }
        }
    }
}
