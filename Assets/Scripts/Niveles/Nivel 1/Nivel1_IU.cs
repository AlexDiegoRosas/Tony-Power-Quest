using Source.Nivel1.Baterias;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

namespace Source.Nivel1.UI
{
    public class Nivel1_IU : MonoBehaviour
    {
        [SerializeField] TextMeshProUGUI textoUI_Recolectar_TMP;
        [SerializeField] private Bateria bateria;


        void Start()
        {
            bateria =GetComponent<Bateria>();
        }

        void Update()
        {
            textoUI_Recolectar_TMP.text = $"Recolectar Baterias {bateria.bateriasRecogidas.ToString()}/5";
        }

        
    }
}
