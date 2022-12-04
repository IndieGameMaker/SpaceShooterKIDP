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
    [SerializeField] private new AudioSource audio;
    // 총알 효과음 음원파일(AudioClip)
    [SerializeField] private AudioClip fireSfx;

    void Update()
    {
        if (Input.GetMouseButtonDown(0) == true)
        {
            FireBullet();
        }
    }

    void FireBullet()
    {
        // 총알 생성
        // Instantiate (생성할객체, 생성좌표, 생성각도);
        Instantiate(bulletPrefab, firePos.position, firePos.rotation);

        // 사운드 발생
        // AudioSource.Play() -> BGM
        // AudioSource.PlayOneShot() -> 중첩해서 소리를 발생시킬수 있음.
        audio.PlayOneShot(fireSfx);
    }
}
