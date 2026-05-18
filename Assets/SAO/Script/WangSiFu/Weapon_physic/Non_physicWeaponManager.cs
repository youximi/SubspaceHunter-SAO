using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Non_physicWeaponManager : MonoBehaviour
{
    private bool Weapon_inHand;
    public Transform WeaponSpeed_detectPoint;
    public float held_speed=8;
    private Vector3 pre_position;
    public float Cur_weaponSpeed;
    public float MAX_speed;
    // Start is called before the first frame update
    void Start()
    {
        pre_position=WeaponSpeed_detectPoint.transform.position;
    }

    public void Set_weapon_inhand()
    {
            Weapon_inHand=true;
    }

    public void Remove_weapon()
    {
            Weapon_inHand=false;
    }

    private void FixedUpdate() {
        Cur_weaponSpeed=(WeaponSpeed_detectPoint.transform.position-pre_position).magnitude/0.02f;
        if(MAX_speed<Cur_weaponSpeed)
        MAX_speed=Cur_weaponSpeed;
      /*  if(held_speed<speed)
        {
            audio_s.clip=挥剑片段;
            audio_s.Play();
        }*/
       //  GetComponent<AudioSource>().Play();

        pre_position=WeaponSpeed_detectPoint.position;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
