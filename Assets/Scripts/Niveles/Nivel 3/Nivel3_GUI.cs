using Source.Nivel3.Bateria;
using Source.NivelTres.Inventarios;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

namespace Source.NivelTres.GUI
{
    public class Nivel3_GUI : MonoBehaviour
    {
        [SerializeField] private TextMeshProUGUI descripRecolectarBateriasTMP;
        PlayerNivelTres playerNivelTres;

        private void Start()
        {
            playerNivelTres = GetComponent<PlayerNivelTres>();
            descripRecolectarBateriasTMP = GetComponent<TextMeshProUGUI>();
        }

        private void Update()
        {
            ActualizarUIDescripcion();
        }


        private void ActualizarUIDescripcion()
        {
            descripRecolectarBateriasTMP.text = $"Recolectar Baterias {playerNivelTres.CantidadBaterias.ToString()}/8";
        }











    }


   
}
