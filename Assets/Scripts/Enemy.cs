using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour
{

    private enum EnemyState
    {
        patrolling,
        
        attack,

        search,

    }

    private EnemyState _currentState;

    private NavMeshAgent _enemyAgent;

    

    [SerializeField] private [] patrolPoints;

    void Awake()
    {
        _currentState = GetComponent<EnemyState>();
        _enemyAgent = GetComponent<NavMeshAgent>();
    }
    
    


    

    

}
