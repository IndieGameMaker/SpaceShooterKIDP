using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCtrl : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // transform.position = transform.position + new Vector3(0, 0, 0.01f);

        // transform.position += new Vector3(0, 0, 0.01f);

        // transform.position += Vector3.forward * 0.01f;

        transform.Translate(Vector3.forward * 0.01f);
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
