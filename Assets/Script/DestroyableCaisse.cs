using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyableCaisse : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "Bullet")
        {
            Destroy(col.gameObject);
        }
        CaisseManager.instance.currentCaisseDestroyed++;
        Destroy(gameObject);
    }
}
