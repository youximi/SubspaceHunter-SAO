using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using BehaviorDesigner.Runtime;
using BehaviorDesigner.Runtime.Tasks;
using DG.Tweening;

public class ActionCount : EnemyAIConditional
{
    public enum CountType{
        闪避,
        近距离行动
    }
    public CommandExecutor commandexecutor;
    public CountType count类型 = CountType.闪避;
  
    // Start is called before the first frame update
    public override void OnStart()
    {
        commandexecutor = this.GetComponent<CommandExecutor>();
    }

    public override TaskStatus OnUpdate()
    {
        
         if(count类型==CountType.闪避)
        return commandexecutor.Avoidence_CD <= 0 ? TaskStatus.Success : TaskStatus.Failure;
        else if(count类型==CountType.近距离行动)
        return commandexecutor.NearAction_CD <= 0 ? TaskStatus.Success : TaskStatus.Failure;

        return TaskStatus.Failure;
    }

    public override void OnEnd()
    {
        
    }
}
