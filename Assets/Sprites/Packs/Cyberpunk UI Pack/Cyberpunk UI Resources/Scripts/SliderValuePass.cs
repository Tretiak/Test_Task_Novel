﻿using UnityEngine;
using UnityEngine.UI;

namespace Cyberpunk_UI_Pack.Cyberpunk_UI_Resources.Scripts
{
	public class SliderValuePass : MonoBehaviour {

		Text progress;

		// Use this for initialization
		void Start () {
			progress = GetComponent<Text>();

		}
	
		public  void UpdateProgress (float content) {
			progress.text = Mathf.Round( content*100) +"%";
		}


	}
}
