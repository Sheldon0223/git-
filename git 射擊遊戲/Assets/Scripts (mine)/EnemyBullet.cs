using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBullet : MonoBehaviour
{
    public GameObject ball; // 來源物件 (從 Unity 中拖入指定)
    public Transform shotSpawn;//子彈生成地點
    public float delay;//函數延遲
    public float fireRate;//開火延遲



    void Start()
    {
          InvokeRepeating ("Fire", delay, fireRate);
    }
    // Update is called once per frame
    void Update()
    {

    }
    void Fire ()
    {

        Instantiate (ball, shotSpawn.position, shotSpawn.rotation);
    }
}
