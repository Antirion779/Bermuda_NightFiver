using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PickUpItem : MonoBehaviour
{
    public AudioSource audioSource;

    [SerializeField] private ItemSpawn currentItemPickedUp;
    [SerializeField] private SpawnGoodCase currentCaseTouch;
    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Item")
        {
            audioSource.Play();
            //Debug.Log("+1");
            currentItemPickedUp.GetComponent<ItemSpawn>().currentItemPickedUp++;
            Destroy(col.gameObject);
        }
        else if (col.gameObject.tag == "GoodCase")
        {
            currentCaseTouch.GetComponent<SpawnGoodCase>().currentCaseTouch++;
            col.gameObject.GetComponent<SpriteRenderer>().color = Color.red;
        }
    }
}
