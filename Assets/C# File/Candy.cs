using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;


public class Candy : MonoBehaviour
{
    [SerializeField] GameObject[] candyPrefab;

    [SerializeField] float secondSpawn = 1f;

    [SerializeField] float minTras;

    [SerializeField] float maxTras;

    int Counter = 0;
        void Start()
    {
        StartCoroutine(candySpawn());

    }


        IEnumerator candySpawn()
        {
            while (true)
            {
                if (Counter != 15)
                {
                    var wanted = Random.Range(minTras, maxTras);
                    var position = new Vector3(wanted, transform.position.y);
                    GameObject gameObject = Instantiate(candyPrefab[Random.Range(0, candyPrefab.Length)],
                        position, Quaternion.identity);
                    yield return new WaitForSeconds(secondSpawn);
                    Counter++;
                    Destroy(gameObject, 5f);


                }
                else { break; }
            }
        }
   

}
