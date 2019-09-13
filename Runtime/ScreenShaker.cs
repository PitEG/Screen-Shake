using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PitGan.ScreenShake {
	public class ScreenShaker : MonoBehaviour {

		/// <summary>
		/// number of frames until shaking stops
		/// </summary>
		private float shakeTimer;

		/// <summary>
		/// the number of frames it waits before shaking
		/// </summary>
		private int shakeVigor = 30;

		private int radius;
		private static int FullCircleInDegrees = 360;

		public int ShakeVigor {
			get { return shakeVigor; }
			set { shakeVigor = value; }
		}

		private void OnPreRender() {
			if (shakeTimer > 0 && shakeTimer % shakeVigor == 0) {
				shakeTimer--;
				MoveCamera();
			}
		}

		private void MoveCamera() {
			Vector2 newPos = Random.insideUnitCircle * radius;
			transform.localPosition += (Vector3)newPos;
		}

		public void Shake(int shakeTime, int shakeRadius) {
			this.shakeTimer = shakeTime;
			this.radius = shakeRadius;
		}
	}
}
