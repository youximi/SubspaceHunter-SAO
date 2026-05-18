using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vedio_switch : MonoBehaviour
{
        public GameObject[] child_vedio;
        public int index=0;

        private void Update() {
            if(OVRInput.GetDown(OVRInput.Button.Two))
            {
                    switch_2Next();
            }
        }
        public void switch_2Next()
        {
             if(++index<child_vedio.Length)
             {
                 child_vedio[index-1].SetActive(false);
                 child_vedio[index].SetActive(true);
             }
             else
             {
                 Destroy(transform.gameObject);
             }
        }
}
