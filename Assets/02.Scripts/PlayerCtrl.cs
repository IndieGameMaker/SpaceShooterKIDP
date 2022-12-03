using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCtrl : MonoBehaviour
{
    private float v;
    private float h;

    public float moveSpeed = 6.0f;

    // Animator 컴포넌트를 저장할 변수를 선언
    [SerializeField] private Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        // Animator 컴포넌트 추출해서 변수에 대입(할당)
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        // 키보드 입력값을 받아오기
        v = Input.GetAxis("Vertical");  // -1.0f ~ 0.0f ~ +1.0f
        h = Input.GetAxis("Horizontal");

        // 전진 / 후진 처리
        transform.Translate(Vector3.forward * Time.deltaTime * v * moveSpeed);
        // 좌우 이동처리
        transform.Translate(Vector3.right * Time.deltaTime * h * moveSpeed);

        // 애니메이션 컨트롤
        if (v == 0.0f && h == 0.0f) // AND 조건
        {
            // Idle 애니메이션
            animator.SetBool("Forward", false);
        }
        else
        {
            // RunF 애니메이션
            animator.SetBool("Forward", true);
        }
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
