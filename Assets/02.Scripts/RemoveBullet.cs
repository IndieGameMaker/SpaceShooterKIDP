using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RemoveBullet : MonoBehaviour
{
    void OnCollisionEnter(Collision coll)
    {
        Debug.Log("aaa");
        // 충돌한 객체의 태그를 비교
        if (coll.gameObject.tag == "BULLET")
        {
            // 충돌한 총알을 삭제
            Destroy(coll.gameObject);
        }
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

/*  Sound

    AudioListener : 소리를 듣는 역할, 하나만 존재

    AudioSource : 소리를 발생시키는 역할, 복수개가 가능

*/