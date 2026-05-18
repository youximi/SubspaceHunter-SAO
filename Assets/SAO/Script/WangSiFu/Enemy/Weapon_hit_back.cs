using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon_hit_back : MonoBehaviour
{
     public Animator enemy_animator;
    public AnimationCurve animaSpeedCur;
    private float animaSpeed;
    private float timer;
    private bool beBlock;
    public float hit_weaponBack_held=0f;
    
   



    public void play_hitBack()
    {
        StartCoroutine(BeBlocked());
    }

    


     public IEnumerator BeBlocked()

        {
             //   print("编号进入触发2");
           // OnAnimation_CloseWeaponCollier();//关闭武器碰撞盒

            beBlock = true;

            timer = 0;

            while (timer < 0.8f) //弹反动画播放0.8s

            {

                 SetAnimaSpeed();

                 yield return new WaitForFixedUpdate();

            }

            beBlock = false;

           // OnAnimation_RandomAState();//随机下一个状态

            enemy_animator.SetFloat("AniSpeed", 1); //播放速度恢复正常

        } 

         //设置格挡回弹时的速度

    public void SetAnimaSpeed()

    {
       // print("编号3");
        timer += Time.fixedDeltaTime; //计时

        animaSpeed = animaSpeedCur.Evaluate(timer); //读取曲线数据

        enemy_animator.SetFloat("AniSpeed", animaSpeed); //设置播放速度

    } 
}
