using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public Transform goal;
    void Start()
    {
        // Получение компонента агента
        UnityEngine.AI.NavMeshAgent agent
            = GetComponent<UnityEngine.AI.NavMeshAgent>();
        // Указаие точки назначения
        agent.destination = goal.position;
    }
}
