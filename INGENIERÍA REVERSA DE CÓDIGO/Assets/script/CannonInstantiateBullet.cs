using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonInstantiateBullet : MonoBehaviour
{
    [SerializeField] GameObject bullet;
    float tiempo = 0f;

    void Start()
    {
        
    }


    void Update()
    {
        // Puse esto porque no s� qu� va a pasar si la variable tiempo no para de sumarse y se vuelve muy muy grande �pasar�a algo?
        if (tiempo < 1)
        {
            tiempo += Time.deltaTime;
        }
        //

        //�qu� diferencia hay entre  Input.GetKeyDown("j")  y  Input.GetKeyDown(KeyCode.K)?
        //Tambi�n encontr� Input.GetButton(); pero no logr� hacerlo funcionar, creo que hay que ir a input manager y hacer algo
        if (Input.GetKeyDown("j") && tiempo >= 1)
        {
            Clone();
            tiempo = 0;
        }
        if (Input.GetKeyDown(KeyCode.K) && tiempo >= 1)
        {
            Clone();
            tiempo = 0;
        }
        if (Input.GetKeyDown("l") && tiempo >= 1)
        {
            Clone();
            tiempo = 0;
        }
    }
    void Clone()
    {
        Instantiate(bullet, this.transform.position, this.transform.rotation);
    }
}