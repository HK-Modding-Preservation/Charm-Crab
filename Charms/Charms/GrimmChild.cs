﻿using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;
using HutongGames.PlayMaker.Actions;
using CharmCrab.Utils;

namespace CharmCrab.Charms {
	class GrimmChild {
		private GameObject child;

		public void Update() {
			if (!PlayerData.instance.GetBool("equippedCharm_40")) {
				return;
			}
			if (this.child == null) {
				this.child = GameObject.Find("Grimmchild(Clone)");
				if (this.child != null) {
					var fsm = FSMUtility.LocateFSM(child, "Control");

					Functions.GetAction<SetIntValue>(fsm, "Level 2", 0).intValue = 15;
					Functions.GetAction<SetIntValue>(fsm, "Level 3", 0).intValue = 30;
					Functions.GetAction<SetIntValue>(fsm, "Level 4", 0).intValue = 45;

					Modding.Logger.Log("Setup grimmchild dmg");
				}
			}
		}

	}
}

