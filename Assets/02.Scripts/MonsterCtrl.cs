using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class MonsterCtrl : MonoBehaviour
{
    [SerializeField] private NavMeshAgent agent;

    // 주인공의 Transform 컴포넌트를 저장할 변수
    [SerializeField] private Transform playerTr;


    void Start()
    {
        agent = GetComponent<NavMeshAgent>();

        // 플레이어를 검색
        // 이름으로 검색하는 방법 : GameObject playerObj = GameObject.Find("Player");
        // Tag를 이용해서 검색
        GameObject playerObj = GameObject.FindGameObjectWithTag("Player");

        if (playerObj != null)
        {
            playerTr = playerObj.GetComponent<Transform>();
        }
    }

    void Update()
    {
        float distance = Vector3.Distance(transform.position, playerTr.position);

        if (distance <= 10.0f)
        {
            // agent의 목적지를 지정
            agent.SetDestination(playerTr.position);
        }
        else
        {
            agent.isStopped = true;
        }
    }
}
