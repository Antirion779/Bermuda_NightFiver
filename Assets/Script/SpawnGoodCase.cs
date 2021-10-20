using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnGoodCase : MonoBehaviour
{
    public static SpawnGoodCase instance;

    [Header("Compnent")]
    [SerializeField] private GameObject goodCase;
    [SerializeField] private GameObject player;

    [Header("Variables")]
    //[SerializeField] private Text numberOfItemText;

    private int numberOfCase;
    public int currentCaseTouch = 0;
    public bool tableauIsOn;

    private GameObject[] caseGood;

    private void Start()
    {
        if (instance == null)
            instance = this;
    }

    private void Update()
    {
        if (currentCaseTouch == numberOfCase && tableauIsOn)
        {
            currentCaseTouch = 0;
            tableauIsOn = false;
            GameManager.instance.gameIsOn = false;
            GameManager.score++;
        }
    }

    public void SpawnAGoodCase()
    {
        int spawn = Random.Range(3, 6);
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

    public void ResetCase()
    {
        caseGood = GameObject.FindGameObjectsWithTag("GoodCase");
        foreach (GameObject item in caseGood)
        {
            Destroy(item);
        }
        currentCaseTouch = 0;
    }
}
