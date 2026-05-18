using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Magic_attack_controller : MonoBehaviour
{
    public GameObject Magic_keepAttack;
    public GameObject 定点范围攻击;
    public float 范围攻击存在时间=3f;

    public GameObject 定点持续范围攻击;
    public float 范围持续攻击存在时间=3f;
    

    public void start_magicAttack()
    {
        Magic_keepAttack.SetActive(true);
    }

    public void stop_magicAttack()
    {
        Magic_keepAttack.SetActive(false);
    }

    public void Deal_range_attack()
    {
        GameObject player=GameObject.FindWithTag("Player_body").gameObject;
        Vector3 player_feet=new Vector3(player.transform.position.x,0,player.transform.position.z);
        GameObject temp_magic=Instantiate(定点范围攻击,player_feet,Quaternion.identity);
        Destroy(temp_magic,范围攻击存在时间);
    }

    public void Deal_rangeKeep_attack()
    {
        GameObject player=GameObject.FindWithTag("Player_body").gameObject;
        Vector3 player_feet=new Vector3(player.transform.position.x,0,player.transform.position.z);
        GameObject temp_magic=Instantiate(定点持续范围攻击,player_feet,Quaternion.identity);
        Destroy(temp_magic,范围持续攻击存在时间);
    }


}
