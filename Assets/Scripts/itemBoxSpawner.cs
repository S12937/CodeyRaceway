using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class itemBoxSpawner : MonoBehaviour
{
    public GameObject itemBox;
    public int numberOfBoxes;
    public int modifyXPosition;
    void Start()
    {
        for (int i = 0; i < numberOfBoxes; i++)
        {
            GameObject itemBoxClone = Instantiate(
                itemBox,
                transform.position+i*transform.forward*modifyXPosition,
                transform.rotation);
        }
    }
}