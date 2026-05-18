using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class woosh_fater : MonoBehaviour
{
    public woosh_controller 武器声音控制;
    public woosh_controller 脚步声音控制;

   public void play_WeaponWoosh()
   {
        武器声音控制.play_WeaponWoosh();
       
   }

   public void play_FootSounds()
   {
     if(null!=脚步声音控制)
        脚步声音控制.play_WeaponWoosh();
       
   }
    
}
