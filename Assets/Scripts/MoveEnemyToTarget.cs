using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class MoveEnemyToTarget : MonoBehaviour
{
    [SerializeField] private List<Transform> listGatePosition;

    private Transform gate;
    private NavMeshAgent agent;

    private void Awake()
    {
        agent = GetComponent<NavMeshAgent>();
       
    }

    private void Start()
    {
        gate = listGatePosition[Random.Range(0, listGatePosition.Count)];
      
    }
    // Update is called once per frame
    void Update()
    {
        
        agent.destination = gate.transform.position;
    }
}
