using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PitGan.ScreenShake {
	public class ScreenShaker : MonoBehaviour {

		private int shakeTimer;
		private int shakeWaitTimer = 2;
		private float radius;
		private Vector3 currentDisplacement;

		private static int FullCircleInDegrees = 360;

		private void OnPreRender() {
			if (shakeTimer > 0) {
				shakeTimer--;
				if (shakeTimer % shakeWaitTimer == 0) {
					NewPos();
				}
				transform.position += currentDisplacement;
			}
		}

		private void NewPos() {
			this.currentDisplacement = Random.insideUnitCircle * radius;
		}

		public void Shake(int shakeTime, float shakeRadius) {
			this.shakeTimer = shakeTime;
			this.radius = shakeRadius;
		}
	}
}
