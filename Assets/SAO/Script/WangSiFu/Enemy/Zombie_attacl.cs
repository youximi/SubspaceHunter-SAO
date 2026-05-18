using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zombie_attacl : MonoBehaviour
{
    public float minus_hp_amount =10f;
    private void OnTriggerEnter(Collider other) {
        print("碰到的其它物体是"+other.gameObject.name);
        if(other.tag=="Player_body")
        {
            print("碰到玩家");//打到玩家扣血
            other.transform.GetComponent<Player_managerV2>().Minus_Hp(minus_hp_amount,"拳击");
            transform.gameObject.SetActive(false);
        }
    }

}
