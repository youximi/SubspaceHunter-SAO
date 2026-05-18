using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Enter_game : MonoBehaviour
{
   public TextMeshProUGUI textMeshProUGUI;
   public void start2_switchScene()
    {
      textMeshProUGUI.text+="进入场景跳转函数动画\n";
       Scene_jump._DBInstance().start2_switchScene();
        
    }
}
