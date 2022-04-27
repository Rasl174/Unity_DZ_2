using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemy : MonoBehaviour
{
    [SerializeField] private int _timeWait;
    public GameObject Enemy;

    private void Update()
    {
        if (IsInvoking("Spawn") == false)
        {
            Invoke("Spawn", 2);
        }
    }

    private void Spawn()
    {
        Instantiate(Enemy, transform.position, Quaternion.identity);
    }
}
