using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerControler : MonoBehaviour
{
    private Rigidbody2D rb;
    public GameObject roda1;
    public GameObject roda2;
    public GameObject canhao;

    
    float deslocamento = 5;

    

  

    Vector2 movimento;
    public void setDeslomento(InputAction.CallbackContext valui) 

    {

        movimento = valui.ReadValue<Vector2>();

        // Vector3 posicaoRoda = valui.ReadValue<Vector3>(); 

       
       



    
  
    }

    private void FixedUpdate()
    {
        Vector3 movie = new Vector3(movimento.x,0,0)* Time.fixedDeltaTime*deslocamento;
        transform.Translate(movie);
        
    }

    private void Awake()
        
    {
        rb = GetComponent<Rigidbody2D>();

         


        
    }

    private void Update()
    {
        roda1.transform.Rotate(0, 0, -movimento.x * 100 * Time.deltaTime);


        roda2.transform.Rotate(0, 0, -movimento.x * 100 * Time.deltaTime);

        canhao.transform.Rotate(0, 0, movimento.y * 100 * Time.deltaTime);









    }
}
