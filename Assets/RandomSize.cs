using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSize : MonoBehaviour
{
    public int size;

    void Start()
    {
        transform.localScale = (Vector3.one * Random.Range(1, size));
    }

}
