using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SojaExiles

{
    public class PlayerMovement : MonoBehaviour
    {

        public CharacterController controller;

        public float speed = 5f;
        public float gravity = -15f;
       
        Vector3 velocity;
        
        bool isGrounded;
        bool isCrouched;

        void Update()
        {

            float x = Input.GetAxis("Horizontal");
            float z = Input.GetAxis("Vertical");

            Vector3 move = transform.right * x + transform.forward * z;

            controller.Move(move * speed * Time.deltaTime);

            velocity.y += gravity * Time.deltaTime;

            controller.Move(velocity * Time.deltaTime);

            if (Input.GetButtonDown("Crouch"))
            {
                isCrouched = true;
                transform.localScale = new Vector3(1.3f, 0.8f, 1.3f);
            }
            else if(Input.GetButtonUp("Crouch"))
            {
                isCrouched = false;
                transform.localScale = new Vector3(1.3f, 1.3f, 1.3f);
            }
        }
    }
}