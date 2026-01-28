using System;
namespace Shared.Unity
{
	public delegate void KeyEventHandler(object sender, KeyEventArgs e);

	public class KeyEventArgs : EventArgs
	{
		private readonly Keys keyData;

		private bool handled;

		private bool suppressKeyPress;

		// public virtual bool Alt => (keyData & Keys.Alt) == Keys.Alt && !type;

		// public bool Control => (keyData & Keys.Control) == Keys.Control && !type;

		// public virtual bool Shift => (keyData & Keys.Shift) == Keys.Shift && !type;

		public bool alt;
		public bool Alt
		{
			get
			{
				return alt;
			}
			set
			{
				alt = value;
			}
		}

		public bool control;
		public bool Control
		{
			get
			{
				return control;
			}
			set
			{
				control = value;
			}
		}

		public bool shift;
		public bool Shift
		{
			get
			{
				return shift;
			}
			set
			{
				shift = value;
			}
		}

		public bool Handled
		{
			get
			{
				return handled;
			}
			set
			{
				handled = value;
			}
		}

		public Keys KeyCode
		{
			get
			{
				Keys keys = keyData & Keys.KeyCode;
				if (!Enum.IsDefined(typeof(Keys), (int)keys))
				{
					return Keys.None;
				}
				return keys;
			}
		}

		public int KeyValue => (int)(keyData & Keys.KeyCode);

		public Keys KeyData => keyData;

		// public Keys Modifiers => keyData & Keys.Modifiers;

		public bool SuppressKeyPress
		{
			get
			{
				return suppressKeyPress;
			}
			set
			{
				suppressKeyPress = value;
				handled = value;
			}
		}

		public bool type;

		public KeyEventArgs(Keys keyData, bool _type = false)
		{
			this.keyData = keyData;
			type = _type;
		}

		public static Keys GetKeys(UnityEngine.KeyCode keyCode)
		{
			switch (keyCode)
			{
				case UnityEngine.KeyCode.None: return Keys.None;
				case UnityEngine.KeyCode.Mouse0: return Keys.LButton;
				case UnityEngine.KeyCode.Mouse1: return Keys.RButton;
				case UnityEngine.KeyCode.Mouse2: return Keys.MButton;
				case UnityEngine.KeyCode.Mouse3: return Keys.XButton1;
				case UnityEngine.KeyCode.Mouse4: return Keys.XButton2;
				case UnityEngine.KeyCode.Backspace: return Keys.Back;
				case UnityEngine.KeyCode.Tab: return Keys.Tab;
				case UnityEngine.KeyCode.Clear: return Keys.Clear;
				case UnityEngine.KeyCode.Return: return Keys.Return;
				case UnityEngine.KeyCode.LeftShift: return Keys.Shift;
				case UnityEngine.KeyCode.LeftControl: return Keys.Control;
				case UnityEngine.KeyCode.LeftAlt: return Keys.Alt;
				case UnityEngine.KeyCode.Pause: return Keys.Pause;
				case UnityEngine.KeyCode.CapsLock: return Keys.CapsLock;
				case UnityEngine.KeyCode.Escape: return Keys.Escape;
				case UnityEngine.KeyCode.Space: return Keys.Space;
				case UnityEngine.KeyCode.PageUp: return Keys.PageUp;
				case UnityEngine.KeyCode.PageDown: return Keys.PageDown;
				case UnityEngine.KeyCode.End: return Keys.End;
				case UnityEngine.KeyCode.Home: return Keys.Home;
				case UnityEngine.KeyCode.LeftArrow: return Keys.Left;
				case UnityEngine.KeyCode.UpArrow: return Keys.Up;
				case UnityEngine.KeyCode.RightArrow: return Keys.Right;
				case UnityEngine.KeyCode.DownArrow: return Keys.Down;
				case UnityEngine.KeyCode.Print: return Keys.Print;
				case UnityEngine.KeyCode.Insert: return Keys.Insert;
				case UnityEngine.KeyCode.Delete: return Keys.Delete;
				case UnityEngine.KeyCode.Help: return Keys.Help;
				case UnityEngine.KeyCode.Alpha0: return Keys.D0;
				case UnityEngine.KeyCode.Alpha1: return Keys.D1;
				case UnityEngine.KeyCode.Alpha2: return Keys.D2;
				case UnityEngine.KeyCode.Alpha3: return Keys.D3;
				case UnityEngine.KeyCode.Alpha4: return Keys.D4;
				case UnityEngine.KeyCode.Alpha5: return Keys.D5;
				case UnityEngine.KeyCode.Alpha6: return Keys.D6;
				case UnityEngine.KeyCode.Alpha7: return Keys.D7;
				case UnityEngine.KeyCode.Alpha8: return Keys.D8;
				case UnityEngine.KeyCode.Alpha9: return Keys.D9;
				case UnityEngine.KeyCode.A: return Keys.A;
				case UnityEngine.KeyCode.B: return Keys.B;
				case UnityEngine.KeyCode.C: return Keys.C;
				case UnityEngine.KeyCode.D: return Keys.D;
				case UnityEngine.KeyCode.E: return Keys.E;
				case UnityEngine.KeyCode.F: return Keys.F;
				case UnityEngine.KeyCode.G: return Keys.G;
				case UnityEngine.KeyCode.H: return Keys.H;
				case UnityEngine.KeyCode.I: return Keys.I;
				case UnityEngine.KeyCode.J: return Keys.J;
				case UnityEngine.KeyCode.K: return Keys.K;
				case UnityEngine.KeyCode.L: return Keys.L;
				case UnityEngine.KeyCode.M: return Keys.M;
				case UnityEngine.KeyCode.N: return Keys.N;
				case UnityEngine.KeyCode.O: return Keys.O;
				case UnityEngine.KeyCode.P: return Keys.P;
				case UnityEngine.KeyCode.Q: return Keys.Q;
				case UnityEngine.KeyCode.R: return Keys.R;
				case UnityEngine.KeyCode.S: return Keys.S;
				case UnityEngine.KeyCode.T: return Keys.T;
				case UnityEngine.KeyCode.U: return Keys.U;
				case UnityEngine.KeyCode.V: return Keys.V;
				case UnityEngine.KeyCode.W: return Keys.W;
				case UnityEngine.KeyCode.X: return Keys.X;
				case UnityEngine.KeyCode.Y: return Keys.Y;
				case UnityEngine.KeyCode.Z: return Keys.Z;
				case UnityEngine.KeyCode.LeftWindows: return Keys.LWin;
				case UnityEngine.KeyCode.RightWindows: return Keys.RWin;
				case UnityEngine.KeyCode.Keypad0: return Keys.NumPad0;
				case UnityEngine.KeyCode.Keypad1: return Keys.NumPad1;
				case UnityEngine.KeyCode.Keypad2: return Keys.NumPad2;
				case UnityEngine.KeyCode.Keypad3: return Keys.NumPad3;
				case UnityEngine.KeyCode.Keypad4: return Keys.NumPad4;
				case UnityEngine.KeyCode.Keypad5: return Keys.NumPad5;
				case UnityEngine.KeyCode.Keypad6: return Keys.NumPad6;
				case UnityEngine.KeyCode.Keypad7: return Keys.NumPad7;
				case UnityEngine.KeyCode.Keypad8: return Keys.NumPad8;
				case UnityEngine.KeyCode.Keypad9: return Keys.NumPad9;
				case UnityEngine.KeyCode.KeypadMultiply: return Keys.Multiply;
				case UnityEngine.KeyCode.KeypadPlus: return Keys.Add;
				case UnityEngine.KeyCode.KeypadMinus: return Keys.Subtract;
				case UnityEngine.KeyCode.KeypadPeriod: return Keys.Decimal;
				case UnityEngine.KeyCode.KeypadDivide: return Keys.Divide;
				case UnityEngine.KeyCode.F1: return Keys.F1;
				case UnityEngine.KeyCode.F2: return Keys.F2;
				case UnityEngine.KeyCode.F3: return Keys.F3;
				case UnityEngine.KeyCode.F4: return Keys.F4;
				case UnityEngine.KeyCode.F5: return Keys.F5;
				case UnityEngine.KeyCode.F6: return Keys.F6;
				case UnityEngine.KeyCode.F7: return Keys.F7;
				case UnityEngine.KeyCode.F8: return Keys.F8;
				case UnityEngine.KeyCode.F9: return Keys.F9;
				case UnityEngine.KeyCode.F10: return Keys.F10;
				case UnityEngine.KeyCode.F11: return Keys.F11;
				case UnityEngine.KeyCode.F12: return Keys.F12;
				case UnityEngine.KeyCode.F13: return Keys.F13;
				case UnityEngine.KeyCode.F14: return Keys.F14;
				case UnityEngine.KeyCode.F15: return Keys.F15;
				case UnityEngine.KeyCode.Numlock: return Keys.NumLock;
				case UnityEngine.KeyCode.ScrollLock: return Keys.Scroll;
				case UnityEngine.KeyCode.RightShift: return Keys.Shift;
				case UnityEngine.KeyCode.RightControl: return Keys.Control;
				case UnityEngine.KeyCode.RightAlt: return Keys.Alt;
				case UnityEngine.KeyCode.Semicolon: return Keys.OemSemicolon;
				case UnityEngine.KeyCode.Plus: return Keys.Oemplus;
				case UnityEngine.KeyCode.Comma: return Keys.Oemcomma;
				case UnityEngine.KeyCode.Minus: return Keys.OemMinus;
				case UnityEngine.KeyCode.Period: return Keys.OemPeriod;
				case UnityEngine.KeyCode.Question: return Keys.OemQuestion;
				case UnityEngine.KeyCode.Tilde: return Keys.Oemtilde;
				case UnityEngine.KeyCode.LeftBracket: return Keys.OemOpenBrackets;
				case UnityEngine.KeyCode.Backslash: return Keys.OemPipe;
				case UnityEngine.KeyCode.RightBracket: return Keys.OemCloseBrackets;
				case UnityEngine.KeyCode.Quote: return Keys.OemQuotes;
				case UnityEngine.KeyCode.KeypadEnter: return Keys.Return;
				default: return Keys.None; // 默认情况，找不到匹配项
			}
		}
	}

	public enum Keys
	{
		None = 0,
		LButton = 1,
		RButton = 2,
		Cancel = 3,
		MButton = 4,
		XButton1 = 5,
		XButton2 = 6,
		Back = 8,
		Tab = 9,
		LineFeed = 10,
		Clear = 12,
		Return = 13,
		Enter = 13,
		ShiftKey = 16,
		ControlKey = 17,
		Menu = 18,
		Pause = 19,
		Capital = 20,
		CapsLock = 20,
		KanaMode = 21,
		HanguelMode = 21,
		HangulMode = 21,
		JunjaMode = 23,
		FinalMode = 24,
		HanjaMode = 25,
		KanjiMode = 25,
		Escape = 27,
		IMEConvert = 28,
		IMENonconvert = 29,
		IMEAccept = 30,
		IMEModeChange = 31,
		Space = 32,
		Prior = 33,
		PageUp = 33,
		Next = 34,
		PageDown = 34,
		End = 35,
		Home = 36,
		Left = 37,
		Up = 38,
		Right = 39,
		Down = 40,
		Select = 41,
		Print = 42,
		Execute = 43,
		PrintScreen = 44,
		Snapshot = 44,
		Insert = 45,
		Delete = 46,
		Help = 47,
		D0 = 48,
		D1 = 49,
		D2 = 50,
		D3 = 51,
		D4 = 52,
		D5 = 53,
		D6 = 54,
		D7 = 55,
		D8 = 56,
		D9 = 57,
		A = 65,
		B = 66,
		C = 67,
		D = 68,
		E = 69,
		F = 70,
		G = 71,
		H = 72,
		I = 73,
		J = 74,
		K = 75,
		L = 76,
		M = 77,
		N = 78,
		O = 79,
		P = 80,
		Q = 81,
		R = 82,
		S = 83,
		T = 84,
		U = 85,
		V = 86,
		W = 87,
		X = 88,
		Y = 89,
		Z = 90,
		LWin = 91,
		RWin = 92,
		Apps = 93,
		Sleep = 95,
		NumPad0 = 96,
		NumPad1 = 97,
		NumPad2 = 98,
		NumPad3 = 99,
		NumPad4 = 100,
		NumPad5 = 101,
		NumPad6 = 102,
		NumPad7 = 103,
		NumPad8 = 104,
		NumPad9 = 105,
		Multiply = 106,
		Add = 107,
		Separator = 108,
		Subtract = 109,
		Decimal = 110,
		Divide = 111,
		F1 = 112,
		F2 = 113,
		F3 = 114,
		F4 = 115,
		F5 = 116,
		F6 = 117,
		F7 = 118,
		F8 = 119,
		F9 = 120,
		F10 = 121,
		F11 = 122,
		F12 = 123,
		F13 = 124,
		F14 = 125,
		F15 = 126,
		F16 = 127,
		F17 = 128,
		F18 = 129,
		F19 = 130,
		F20 = 131,
		F21 = 132,
		F22 = 133,
		F23 = 134,
		F24 = 135,
		NumLock = 144,
		Scroll = 145,
		LShiftKey = 160,
		RShiftKey = 161,
		LControlKey = 162,
		RControlKey = 163,
		LMenu = 164,
		RMenu = 165,
		BrowserBack = 166,
		BrowserForward = 167,
		BrowserRefresh = 168,
		BrowserStop = 169,
		BrowserSearch = 170,
		BrowserFavorites = 171,
		BrowserHome = 172,
		VolumeMute = 173,
		VolumeDown = 174,
		VolumeUp = 175,
		MediaNextTrack = 176,
		MediaPreviousTrack = 177,
		MediaStop = 178,
		MediaPlayPause = 179,
		LaunchMail = 180,
		SelectMedia = 181,
		LaunchApplication1 = 182,
		LaunchApplication2 = 183,
		OemSemicolon = 186,
		Oem1 = 186,
		Oemplus = 187,
		Oemcomma = 188,
		OemMinus = 189,
		OemPeriod = 190,
		Oem2 = 191,
		OemQuestion = 191,
		Oemtilde = 192,
		Oem3 = 192,
		OemOpenBrackets = 219,
		Oem4 = 219,
		OemPipe = 220,
		Oem5 = 220,
		OemCloseBrackets = 221,
		Oem6 = 221,
		OemQuotes = 222,
		Oem7 = 222,
		Oem8 = 223,
		OemBackslash = 226,
		Oem102 = 226,
		ProcessKey = 229,
		Packet = 231,
		Attn = 246,
		Crsel = 247,
		Exsel = 248,
		EraseEof = 249,
		Play = 250,
		Zoom = 251,
		NoName = 252,
		Pa1 = 253,
		OemClear = 254,
		KeyCode = 65535,
		Shift = 65536,
		Control = 131072,
		Alt = 262144,
	}
}