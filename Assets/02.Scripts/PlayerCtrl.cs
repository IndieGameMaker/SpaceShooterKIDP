using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCtrl : MonoBehaviour
{
    private float v;
    private float h;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // 키보드 입력값을 받아오기
        v = Input.GetAxis("Vertical");  // -1.0f ~ 0.0f ~ +1.0f
        h = Input.GetAxis("Horizontal");

        // 전진 / 후진 처리
        transform.Translate(Vector3.forward * Time.deltaTime * v * 6.0f);
        // 좌우 이동처리
        transform.Translate(Vector3.right * Time.deltaTime * h * 6.0f);
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
