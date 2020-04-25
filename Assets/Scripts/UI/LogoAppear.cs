using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LogoAppear : MonoBehaviour {
	public bool fading = true;
	public bool firstFadeDone = false;
	// Use this for initialization
	void Start () {
		Image image = this.GetComponent<Image>();
		image.CrossFadeAlpha(0,0.0f,false);
	}
	
	// Update is called once per frame
	void Update () {
		
		Image image = this.GetComponent<Image>();
		if (fading == true) {
			image.CrossFadeAlpha(1,1.0f,false);
		} else {
			image.CrossFadeAlpha(0,1.0f,false);
		}
		if (this.firstFadeDone != true) {
			//StartCoroutine(playScore(2.0f));
			StartCoroutine(ocultarLogo(2.0f,true));
			StartCoroutine(ocultarLogo(7.0f,false));
			this.firstFadeDone = true;
		}
		
	}

	IEnumerator ocultarLogo( float delayTime, bool fade ) {
		yield return new WaitForSeconds(delayTime);
		this.fading = fade;
	}

	IEnumerator playScore( float delayTime ) {
		yield return new WaitForSeconds(delayTime);
		AudioSource audio = GetComponent<AudioSource>();
		audio.Play();
	}
		
}
