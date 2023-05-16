using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Genelate : MonoBehaviour
{
    [SerializeField] private GameObject _cube;
    
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 5; i < 100; i += 5)
        {
            Instantiate(_cube, new Vector3(0.0f, 1.0f, i), Quaternion.identity);
        }
    }
}
