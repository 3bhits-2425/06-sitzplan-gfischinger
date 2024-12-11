using JetBrains.Annotations;
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
        int studentIndex = 0; // Startindex für Studenten
        Vector2 fixedSize = new Vector2(1f, 1f); // gleichmäßige Bild größe

        for (int row = 0; row < tableLayout.rows; row++)
        {
            for (int col = 0; col < tableLayout.columns; col++)
            {
                Vector3 tablePosition = new Vector3(col * tableLayout.tableSpacing, 0, row * tableLayout.tableSpacing);

                // Spawn tables
                GameObject table = Instantiate(tablePrefab, tablePosition, Quaternion.identity, transform);

                // Find chair positions
                Transform posLeft = table.transform.Find("ChairPos1");
                Transform posRight = table.transform.Find("ChairPos2");

                // Instantiate left chair
                if (studentIndex < students.Length)
                {
                    GameObject leftChair = Instantiate(chairPrefab, posLeft.position, Quaternion.Euler(0, 180, 0), transform);
                    Transform leftChild = leftChair.transform.Find("StudentPos"); // Check for correct name
                    if (leftChild != null)
                    {
                        SpriteRenderer leftChairRenderer = leftChild.GetComponent<SpriteRenderer>();

                            leftChairRenderer.sprite = students[studentIndex].studentImage; // Setze das Bild
                            leftChairRenderer.size = fixedSize; // Ensure the sprite size is consistent
                            studentIndex++;

                    }
                    else
                    {
                        Debug.Log("StudenPos not found in leftChair!");
                    }
                }

                // Instantiate right chair
                if (studentIndex < students.Length)
                {
                    GameObject rightChair = Instantiate(chairPrefab, posRight.position, Quaternion.Euler(0, 180, 0), transform);
                    Transform rightChild = rightChair.transform.Find("StudentPos"); // Ensure name matches prefab
                    if (rightChild != null)
                    {
                        SpriteRenderer rightChairRenderer = rightChild.GetComponent<SpriteRenderer>();
                        
                            rightChairRenderer.sprite = students[studentIndex].studentImage; // Setze das Bild
                            rightChairRenderer.size = fixedSize; // Ensure the sprite size is consistent
                            studentIndex++;

                    }
                    else
                    {
                        Debug.Log("StudentPos not found in rightChair!");
                    }
                }
            }
        }
    }

    void Update()
    {
    }
}
