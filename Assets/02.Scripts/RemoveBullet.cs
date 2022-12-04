using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RemoveBullet : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}


/*  충돌 콜백함수 (충돌 이벤트)

    IsTrigger 언체크일 경우 
        void OnCollisionEnter()  // 충돌시 1회 호출
        void OnCollisionStay() // 충돌하고 있는 동안 계속 호출(0.02f)
        void OnCollisionExit() // 충돌해제시 1회 호출

    IsTrigger 체크일 경우
        void OnTriggerEnter()
        void OnTriggerStay()
        void OnTriggerExit()
*/