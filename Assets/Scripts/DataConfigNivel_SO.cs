using UnityEngine;

namespace Source.ScriptableObjectConfig.Nivel
{
    [CreateAssetMenu (fileName = "New DataConfigNivel", menuName ="DataNivel")]
    public class DataConfigNivel_SO : ScriptableObject
    {
        [Header("Nivel 1")]
        //public int Nivel_1_BateriaTotal = 0;
        public int Nivel_1_BateriaRecolectado = 0;

        [Header("Nivel 2")]
        //public int Nivel_2_BateriaTotal = 0;
        //public int Nivel_2_BateriaRecolectado = 0;

        [Header("Nivel 3")]
        public int Nivel_3_BateriaTotal = 8;
        public int Nivel_3_BateriaRecolectado= 0;
        

    }
}
