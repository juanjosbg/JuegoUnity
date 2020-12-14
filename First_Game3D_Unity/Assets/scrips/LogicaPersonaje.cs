using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LogicaPersonaje : MonoBehaviour 
{
    public float velocidadMovimiento;
    public float velocidadRotacion;
    public Animator anim;
    public float x, y;
    public Rigidbody rb;
    public float fuerzaDeSalto;
    public bool puedoSaltar;

    public void Start()
    {
        fuerzaDeSalto = 6f;
        velocidadMovimiento = 5f;
        velocidadRotacion = 200.0f;
        puedoSaltar = false;
        anim = GetComponent<Animator>();
    }

    public void FixedUpdate()
    {
        x = Input.GetAxis("Horizontal");
        y = Input.GetAxis("Vertical");

        transform.Rotate(0, x * Time.deltaTime * velocidadRotacion, 0);
        transform.Translate(0, 0, y * Time.deltaTime * velocidadMovimiento);

        anim.SetFloat("VelX", x);
        anim.SetFloat("VelY", y);

        if (puedoSaltar)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                anim.SetBool("Salte", true);
                rb.AddForce(new Vector3(0, fuerzaDeSalto, 0), ForceMode.Impulse);
            }
            anim.SetBool("tocoSuelo", true);
        }
        else
        {
            EstoyCayendo();
        }
    }

    public void EstoyCayendo()
    {
        anim.SetBool("TocoSuelo", false);
        anim.SetBool("Salte", false);
    }

}
