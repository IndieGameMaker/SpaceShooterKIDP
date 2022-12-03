using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCtrl : MonoBehaviour
{
    private float v;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // 키보드 입력값을 받아오기
        v = Input.GetAxis("Vertical");  // -1.0f ~ 0.0f ~ +1.0f
        Debug.Log("v=" + v);


        transform.Translate(Vector3.forward * v * 0.01f);
    }
}

/*
    Vector3 (x, y, z)
    - 3차원 공간에서의 방향
    - 좌푯값

    Vector3.forward = Vector3(0, 0, 1)
    Vector3.up      = Vector3(0, 1, 0)
    Vector3.right   = Vector3(1, 0, 0)

    Vector3.zero = Vector3(0, 0, 0)
    Vector3.one = Vector3(1, 1, 1)
*/
