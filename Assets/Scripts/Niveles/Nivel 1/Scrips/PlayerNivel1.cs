using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

namespace Source
{
    public class PlayerNivelTres : MonoBehaviour
    {
        public int CantidadBaterias = 0;
        [Header("UI")]
        [SerializeField] TextMeshProUGUI RecolectarBateriaTMP;
        [SerializeField] TextMeshProUGUI RecolectarBateria_AbrirPuertaTMP;


        [Header("Imagen")]
        [SerializeField] GameObject CheckImg1;
        [SerializeField] GameObject CheckImg2;


        [Header("Mecanicas")]

        [SerializeField]private GameObject puertaAbrir;

        private void Update()
        {
            DescripcionUI();

            if (CantidadBaterias == 5)
            {
                RecolectarBateriaTMP.color = Color.green;
                CheckImg1.SetActive(true);

            }

            if (CantidadBaterias == 3)
            {

                puertaAbrir.SetActive(false);
                RecolectarBateria_AbrirPuertaTMP.color = Color.green;
                CheckImg2.SetActive(true);

            }
        }

        private void DescripcionUI()
        {
            RecolectarBateriaTMP.text = $"Recolectar Baterias {CantidadBaterias.ToString()}/5";

            if (CantidadBaterias <= 3)
            {
                RecolectarBateria_AbrirPuertaTMP.text = $"Recolectar {CantidadBaterias.ToString()}/3 para abrir la puerta";
            }
            else
            {
                RecolectarBateria_AbrirPuertaTMP.text = $"Recolectar 3/3 para abrir la puerta";
            }

            
        }

    }
}
