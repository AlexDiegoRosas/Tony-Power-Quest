using Source.ScriptableObjectConfig.Nivel;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Source.NivelTres.Inventarios
{
    public class PlayerNivelTres : MonoBehaviour
    {
        public int CantidadBaterias = 0;

        [SerializeField] TextMeshProUGUI RecolectarMonedaTMP;

        [SerializeField] GameObject CheckImg;

        private void Update()
        {
            DescripcionUI();

            if (CantidadBaterias == 8)
            {
                RecolectarMonedaTMP.color = Color.green;
                CheckImg.SetActive(true);
                
            }
        }

        private void DescripcionUI()
        {
            RecolectarMonedaTMP.text = $"Recolectar Baterias {CantidadBaterias.ToString()}/8";
        }

    }

    
}
