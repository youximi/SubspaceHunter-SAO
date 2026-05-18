using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AR_scen_controller : MonoBehaviour
{
    public GameObject[] Activate_Set;
    public bool is_close_ARLight;
    private GameObject Temp_light;
    
    // Start is called before the first frame update
    void Start()
    {
        if(is_close_ARLight) Close_defual_light();
        Activate_AR_set();
    }

    private void Close_defual_light()
    {
        Temp_light = GameObject.FindWithTag("AR_light");
        if(null!=Temp_light)
        Temp_light.SetActive(false);
    }

    private void Activate_AR_set()
    {
        if(SceneManager.GetActiveScene().name == "AR")
        {
            foreach (var item in Activate_Set)
            {
                item.SetActive(true);
            }
        }
    }

    public void Recovery_AR_defultLight()
    {
       
        if(null!=Temp_light) Temp_light.SetActive(true);
    }

    
}
