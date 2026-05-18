using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stand_mask : MonoBehaviour
{
    public bool is_autoAcitvate;
    public string[] 遮罩布尔名称;

    /// <summary>
    /// Start is called on the frame when a script is enabled just before
    /// any of the Update methods is called the first time.
    /// </summary>
    void Start()
    {
            if(is_autoAcitvate)
            Activate_maskAnime();
    }
    public void Activate_maskAnime()
    {
        foreach (var item in 遮罩布尔名称)
        {
            GetComponent<Animator>().SetBool(item ,true);
        }
         
    }
     public void DeActivate_maskAnime()
    {
         foreach (var item in 遮罩布尔名称)
        {
            GetComponent<Animator>().SetBool(item ,false);
        }
    }
}
