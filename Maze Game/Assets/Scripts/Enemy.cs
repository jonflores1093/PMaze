using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour
{
    public NavMeshAgent agent;
    public Transform player;
    public LayerMask whatIsGround, whatIsPlayer;

    //Patroling
    public Vector3 walk;
    bool walkPointSet;
    public float walkPointRange;

    //States
    public bool playerInSightRange;

    void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
        agent = GetComponent<NavMeshAgent>();
    }

    void Update()
    {
        playerInSightRange = Physics.CheckSphere(transform.position, whatIsPlayer);

        if (!playerInSightRange) Patroling(); //if player isnt in sight then patrol
        if (playerInSightRange) ChasePlayer(); //if player is in sight then chase
    }

    //Will walk around until player is in sight
    private void Patroling() 
    {
        if (!walkPointSet) SearchWalkPoint();

        if (walkPointSet)
            agent.SetDestination(walk);

        Vector3 distanceToWalk = transform.position - walk;

        //walk reached
        if (distanceToWalk.magnitude < 1f)
            walkPointSet = false;
    }

    //Will walk until it sees the palyer
    private void SearchWalkPoint() 
    {
        //Calculate random point in range
        float randomZ = Random.Range(-walkPointRange, walkPointRange);
        float randomX = Random.Range(-walkPointRange, walkPointRange);

        walk = new Vector3(transform.position.x + randomX, transform.position.y, transform.position.z + randomZ);

        if (Physics.Raycast(walk, -transform.up, 2f, whatIsGround))
            walkPointSet = true;
    }

    //finds the position of the player and follows them
    private void ChasePlayer() 
    {
        agent.SetDestination(player.position);
    
    }
    

}
