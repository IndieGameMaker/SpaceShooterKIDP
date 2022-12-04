using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire : MonoBehaviour
{
    // Bullet 프리팹을 저장할 변수
    [SerializeField] private GameObject bulletPrefab;
    // 총알을 생성할 위치정보를 저장할 변수
    [SerializeField] private Transform firePos;

    // 소리를 발생시키는 AudioSource 컴포넌트를 저장할 변수
    [SerializeField] private AudioSource audio;
    // 총알 효과음 음원파일(AudioClip)
    [SerializeField] private AudioClip fireSfx;

    void Update()
    {
        if (Input.GetMouseButtonDown(0) == true)
        {
            // 총알 생성
            // Instantiate (생성할객체, 생성좌표, 생성각도);
            Instantiate(bulletPrefab, firePos.position, firePos.rotation);
        }
    }
}
