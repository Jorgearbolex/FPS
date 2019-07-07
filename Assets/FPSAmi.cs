using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FPSAmi : MonoBehaviour
{
    public float mouseX; // variable establecida fuera del update para eje X
    public float mouseY; // variable establecida fuera del update para eje Y
    public bool InvertedMouse; // boleano para invertir la posición la cámara
    public float speed = 1; // float para multiplicar la velocidad de movimiento con mouse Y la función Vector3



    void Update()
    {
        mouseX += Input.GetAxis("Mouse X");

        if (InvertedMouse) // opción para movimiento de camara más armonico y menos tembloroso 
        {
            mouseY += Input.GetAxis("Mouse Y"); //incremento en eje X con Get.Axis
        }
        else
        {
            mouseY -= Input.GetAxis("Mouse Y"); //sino, decremento en eje Y con Get.Axis
        }
        Debug.Log(mouseX);
        transform.eulerAngles = new Vector3(mouseY*speed, mouseX*speed,0); 
        //transform para la rotación en los ejes X y Y de la cámara con eulerAngels y multiplicar la velocidad por cada uno de ellos
    }






}
