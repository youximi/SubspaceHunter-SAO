using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stage_Controller : MonoBehaviour
{
    public GameObject[] Close_GameObject_set;
    public GameObject[] Open_GameObject_set;
    public Transform Player_location;
    public float no_pass_z;
 

    // Start is called before the first frame update
    public void  Check_player_isPass()
    {
                    print("判断进入");
            if(Player_location.position.z>no_pass_z)
            {
                        print("判断大于");
                        for(int flag=0;flag<Close_GameObject_set.Length;flag++)
                        {
                            Close_GameObject_set[flag].SetActive(false);
                        }
                        for(int flag=0;flag<Open_GameObject_set.Length;flag++)
                        {
                            Open_GameObject_set[flag].SetActive(true);
                        }
            }
    }
}
