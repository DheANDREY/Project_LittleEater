using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coral : MonoBehaviour
{
    [SerializeField] private GameObject _prefabMakanan;
    private float _spawnCooldown;
    private float _spawnDuration = 1f;
    private GameObject _spawned;
    private int _countToDestroy = 8;

    /*void Start()
    {
        if (this.tag == "food3_coral")
        {
            _countToDestroy = 8;
        }
        if (this.tag == "food4_large_coral")
        {
            _countToDestroy = 16;
        }
    }*/

    // void Update()
    // {
    //     if (_spawnCooldown > 0)
    //     {
    //         _spawnCooldown -= Time.deltaTime;
    //     }
    //     else if (_spawned == null)
    //     {
    //         _spawnCooldown = _spawnDuration;
    //         _spawned = Instantiate(_prefabMakanan, transform.position, transform.rotation);
    //         _countToDestroy--;
    //         if (_countToDestroy <= 0)
    //         {
    //             Destroy(gameObject);
    //         }
    //     }
    // }
}
