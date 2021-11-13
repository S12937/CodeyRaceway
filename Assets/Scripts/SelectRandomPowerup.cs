using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectRandomPowerup : MonoBehaviour
{
    public List<GameObject> powerupList;
    public int randomNumberInList;
    public GameObject chosenPowerup;
    private object animator;
    public int modifyXPosition;
    public GameObject shellPrefab;
    public GameObject breadNavPrefab;
    public GameObject spikeNavPrefab;

    //public Transform Prefab;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "ItemBoxes")
        {
            randomNumberInList = Random.Range(0, powerupList.Count);
            chosenPowerup = powerupList[randomNumberInList];
            if(randomNumberInList == 0)
            {
                shellPrefab.SetActive(true);
                breadNavPrefab.SetActive(false);
            }
            if(randomNumberInList == 1)
            {
                breadNavPrefab.SetActive(true);
                shellPrefab.SetActive(false);
            }
            if (randomNumberInList == 2)
            {
                spikeNavPrefab.SetActive(true);
                breadNavPrefab.SetActive(false);
                shellPrefab.SetActive(false);
            }
        }
        else 
        {
            breadNavPrefab.SetActive(false);
            shellPrefab.SetActive(false);
            spikeNavPrefab.SetActive(false);
        }
    }


    void Spawn()
    {
        gameObject.SetActive(true);
    }
    // Start is called before the first frame update
    void Start()
    {
        shellPrefab.SetActive(false);
        breadNavPrefab.SetActive(false);
        spikeNavPrefab.SetActive(false);
    }
    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            
            if(chosenPowerup = shellPrefab)
            { 
                Debug.Log(transform.forward);
                Instantiate(shellPrefab, transform.position + transform.forward*modifyXPosition, transform.rotation);
                chosenPowerup = null;
                shellPrefab.SetActive(false);
            }
            if (chosenPowerup = breadNavPrefab)
            {
                Debug.Log(transform.forward);
                Instantiate(breadNavPrefab, transform.position + transform.forward * modifyXPosition, transform.rotation);
                chosenPowerup = null;
                breadNavPrefab.SetActive(false);
            }
            if (chosenPowerup = spikeNavPrefab)
            {
                Debug.Log(transform.forward);
                Instantiate(spikeNavPrefab, transform.position + transform.forward * modifyXPosition, transform.rotation);
                chosenPowerup = null;
                spikeNavPrefab.SetActive(false);
            }
        }
    }
}
