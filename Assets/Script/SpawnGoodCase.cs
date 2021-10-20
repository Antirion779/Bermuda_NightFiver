using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnGoodCase : MonoBehaviour
{
    public static SpawnGoodCase instance;

    [Header("Compnent")]
    [SerializeField] private GameObject goodCase;
    [SerializeField] private GameObject player;

    private int numberOfCase;
    public int currentCaseTouch = 0;
    public bool tableauIsOn;

    private void Start()
    {
        if (instance == null)
            instance = this;
    }

    private void Update()
    {
        
    }

    public void SpawnAGoodCase()
    {
        int spawn = Random.Range(4, 7);
        numberOfCase = 0;
        for (int i = 0; i < spawn; i++)
        {
            int x = Random.Range(0, GameManager.taillePlateau);
            int y = Random.Range(0, GameManager.taillePlateau);

            Vector3 pos = new Vector3(x, y, 0);

            if (PlateauManager.itemInPlateau[x, y] == false && pos != player.transform.position)
            {
                Instantiate(goodCase, pos, Quaternion.identity);
                PlateauManager.itemInPlateau[x, y] = true;
                numberOfCase++;
            }

            else
            {
                i--;
            }

            //Debug.Log(i);
        }
    }
}
