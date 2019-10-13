using UnityEngine;
using UnityEngine.AI;

public class Agent : MonoBehaviour
{
    public Transform goal;

    void Start()
    {
        NavMeshAgent agent = GetComponent<NavMeshAgent>();
        agent.destination = goal.position;
    }

    void OnTriggerEnter(Collider collision)
    {
        
        if(collision.gameObject.tag == "Dead")
        {
            Destroy(gameObject);
        }

    }
}