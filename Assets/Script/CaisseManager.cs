using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CaisseManager : MonoBehaviour
{
    public static CaisseManager instance;

    [Header("Compnent")]
    [SerializeField] private GameObject caisseItem;
    [SerializeField] private GameObject player;

    private int numberOfCaisse;
    public int currentCaisseDestroyed = 0;
    public bool tableauIsOn;

    private GameObject[] caisse;

    // Start is called before the first frame update
    void Start()
    {
        if (instance == null)
            instance = this;
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(currentCaisseDestroyed + " / " + numberOfCaisse);
        if (currentCaisseDestroyed == numberOfCaisse && tableauIsOn)
        {
            currentCaisseDestroyed = 0;
            tableauIsOn = false;
            GameManager.instance.gameIsOn = false;
            GameManager.score++;
        }
    }

    public void SpawnSomeCaisse()
    {
        int spawn = Random.Range(3, 6);
        numberOfCaisse = 0;
        for (int i = 0; i < spawn; i++)
        {
            int x = Random.Range(0, GameManager.taillePlateau);
            int y = Random.Range(0, GameManager.taillePlateau);

            Vector3 pos = new Vector3(x, y, 0);

            if (PlateauManager.itemInPlateau[x, y] == false && pos != player.transform.position)
            {
                Instantiate(caisseItem, pos, Quaternion.identity);
                PlateauManager.itemInPlateau[x, y] = true;
                numberOfCaisse++;
            }

            else
            {
                i--;
            }
        }
    }

    public void ResetCaisse()
    {
        caisse = GameObject.FindGameObjectsWithTag("Item");
        foreach (GameObject item in caisse)
        {
            Destroy(item);
        }
        currentCaisseDestroyed = 0;
    }
}
