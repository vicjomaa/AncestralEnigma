using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Direccion : MonoBehaviour
{
	//public Transform posicion;
	public Transform objetivo1;
	//public Transform objetivo2;
	//public Transform objetivo3;
    /*
	public Transform objetivo4;
	public Transform objetivo5;
	public Transform objetivo6;
	public Transform objetivo7;

    */

    public static int  planetaDetectado;
	private Transform norteTransform;
    public int objetivoNum;
	//public Transform indicadorObjetivo;
	//public Transform circuloDiamante;

	private float CirculoDiamantePosY = 0.0F;

	private void Start ()
	{
        planetaDetectado = 0;
        norteTransform = transform;

	}




	private void Update ()
	{

        //Vector3 dir = new Vector3 (0, 0, 0);
        //Quaternion rotation = Quaternion.Euler (currentY, currentX, 0);

        //norteTransfrm.LookAt(transform.position + orientacion.transform.rotation * Vector3.back, orientacion.transform.rotation * Vector3.up);

		switch (objetivoNum) {

		case 0:
                if (objetivo1.localRotation.x < 0)
                {
                    norteTransform.LookAt(objetivo1);

                }
                else {
                    norteTransform.rotation = Quaternion.LookRotation(norteTransform.position - objetivo1.position);
                }

                //indicadorObjetivo.position = new Vector3 (objetivo1.position.x, objetivo1.position.y + 5.0f, objetivo1.position.z);
                //circuloDiamante.position = new Vector3 (objetivo1.position.x, objetivo1.position.y + CirculoDiamantePosY, objetivo1.position.z);
                break;
				
//		case 1:
//                if (objetivo2.localRotation.x < 0)
//                {
//                    norteTransform.LookAt(objetivo2);
//
//                }
//                else
//                {
//                    norteTransform.rotation = Quaternion.LookRotation(norteTransform.position - objetivo2.position);
//                }
//
//
//                //indicadorObjetivo.position = new Vector3 (objetivo2.position.x, objetivo2.position.y + 5.0f, objetivo2.position.z);
//                //circuloDiamante.position = new Vector3 (objetivo2.position.x, objetivo2.position.y + CirculoDiamantePosY, objetivo2.position.z);
//                //indicadorObjetivo.position = new Vector3 (objetivo7.position.x, objetivo7.position.y + 5.0f, objetivo7.position.z);
//                break;
//
//		case 2:
//                if (objetivo3.localRotation.x <  0)
//                {
//                    norteTransform.LookAt(objetivo3);
//
//                }
//                else
//                {
//                    norteTransform.rotation = Quaternion.LookRotation(norteTransform.position - objetivo3.position);
//                }
//
//                //indicadorObjetivo.position = new Vector3 (objetivo3.position.x, objetivo3.position.y + 5.0f, objetivo3.position.z);
//                //circuloDiamante.position = new Vector3 (objetivo3.position.x, objetivo3.position.y + CirculoDiamantePosY, objetivo3.position.z);
//                break;
/*
		case 3:
			norteTransform.LookAt (objetivo4);
			indicadorObjetivo.position = new Vector3 (objetivo4.position.x, objetivo4.position.y + 5.0f, objetivo4.position.z);
			circuloDiamante.position = new Vector3 (objetivo4.position.x, objetivo4.position.y + CirculoDiamantePosY, objetivo4.position.z);
			break;

		case 4:
			norteTransform.LookAt (objetivo5);
			indicadorObjetivo.position = new Vector3 (objetivo5.position.x, objetivo5.position.y + 5.0f, objetivo5.position.z);
			circuloDiamante.position = new Vector3 (objetivo5.position.x, objetivo5.position.y + CirculoDiamantePosY, objetivo5.position.z);
			break;

		case 5:
			norteTransform.LookAt (objetivo6);
			indicadorObjetivo.position = new Vector3 (objetivo6.position.x, objetivo6.position.y + 5.0f, objetivo6.position.z);
			circuloDiamante.position = new Vector3 (objetivo6.position.x, objetivo6.position.y + CirculoDiamantePosY, objetivo6.position.z);
			break;
		case 6:
			norteTransform.LookAt (objetivo7);
			indicadorObjetivo.position = new Vector3 (objetivo7.position.x, objetivo7.position.y + 5.0f, objetivo7.position.z);
			circuloDiamante.position = new Vector3 (objetivo7.position.x, objetivo7.position.y + CirculoDiamantePosY, objetivo7.position.z);
			break;
		case 7:
		//	GameObject.Find ("FlechaDireccion").SetActive (false);
		//GameObject.Find ("DiamanteObjetivo").SetActive (false);
		//	GameObject.Find ("CirculoDiamante").SetActive (false);
			//indicadorObjetivo.position = new Vector3 (objetivo7.position.x, objetivo7.position.y + 5.0f, objetivo7.position.z);
			break;
            */
	}

        
        //norteTransform.position = new Vector3 (posicion.position.x, posicion.position.y  , posicion.position.z);
        //Debug.Log(RixAvatarTocaObjetos.objetivoNum);


    }

    
}
