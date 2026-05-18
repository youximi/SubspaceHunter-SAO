using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Anime_controllerShoot : MonoBehaviour
{
    public Gun_Controller gun_Controller;


    public void shoot()
    {
        gun_Controller.动画子弹射出();
    }

    public void Reset_shoot()
    {
        gun_Controller.动画射出结束();
    }

    
  
  
}
