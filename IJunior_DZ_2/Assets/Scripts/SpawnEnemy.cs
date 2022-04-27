using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemy : MonoBehaviour
{
    private const string _spawn = nameof(Spawn);
    public GameObject Enemy;

    private void Update()
    {
        if (IsInvoking(_spawn) == false)
        {
            Invoke(_spawn, 2);
        }
    }

    private void Spawn()
    {
        Instantiate(Enemy, transform.position, Quaternion.identity);
    }
}
