using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomManager : MonoBehaviour
{
    [SerializeField] private TableLayoutData tableLayout; // Ref zu TableLayout ScriptableObject
    [SerializeField] public StudentData[] students;
    [SerializeField] private GameObject tablePrefab; // Prefab für Tisch
    [SerializeField] private GameObject chairPrefab; // Prefab für Stuhl


    void Start()
    {
        for(int row = 0; row < tableLayout.rows; row++)
        {
            for(int col = 0; col  < tableLayout.columns; col++)
            {
                Vector3 tablePosition = new Vector3(col * tableLayout.tableSpacing, 0, row * tableLayout.tableSpacing);

                //Tische platzieren
                GameObject table = Instantiate(tablePrefab, tablePosition, Quaternion.identity, transform);
            }

            
        }
    }

    void Update()
    {
        
    }
}
