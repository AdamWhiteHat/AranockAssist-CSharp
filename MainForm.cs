/*
 *
 * Developed by Adam Rakaska
 *  http://csharpcodewhisperer.blogspot.com
 *    http://arakaska.wix.com/intelligentsoftware
 *
 *
 * Made using SharpDevelop
 *
 * 
 */
using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace AranockAssist
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
			GetAranockWindow();
			if(ReadValues()) {
				timerUpdateGUI.Start();
			}
		}
		
		public static void MyExceptionHandler(object sender, ThreadExceptionEventArgs e)
		{
			MessageBox.Show(e.Exception.Message,"ExceptionHandler",MessageBoxButtons.OK,MessageBoxIcon.Error);
		}
		
		// Aranock window title
		static string AranockWindowTitle = "Aranock v2.50.06";
		//static string AranockClassName = "DCWin";
		// Memory address values
		static int HealthMaxAddress = 0x0063EA78;
		static int EnduranceMaxAddress = 0x0063EA90;
		static int ManaMaxAddress = 0x0063EAA8;
		static int HealthCurrentAddress = 0x0063EAAC;
		static int EnduranceCurrentAddress = 0x0063EAB0;
		static int ManaCurrentAddress = 0x0063EAB4;
		//
		static uint NullInt = 0;
		static string NewLine = Environment.NewLine;
		//public static uint PROCESS_MY_ACCESS = ProcessAccessType.PROCESS_VM_READ | ProcessAccessType.PROCESS_VM_WRITE | ProcessAccessType.PROCESS_SUSPEND_RESUME | ProcessAccessType.PROCESS_VM_OPERATION ;
		
		enum ModKeys {
			Shift = 0x0001,
			Ctrl = 0x0002,
			Alt = 0x0004
		}
		
		enum EventType {
			Health = 0x0001,
			Endurance = 0x0002,
			Mana = 0x0004,
			Timer = 0x0008,
		}
		
		enum Operator {
			LessThan = 0x0001,
			Equals = 0x0002,
			GreaterThan = 0x0004
		}

		uint RETRY_TIME = 700;
		uint CLICK_PAUSETIME = 400;

		IntPtr hWndAranock = new IntPtr();
		uint pidAranock = 0;
		byte[] tmpByteArray = new byte[3];
		//uint dwBytesRead = 0;
		uint tidAranock = 0;
		int hAranock = 0;
		char cTemp = ' ';
		
		
		void GetAranockWindow()
		{
			hWndAranock = FindWindow(null,AranockWindowTitle);
		}
		
		void UpdateGUI()
		{
			ReadValues();
			tbMouseX.Text = Cursor.Position.X.ToString();
			tbMouseY.Text = Cursor.Position.Y.ToString();
		}

		string ReadMemoryValue(IntPtr address)
		{
			if(ReadProcessMemory((IntPtr)hAranock,(IntPtr)address,tmpByteArray,Convert.ToUInt32(tmpByteArray.Length),ref NullInt)) {
				cTemp = BitConverter.ToChar(tmpByteArray,0);
				return Convert.ToInt32(cTemp).ToString();
			}
			timerUpdateGUI.Stop();
			return string.Empty;
		}
		
		bool ReadValues()
		{
			//GetAranockWindow();
			if(IsWindow(hWndAranock))
			{
				tidAranock = GetWindowThreadProcessId((IntPtr)hWndAranock,out pidAranock);
				hAranock = Convert.ToInt32((Int32)OpenProcess((uint)0x0030,false,pidAranock));

				tbCurrentHealth.Text 	= ReadMemoryValue((IntPtr)HealthCurrentAddress);
				tbMaxHealth.Text			= ReadMemoryValue((IntPtr)HealthMaxAddress);
				tbCurrentEndurance.Text	= ReadMemoryValue((IntPtr)EnduranceCurrentAddress);
				tbMaxEndurance.Text		= ReadMemoryValue((IntPtr)EnduranceMaxAddress);
				tbCurrentMana.Text		= ReadMemoryValue((IntPtr)ManaCurrentAddress);
				tbMaxMana.Text				= ReadMemoryValue((IntPtr)ManaMaxAddress);

				CloseHandle((IntPtr)hAranock);
				return true;
			}
			else
			{
				timerUpdateGUI.Stop();
				MessageBox.Show("Error: Cannot find Aranock window, perhaps Aranock is not running?"+NewLine,"AranockAssist");
				return false;
			}
		}
		
		bool MouseInUse = false;
		void SendMouseClick(uint x,uint y,bool bShift)
		{
			if(MouseInUse)
			{
				Sleep(RETRY_TIME);
				SendMouseClick(x,y,bShift);
				return;
			}
			else
			{
				MouseInUse = true;
				
				// move mouse
				Cursor.Position = new Point((int)x,(int)y);

				if(bShift) {
					// shift down
					keybd_event((byte)VirtualKeys.Shift,0,0,0);
					Sleep(CLICK_PAUSETIME);
				}
				// mouse down
				mouse_event(MOUSEEVENTF_LEFTDOWN,0,0,0,0);
				Sleep(CLICK_PAUSETIME);
				
				// mouse up
				mouse_event(MOUSEEVENTF_LEFTUP,0,0,0,0);
				Sleep(CLICK_PAUSETIME);
				if(bShift) {
					// shift up
					keybd_event((byte)VirtualKeys.Shift,0,KEYEVENTF_KEYUP,0);
				}
				Sleep(CLICK_PAUSETIME);
				MouseInUse = false;
			}
		}
		
		bool KeyInUse = false;
		void SendKeystroke(byte bkey,ModKeys ModKey)
		{
			if(KeyInUse)
			{
				Sleep(RETRY_TIME);
				SendKeystroke(bkey,ModKey);
				return;
			}
			else
			{
				KeyInUse = true;
				if(ModKey == ModKeys.Shift) {
					keybd_event((byte)VirtualKeys.Shift,0,0,0);
					Sleep(CLICK_PAUSETIME);
				} else if(ModKey == ModKeys.Ctrl) {
					keybd_event((byte)VirtualKeys.Control,0,0,0);
					Sleep(CLICK_PAUSETIME);
				}
//				else if(ModKeys = ModKeys.Alt) {
//					keybd_event((byte)VirtualKeys.Alt,0,0,0);
//					Sleep(CLICK_PAUSETIME);
//				}
				
				// key down
				keybd_event(bkey,0,0,0);
				Sleep(CLICK_PAUSETIME);
				
				if(ModKey == ModKeys.Shift) {
					keybd_event((byte)VirtualKeys.Shift,0,KEYEVENTF_KEYUP,0);
					Sleep(CLICK_PAUSETIME);
				} else if(ModKey == ModKeys.Ctrl) {
					keybd_event((byte)VirtualKeys.Control,0,KEYEVENTF_KEYUP,0);
					Sleep(CLICK_PAUSETIME);
				}

				// key up
				keybd_event(bkey,0,KEYEVENTF_KEYUP,0);
				Sleep(CLICK_PAUSETIME);
				KeyInUse = false;
			}
		}
		
		void SendKeyStrokeCombo(int ModKey,int FnKey)
		{
			ModKeys modKey = 0;
			VirtualKeys virtKey = 0;
			
			if(ModKey == 0) {
				modKey = ModKeys.Shift;
			} else if(ModKey == 1) {
				modKey = ModKeys.Ctrl;
			} else if(ModKey == 2) {
				modKey = ModKeys.Alt;
			}
			
			if(FnKey == 0) {
				virtKey = VirtualKeys.F1;
			} else if(FnKey == 1) {
				virtKey = VirtualKeys.F2;
			} else if(FnKey == 2) {
				virtKey = VirtualKeys.F3;
			} else if(FnKey == 3) {
				virtKey = VirtualKeys.F4;
			} else if(FnKey == 4) {
				virtKey = VirtualKeys.F5;
			} else if(FnKey == 5) {
				virtKey = VirtualKeys.F6;
			} else if(FnKey == 6) {
				virtKey = VirtualKeys.F7;
			} else if(FnKey == 7) {
				virtKey = VirtualKeys.F8;
			} else if(FnKey == 8) {
				virtKey = VirtualKeys.F9;
			} else if(FnKey == 9) {
				virtKey = VirtualKeys.F10;
			} else if(FnKey == 10) {
				virtKey = VirtualKeys.F11;
			} else if(FnKey == 11) {
				virtKey = VirtualKeys.F12;
			}
			SendKeystroke((byte)virtKey,modKey);
		}
		
		void HandleTimerEvent(EventType eventType,Operator compOperator,int modKey,int fnKey,int current,int val)
		{
			if(eventType == EventType.Timer) { // Timer
				SendKeyStrokeCombo(modKey,fnKey);
			} else  { // Health
				if(compOperator == Operator.LessThan) {
					if(current < val) {
						SendKeyStrokeCombo(modKey,fnKey);
					}
				}
				if(compOperator == Operator.Equals) {
					if(current == val) {
						SendKeyStrokeCombo(modKey,fnKey);
					}
				}
				if(compOperator == Operator.GreaterThan) {
					if(current > val) {
						SendKeyStrokeCombo(modKey,fnKey);
					}
				}
			}
		}
		
		void HandleTimerTick(int selectedType,int selectedOperation,int selectedKey,int selectedFunction,string selectedValue)
		{
			Operator operation = 0;
			EventType	timerEvent	= 0;
			int current = 0;
			int val = Convert.ToInt32(selectedValue);
			
			if (selectedType == 0 ) { // Health
				timerEvent = EventType.Health;
				current = Convert.ToInt32(tbCurrentHealth.Text);
			} else if (selectedType == 1 ) { // Endurance
				timerEvent = EventType.Endurance;
				current = Convert.ToInt32(tbCurrentEndurance.Text);
			} else if (selectedType == 2 ) { // Mana
				timerEvent = EventType.Mana;
				current = Convert.ToInt32(tbCurrentMana.Text);
			} else if(selectedType == 3) { // Timer
				timerEvent = EventType.Timer;
			}
			
			if(selectedOperation == 0) {
				operation = Operator.LessThan;
			}
			if(selectedOperation == 1) {
				operation = Operator.Equals;
			}
			if(selectedOperation == 2) {
				operation = Operator.GreaterThan;
			}
			
			HandleTimerEvent(timerEvent,operation,selectedKey,selectedFunction,current,val);
		}

		void TimerUpdateGUITick(object sender, EventArgs e)
		{
			UpdateGUI();
		}
		
		bool bReadValues = false;
		void BtnStartTimerClick(object sender, EventArgs e)
		{
			if(bReadValues) {
				btnReadValues.Text = "Start Reading Values";
				timerUpdateGUI.Stop();
				bReadValues = false;
			} else {
				GetAranockWindow();
				btnReadValues.Text = "Pause Reading Values";
				timerUpdateGUI.Start();
				bReadValues = true;
			}
		}

		void StartTimer(ref System.Windows.Forms.Timer timer,int selectedType, string interval)
		{
			if(selectedType==3) {
				timer.Interval = Convert.ToInt32(interval)*1000;
			} else {
				timer.Interval = 1000;
			}
			timer.Start();
		}
		
		void CbTimer1CheckedChanged(object sender, EventArgs e)
		{
			if(cbTimer1.Checked) {
				StartTimer(ref timer1,comboBoxType1.SelectedIndex,tbTimer1Value.Text);
			} else { timer1.Stop(); }
		}
		
		void CbTimer2CheckedChanged(object sender, EventArgs e)
		{
			if(cbTimer2.Checked) {
				StartTimer(ref timer2,comboBoxType2.SelectedIndex,tbTimer2Value.Text);
			} else { timer2.Stop(); }
		}
		
		void CbTimer3CheckedChanged(object sender, EventArgs e)
		{
			if(cbTimer3.Checked) {
				StartTimer(ref timer3,comboBoxType3.SelectedIndex,tbTimer3Value.Text);
			} else { timer3.Stop(); }
		}
		
		void CbTimer4CheckedChanged(object sender, EventArgs e)
		{
			if(cbTimer4.Checked) {
				StartTimer(ref timer4,comboBoxType4.SelectedIndex,tbTimer4Value.Text);
			} else { timer4.Stop(); }
		}
		
		void CbTimer5CheckedChanged(object sender, EventArgs e)
		{
			if(cbTimer5.Checked) {
				StartTimer(ref timer5,comboBoxType5.SelectedIndex,tbTimer5Value.Text);
			} else { timer5.Stop(); }
		}
		
		void Timer1Tick(object sender, EventArgs e)
		{
			HandleTimerTick(comboBoxType1.SelectedIndex,comboBoxOperation1.SelectedIndex,comboBoxKey1.SelectedIndex,comboBoxFn1.SelectedIndex,tbTimer1Value.Text);
		}
		
		void Timer2Tick(object sender, EventArgs e)
		{
			HandleTimerTick(comboBoxType2.SelectedIndex,comboBoxOperation2.SelectedIndex,comboBoxKey2.SelectedIndex,comboBoxFn2.SelectedIndex,tbTimer2Value.Text);
		}
		
		void Timer3Tick(object sender, EventArgs e)
		{
			HandleTimerTick(comboBoxType3.SelectedIndex,comboBoxOperation3.SelectedIndex,comboBoxKey3.SelectedIndex,comboBoxFn3.SelectedIndex,tbTimer3Value.Text);
		}

		void TimerGetPos1Tick(object sender, EventArgs e)
		{
			timerGetPos1.Stop();
			
			tbPos1X.Text = tbMouseX.Text;
			tbPos1Y.Text = tbMouseY.Text;
			cbGetPos1.CheckState = CheckState.Unchecked;
		}
		
		void TimerGetPos2Tick(object sender, EventArgs e)
		{
			timerGetPos2.Stop();
			
			tbPos2X.Text = tbMouseX.Text;
			tbPos2Y.Text = tbMouseY.Text;
			cbGetPos2.CheckState = CheckState.Unchecked;
		}
		
		void CbGetPos1CheckedChanged(object sender, EventArgs e)
		{
			if(cbGetPos1.Checked) {
				timerGetPos1.Start();
			}
		}
		
		void CbGetPos2CheckedChanged(object sender, EventArgs e)
		{
			if(cbGetPos2.Checked) {
				timerGetPos2.Start();
			}
		}
		
		bool IsAutoMining = false;
		void BtnAutoMineClick(object sender, EventArgs e)
		{
			if(IsAutoMining) {
				timerAutoMine.Stop();
				btnAutoMine.Text = "Automine Start";
				IsAutoMining = false;
				//tbAutomineCounter.Text = "15";
			}
			else
			{
				btnAutoMine.Text = "Automine Stop";
				timerAutoMine.Start();
				IsAutoMining = true;
			}
		}
		
		void TimerAutoMineTick(object sender, EventArgs e)
		{
			int x = 0;
			int y = 0;
			
			int i = Convert.ToInt32(tbAutomineCounter.Text);
			
			if(i<1) {
				BtnAutoMineClick(null,null);
				return;
			}
			
			x = Convert.ToInt32(tbPos1X.Text);
			y = Convert.ToInt32(tbPos1Y.Text);
			SendMouseClick((uint)x,(uint)y,true);
			
			i--;
			tbAutomineCounter.Text = i.ToString();
		}
		
		void BtnTestClickClick(object sender, EventArgs e)
		{
			int x = Convert.ToInt32(tbPos1X.Text);
			int y = Convert.ToInt32(tbPos1Y.Text);
			MessageBox.Show(x.ToString() + " : " + y.ToString());
			
			SendMouseClick((uint)x,(uint)y,false);
		}
	}

}
