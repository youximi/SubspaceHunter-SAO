using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fly : MonoBehaviour
{
    public float speed = 25f; // 子弹飞行速度

    public float lifeSpan = 2f; // 生命期间为5秒
    // Start is called before the first frame update
    void Start()
    {
         Destroy(transform.gameObject,lifeSpan);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += transform.forward * speed * Time.deltaTime;
    }
}
