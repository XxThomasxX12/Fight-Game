using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

namespace group1
{
    public class PathFindingAgent : MonoBehaviour
    {
        public bool TargetPlayerableCharacter;
        public GameObject target;
        NavMeshAgent navMeshAgent;

        private void Awake()
        {
            navMeshAgent = GetComponent<NavMeshAgent>();
        }

        public void GoToTarget()
        {
            if (TargetPlayerableCharacter)
            {
                target = (GameObject.Find("SuitedMan"));
            }
            
            navMeshAgent.SetDestination(target.transform.position);
        }
    }
}

