using UnityEngine;

namespace Cyberpunk_UI_Pack.Cyberpunk_UI_Resources.Scripts
{
	public class JustRotate : MonoBehaviour {

		public bool canRotate=true;
		public float speed=10;
 
		void Update ()
		{
			if(canRotate)
				transform.Rotate(speed*Vector3.forward*Time.deltaTime);
		}
	}
}
