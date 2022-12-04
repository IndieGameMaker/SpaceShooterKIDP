using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class Barrel : MonoBehaviour
{
    [SerializeField] private new MeshRenderer renderer;
    public Texture[] textures;

    // Start is called before the first frame update
    void Start()
    {
        renderer = GetComponentInChildren<MeshRenderer>();

        int index = Random.Range(0, textures.Length); // 0, 1, 2
        renderer.material.mainTexture = textures[index];
    }
}

/*
    Random.Range(min, max)

    Random.Range(0, 10) -> 0, 1, 2, ..., 9
    Random.Range(0.0f, 10.0f) -> 0.0f ~ 10.0f

*/