using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LogicaPersonaje : MonoBehaviour 
{ 
    public float velocidadMovimiento = 5.0f;
    public float velocidadRotacion = 200.0f;
    public Animator anim;
    public float x, y;
    public Rigidbody rb;
    public float fuerzaDeSalto;
    public bool puedoSaltar;

    public void Start()
    {
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        x = Input.GetAxis("Horizontal");
        y = Input.GetAxis("Vertical");

        transform.Rotate(0, x * Time.deltaTime * velocidadRotacion, 0);
        transform.Translate(0, 0, y * Time.deltaTime * velocidadMovimiento);

        anim.SetFloat("VelX", x);
        anim.SetFloat("VelY", y);
    }
}
