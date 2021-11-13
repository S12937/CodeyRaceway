using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class itemBoxFeatures : MonoBehaviour
{
    private object animator;

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            gameObject.SetActive(false);
            Invoke("Respawn", 5);
        }
    }
    // Start is called before the first frame update
    void Respawn()
    {
        gameObject.SetActive(true);
    }

   

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.forward, Time.deltaTime * 50f);
    }
}
