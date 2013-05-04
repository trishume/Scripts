using UnityEngine;
using System.Collections;

public class Controls : MonoBehaviour {
	public KeyCode jump              = KeyCode.Space;
	public KeyCode pause             = KeyCode.Escape;
	public KeyCode objectiveDetails  = KeyCode.Tab;
	public MouseButton aim           = MouseButton.RMB;
	public MouseButton fire          = MouseButton.LMB;
	public KeyCode minimap           = KeyCode.M;
	public KeyCode reload            = KeyCode.R;
	public KeyCode interact          = KeyCode.E;
	public KeyCode drop              = KeyCode.Q;
	public MouseButton switchWeapons = MouseButton.CMB;
	public KeyCode weapon0           = KeyCode.Alpha1;
	public KeyCode weapon1           = KeyCode.Alpha2;
	public KeyCode weapon2;
	public KeyCode weapon3;
	public KeyCode weapon4;
	public KeyCode weapon5;
	public KeyCode weapon6;
}

public enum MouseButton {
	LMB = 0,
	RMB = 1,
	CMB = 2
}