using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hit_Reaction :  HitState_Global 
{
    
    public Hit_type hit_Type = Hit_type.无;
    public GameObject 击晕特效;

    public void Set_hit_type(Hit_type Type)
    {
        hit_Type = Type;
    }

    public Hit_type GetHit_Type()
    {
        return hit_Type;
    }

    public void Reset()
    {
        hit_Type = Hit_type.无;
        if(击晕特效.activeSelf) 击晕特效.SetActive(false);
    }

    




}
