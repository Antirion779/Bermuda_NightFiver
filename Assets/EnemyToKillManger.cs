using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyToKillManger : MonoBehaviour
{
    public static EnemyToKillManger instance;

    [SerializeField]
    GameObject enemy;

    public bool killEnemyObjectif;

    private GameObject[] enemyInGame;
    private GameObject[] bulletInGame;
    private GameObject[] enemyBulletInGame;

    private void Start()
    {
        if (instance == null)
            instance = this;
    }

    public void SpawnEnemy()
    {
        Vector3 pos = new Vector3(0, 0, 0);
        int x = 0;
        int y = 0;

        while (pos == new Vector3(GameManager.positionPlayerX, GameManager.positionPlayerY, 0) || PlateauManager.itemInPlateau[x, y] == true || pos == new Vector3(GameManager.positionPlayerX, y, 0) || pos == new Vector3(x, GameManager.positionPlayerY, 0))
        {
            x = Random.Range(0, GameManager.taillePlateau);
            y = Random.Range(0, GameManager.taillePlateau);
            pos = new Vector3(x, y, 0);
        }
        Instantiate(enemy, pos, Quaternion.identity);
    }
    public void SpawnEnemy2()
    {
        Vector3 pos = new Vector3(0, 0, 0);
        int x = 0;
        int y = 0;

        while (pos == new Vector3(GameManager.positionPlayerX, GameManager.positionPlayerY, 0) || PlateauManager.itemInPlateau[x, y] == true || pos == new Vector3(GameManager.positionPlayerX, y, 0) || pos == new Vector3(x, GameManager.positionPlayerY, 0))
        {
            x = Random.Range(0, GameManager.taillePlateau);
            y = Random.Range(0, GameManager.taillePlateau);
            pos = new Vector3(x, y, 0);
        }
        Instantiate(enemy, pos, Quaternion.identity);
    }
    public void SpawnEnemy3()
    {
        Vector3 pos = new Vector3(0, 0, 0);
        int x = 0;
        int y = 0;

        while (pos == new Vector3(GameManager.positionPlayerX, GameManager.positionPlayerY, 0) || PlateauManager.itemInPlateau[x, y] == true || pos == new Vector3(GameManager.positionPlayerX, y, 0) || pos == new Vector3(x, GameManager.positionPlayerY, 0))
        {
            x = Random.Range(0, GameManager.taillePlateau);
            y = Random.Range(0, GameManager.taillePlateau);
            pos = new Vector3(x, y, 0);
        }
        Instantiate(enemy, pos, Quaternion.identity);
    }
}
