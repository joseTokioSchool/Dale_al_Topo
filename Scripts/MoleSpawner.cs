using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.Experimental.AssetDatabaseExperimental.AssetDatabaseCounters;

public class MoleSpawner : MonoBehaviour
{
    [SerializeField] GameObject mole;
    int randomX, randomY;
    bool isMole;
    [SerializeField] float[] x = { -3f, 0f, 3f };
    [SerializeField] float[] y = { -2f, 0f, 2f };

    void Start()
    {
        StartCoroutine(SpawnerMole());
    }

    void Update()
    {

    }
    void Creador()
    {
        randomX = Random.Range(0, 3);
        randomY = Random.Range(0, 3);
        Instantiate(mole, transform.position = new Vector3(x[randomX], y[randomY], 0), Quaternion.identity);
        isMole = true;
    }
    void Destructor()
    {
        Destroy(GameObject.FindGameObjectWithTag("Player"), 0.9f);
        isMole = false;
    }
    public IEnumerator SpawnerMole()
    {
        while (true)
        {
            if (!isMole) Creador();
            else if (isMole) Destructor();
            yield return new WaitForSeconds(0.6225f);
        }

    }
}
