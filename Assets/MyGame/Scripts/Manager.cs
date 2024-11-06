using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour
{
    [SerializeField] private GameObject myPrefab;
    [SerializeField] private GameObject myParent;

    void Start()
    {
        for (int i = 0; i < 100; i++)
        {
            Instantiate(myPrefab, myParent.transform);
        }
        
    }
}
