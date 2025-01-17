using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;
using UnityEngine.UI;


public class PanelInfo : MonoBehaviour, ITrackableEventHandler {
	private TrackableBehaviour mTrackableBehaviour;

	UnityEngine.UI.Image Image_Background;
	UnityEngine.UI.Text RptaCurso;
	UnityEngine.UI.Text NombreGuetto;
	UnityEngine.UI.Text Frase;

	//Variables para reemplazar icono TapaVuforia por panel de descripción
	public GameObject UI_Escanea;
	public GameObject UI_Ficha_Tecnica;

	//Fotografía del guetto por bitácora.
	public GameObject UI_Image_Guetto;
	public Sprite Foto_Guetto;

	//Estas variable se encuentra dentro de Ficha Técnica en el PanelCurso y corresponde al curso
	public GameObject UI_Rpta_Curso;
	public string Curso;

	//Estas variable se encuentra dentro de Ficha Técnica en el PanelCurso y corresponde al nombre del guetto
	public GameObject UI_Rpta_Grupo;
	public string Nombre_Guetto;

	//Estas variable se encuentra dentro de Ficha Técnica en el PanelDescripcion y corresponde al noombre del guetto
	public GameObject UI_Frase_Guetto;
	public string Frase_de_Guetto;


	//public Text Planet_Description;






	// Use this for initialization
	void Start () {
		mTrackableBehaviour = GetComponent<TrackableBehaviour> ();

		if (mTrackableBehaviour) {
			mTrackableBehaviour.RegisterTrackableEventHandler (this);
		}
			
	}
	public void OnTrackableStateChanged(TrackableBehaviour.Status previousStatus, TrackableBehaviour.Status newStatus)
	{
		UI_Ficha_Tecnica.SetActive (false);
		UI_Escanea.SetActive (true);

		if (newStatus == TrackableBehaviour.Status.DETECTED || newStatus == TrackableBehaviour.Status.TRACKED || newStatus == TrackableBehaviour.Status.EXTENDED_TRACKED) 
		{
			Debug.Log ("1");

			UI_Ficha_Tecnica.SetActive (true);
			UI_Escanea.SetActive (false);

			Image_Background = UI_Image_Guetto.GetComponent<UnityEngine.UI.Image> ();
			Image_Background.sprite = Foto_Guetto;

			RptaCurso = UI_Rpta_Curso.GetComponent<Text> ();
			RptaCurso.text = Curso; 

			NombreGuetto = UI_Rpta_Grupo.GetComponent<Text> ();
			NombreGuetto.text = Nombre_Guetto;
			
			Frase = UI_Frase_Guetto.GetComponent<Text> ();
			Frase.text = Frase_de_Guetto;
				

		}
		else {
			
			UI_Ficha_Tecnica.SetActive (false);
			UI_Escanea.SetActive (true);



		// Update is called once per frame
	}
}
}

