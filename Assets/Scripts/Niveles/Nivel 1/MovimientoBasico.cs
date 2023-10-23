using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Source
{

    public class MovimientoBasico : MonoBehaviour
    {
        private float horizontalMove;
        private float verticalMove;
        public CharacterController player;
        public float PlayerSpeed;

        void Start()
        {
            player = GetComponent<CharacterController>();
        
        }

        void Update()
        {
            horizontalMove = Input.GetAxis("Horizontal");
            verticalMove = Input.GetAxis("Vertical");


        }
        private void FixedUpdate()
        {
            player.Move(new Vector3(horizontalMove,0,verticalMove)*PlayerSpeed);
        }
    }
}