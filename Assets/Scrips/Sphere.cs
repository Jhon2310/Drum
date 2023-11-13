using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class Sphere : MonoBehaviour
{
    [SerializeField] private GameObject _spherePrifab;
    [SerializeField] private Vector3 _spherePosition = new(0, 5, 5);

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {

            _spherePrifab.transform.position = _spherePosition;
            Instantiate(_spherePrifab);
        }
    }
}
