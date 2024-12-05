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
            for(int col = 0; col  < tableLayout.column; col++)
            {
                Vector3 tablePosition = new Vector3(col * tableLayout.tableSpacing, 0, row * tableLayout.tableSpacing);

                // spawn tables
                GameObject table = Instantiate(tablePrefab, tablePosition, Quaternion.identity, transform);


                // spawn chairs
                Transform posLeft = table.transform.Find("ChairPos1");
                Transform posRight = table.transform.Find("ChairPos2");

                // Instantiate chairs
                Instantiate(chairPrefab, posLeft.position, Quaternion.Euler(0,180,0), transform);
                Instantiate(chairPrefab, posRight.position, Quaternion.Euler(0, 180, 0), transform);


            }

            
        }
    }

    void Update()
    {
        
    }
}
