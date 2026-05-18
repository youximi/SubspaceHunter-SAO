using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Start2_ger : MonoBehaviour
{
    public GameObject player_ui;
    
    private void OnEnable() {
        if(null!=player_ui) player_ui.SetActive(true);
    }

}
