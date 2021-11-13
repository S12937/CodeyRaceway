using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NavMeshMovement : MonoBehaviour
{
    public Transform goal;
    private Animator animator;
    private NavMeshAgent agent;
    // Start is called before the first frame update
    void Start()
    {
        goal = getClosestObs();
        animator = GetComponentInChildren<Animator>();
        agent = GetComponent<NavMeshAgent>();
        agent.destination = goal.position;
    }
    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Obstacles")
        {
            Destroy(collision.gameObject);
            Destroy(gameObject);
            gameObject.SetActive(false);
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
    Transform getClosestObs()
    {
        GameObject[] obs = GameObject.FindGameObjectsWithTag("Obstacles");
        float closestDist = Mathf.Infinity;
        Transform goal = null;
        foreach(GameObject ob in obs)
        {
            float dist = Vector3.Distance(transform.position, ob.transform.position);
            if (dist<closestDist)
            {
                closestDist = dist;
                goal = ob.transform;
            } 
        }
        return goal;
    }
}