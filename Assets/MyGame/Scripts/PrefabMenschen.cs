using UnityEngine;

public class SitzplanErstellen : MonoBehaviour
{
    [SerializeField] private GameObject sitzPrefab; // Dein Sitzplatz-Prefab
    [SerializeField] private GameObject myParent;
    public int reihen = 4;        // Anzahl der Reihen
    public int spalten = 5;       // Anzahl der Spalten
    [SerializeField] private float abstandX = 110f; // Horizontaler Abstand
    [SerializeField] private float abstandY = 110f; // Vertikaler Abstand
    public int maxSchueler = 20;  // Maximale Anzahl an Sch�lern

    void Start()
    {
        int schuelerZaehler = 0; // Z�hlt die erstellten Sitze

        for (int i = 0; i < reihen; i++)
        {
            for (int j = 0; j < spalten; j++)
            {
                // Wenn die maximale Anzahl an Sch�lern erreicht ist, die Schleife beenden
                if (schuelerZaehler >= maxSchueler)
                {
                    Debug.Log("20 Sitze erstellt, Script beendet.");
                    return;
                }

                // Position f�r den Sitz
                Vector2 position = new Vector2(j * abstandX, -i * abstandY);

                // Instanziere den Sitz an der errechneten Position
                GameObject neuerSitz = Instantiate(sitzPrefab, position, Quaternion.identity);

                // Setze das neu erstellte Sitz-Objekt als Kind des Canvas (f�r UI)
                neuerSitz.transform.SetParent(myParent.transform, false);

                // Sch�ler Z�hler erh�hen
                schuelerZaehler++;

                Debug.Log("Sitz erstellt: " + schuelerZaehler); // Test ob funktioniert
            }
        }
    }
}
