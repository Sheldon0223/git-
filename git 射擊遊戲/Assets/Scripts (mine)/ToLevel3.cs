using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; // 添加這行載入場景管理類別


public class ToLevel3 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    // 當碰撞(Trigger)發生時
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "sus") 
        {
            // 切換場景到 Level3
        SceneManager.LoadScene("Level3");
        }
    }
}
