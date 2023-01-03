using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBulletSpeed : MonoBehaviour
{
    Rigidbody rb;
    float lifeTime = 0; // 計時秒數
    private float speed = 100f ;
    // Start is called before the first frame update
    void Start()
    {
        // 設定一個持續的方向力，往面對方向（forward = +z)
        rb = GetComponent<Rigidbody>();
        rb.velocity = transform.TransformDirection(Vector3.forward*speed);
               // 計時三秒後刪除
        lifeTime += Time.deltaTime;
        if (lifeTime > 2)
        {
            Destroy(gameObject);
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
