using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

namespace group1
{
    public class EnemyFollow : MonoBehaviour
    {

        public NavMeshAgent enemy;
        public Transform Player;
        public Transform RestartPoint;
        public GameObject Spawn;

        // Update is called once per frame
        void Update()
        {
            enemy.SetDestination(Player.position);

            if (Punkte.scoreCount == 0)
            {
                GetComponent<NavMeshAgent>().speed = 1f;
            }
            if (Punkte.scoreCount == 1)
            {
                GetComponent<NavMeshAgent>().speed = 2f;
            }
            if (Punkte.scoreCount == 2)
            {
                GetComponent<NavMeshAgent>().speed = 4f;
            }
            if (Punkte.scoreCount == 3)
            {
                GetComponent<NavMeshAgent>().speed = 8f;
            }
            if (Punkte.scoreCount == 4)
            {
                GetComponent<NavMeshAgent>().speed = 1000f;
                GetComponent<NavMeshAgent>().acceleration = 1000f;
                Player.position = RestartPoint.position;
                Destroy(Spawn);

            }

        }
    }
}
