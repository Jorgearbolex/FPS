using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FPSMove : MonoBehaviour // esta clase contiene los movimientos del objeto y a su vez la clase de la camara dentro del objeto
{
    public float speed = 0.3f; // definimos las variable float que da la velocidad de desplazamiento
    public FPSAmi rota; // llamamos la clase FPSAmi que contiene el la orientación y movimiento de la camara


    void Update()
    {
        if (Input.GetKey(KeyCode.W)) //creamos las funciones para cada una de las cuatro teclas que permiten el dezplazamiento del objeto esta es W hacia adelante
        {
            transform.position += transform.forward * speed;
        }
        if (Input.GetKey(KeyCode.S)) // esta es S para dezplazamiento hacia atras donde ponemos en negativo el movimiento de forward
        {
            transform.position -= transform.forward * speed;
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.position -= transform.right * speed;
        }
        if (Input.GetKey(KeyCode.D)) // esta es D para dezplazamiento hacia la izquierda, donde ponemos en negativo el movimiento de right
        {
            transform.position += transform.right * speed;

        }
        transform.eulerAngles = new Vector3(0, rota.mouseX*speed,0); //esta es la función que permite girar la camara en el eje Y, y también permite que para donde se mire se dezplase el objeto
    }

}
