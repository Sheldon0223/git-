using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BulletLevel2 : MonoBehaviour
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

    }

    // Update is called once per frame
    void Update()
    {
         // 計時三秒後刪除
        lifeTime += Time.deltaTime;
        if (lifeTime > 3)
        {
            Destroy(gameObject);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        // 當碰撞到 tag 為 Enemy 的物件
        if (other.gameObject.tag == "Enemy")
        {
            // 刪除物件(設為停用、並移除)
            other.gameObject.SetActive(false);
            Destroy(other.gameObject);


            // 判斷是否過關
            // 先取得目前所有 Tag 為 Enemy 的物件陣列
            GameObject[] objs = GameObject.FindGameObjectsWithTag("Enemy");

            // 如果陣列長度為0 （陣列內沒東西）
            if (objs.Length == 0)
            {
                // 切換到下一關
                SceneManager.LoadScene("Level3");
            }
        }
    }
}
