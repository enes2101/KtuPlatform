using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponController : MonoBehaviour
{
    public bool onAttack=false;

    void Update()
    {
        //C ye basılırsa rengi değişsin
        if (Input.GetKeyDown(KeyCode.C))
        {
            GetComponent<Renderer>().material.color = Color.red;
            StartCoroutine(WaitAndChangeColor());
        }
        if (Input.GetKeyDown(KeyCode.Mouse0)&&onAttack==false)
        {
            onAttack = true;
            transform.rotation = Quaternion.Euler(0, 0, 45);
            StartCoroutine(WaitForAttack());
        }

    }

    IEnumerator WaitAndChangeColor()
    {
        yield return new WaitForSeconds(2);
        GetComponent<Renderer>().material.color = Color.white;
    }
    IEnumerator WaitForAttack()
    {
        yield return new WaitForSeconds(1);
        transform.rotation = Quaternion.Euler(0, 0, 0);
        onAttack = false;
    }

}
