using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using BehaviorDesigner.Runtime;
using BehaviorDesigner.Runtime.Tasks;
using DG.Tweening;
using UnityEngine.InputSystem.Interactions;

public class Interrupt_Hit : EnemyAIConditional
{
    //韧性归零普通攻击击退
    //击退技能
    //击飞技能
    private Input_behave input_Behave;
   public override void OnStart()
    {
        input_Behave = GetComponent<Input_behave>();
    }
    public bool res=false;
    public override TaskStatus OnUpdate()
    {
        Debug.Log("进入攻击1");
       if(input_Behave.Get_res())
       {
         Debug.Log("进入攻击2");
            res = true;
       }
       Debug.Log("进入攻击3");
        
        return res? TaskStatus.Failure:TaskStatus.Success;
    }

    public override void OnEnd()
    {
        
    }
}
