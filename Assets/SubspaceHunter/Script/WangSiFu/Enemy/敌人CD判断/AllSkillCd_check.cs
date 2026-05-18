using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using BehaviorDesigner.Runtime;
using BehaviorDesigner.Runtime.Tasks;
using DG.Tweening;

public class AllSkillCd_check : EnemyAIAction
{
   public CommandExecutor commandexecutor;
   [Range(1,10)]
   public int 连续释放的技能数=4;
   public override void OnStart()
    {
        commandexecutor = this.GetComponent<CommandExecutor>();
    }

    public override TaskStatus OnUpdate()
    {
        int Cur_skillCount=0;
        foreach (var item in  commandexecutor.skillcd)
        {
            if(item>0) Cur_skillCount++;
        }
       
        return Cur_skillCount>=连续释放的技能数 ? TaskStatus.Success : TaskStatus.Failure;
    }

    public override void OnEnd()
    {
        
    }
}
