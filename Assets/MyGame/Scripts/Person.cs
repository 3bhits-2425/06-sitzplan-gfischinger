using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Person : MonoBehaviour
{
    [SerializeField] private GameObject myPrefab;


    void Start()
    {
        Instantiate(myPrefab);
    }
}