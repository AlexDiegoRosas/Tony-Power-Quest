using Source.NivelTres.Inventarios;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Source.Nivel3.Bateria
{
    public class BateriaObjeto_Recojer : MonoBehaviour
    {
        
        [SerializeField] PlayerNivelTres playerNivelTres;

        void Start()
        {
            playerNivelTres = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerNivelTres>();
        }


        private void OnTriggerEnter(Collider other)
        {
            if(other.CompareTag("Player"))
            {
                //inventario.Cantidad = inventario.Cantidad + 1;
                playerNivelTres.CantidadBaterias = playerNivelTres.CantidadBaterias + 1;
                Debug.Log("Colision con el player");
                Destroy(gameObject);
            }
        }
    }
}
