using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShellMovement : MonoBehaviour
{
    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Obstacles"))
        {
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }
    }
        // Update is called once per frame
        void Update()
        {

        }
    
}