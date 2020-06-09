using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class ParrotMovement : MonoBehaviour
{

    public Transform player;
    public float movementSpeed;
    public float currentY;

    public NavMeshAgent agent;

    public int currentX;
    public int currentZ;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Physics.autoSimulation = false;

        agent.SetDestination(new Vector3(player.position.x - (int) 2.5, player.position.y - (int) 2.5, player.position.z - (int) 2.5));
    }
}
