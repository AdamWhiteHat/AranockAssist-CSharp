/*
 * Created by SharpDevelop.
 * User: BurningBunny
 * Date: 3/22/2013
 * Time: 2:41 PM
 * 
 * 
 */
namespace AranockAssist
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.tbCurrentHealth = new System.Windows.Forms.TextBox();
			this.tbMaxHealth = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.tbMaxEndurance = new System.Windows.Forms.TextBox();
			this.tbCurrentEndurance = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.tbMaxMana = new System.Windows.Forms.TextBox();
			this.tbCurrentMana = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.btnReadValues = new System.Windows.Forms.Button();
			this.btnTestClick = new System.Windows.Forms.Button();
			this.timerUpdateGUI = new System.Windows.Forms.Timer(this.components);
			this.btnAutoMine = new System.Windows.Forms.Button();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.timer2 = new System.Windows.Forms.Timer(this.components);
			this.timer3 = new System.Windows.Forms.Timer(this.components);
			this.cbTimer1 = new System.Windows.Forms.CheckBox();
			this.cbTimer2 = new System.Windows.Forms.CheckBox();
			this.cbTimer3 = new System.Windows.Forms.CheckBox();
			this.tbTimer1Interval = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.tbTimer2Value = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.tbTimer3Value = new System.Windows.Forms.TextBox();
			this.comboBoxFn2 = new System.Windows.Forms.ComboBox();
			this.comboBoxKey2 = new System.Windows.Forms.ComboBox();
			this.comboBoxFn3 = new System.Windows.Forms.ComboBox();
			this.comboBoxKey3 = new System.Windows.Forms.ComboBox();
			this.label11 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.label13 = new System.Windows.Forms.Label();
			this.label14 = new System.Windows.Forms.Label();
			this.label15 = new System.Windows.Forms.Label();
			this.label16 = new System.Windows.Forms.Label();
			this.comboBoxType3 = new System.Windows.Forms.ComboBox();
			this.comboBoxType2 = new System.Windows.Forms.ComboBox();
			this.comboBoxOperation3 = new System.Windows.Forms.ComboBox();
			this.comboBoxOperation2 = new System.Windows.Forms.ComboBox();
			this.tbMouseY = new System.Windows.Forms.TextBox();
			this.tbMouseX = new System.Windows.Forms.TextBox();
			this.label17 = new System.Windows.Forms.Label();
			this.label18 = new System.Windows.Forms.Label();
			this.timerGetPos1 = new System.Windows.Forms.Timer(this.components);
			this.cbGetPos1 = new System.Windows.Forms.CheckBox();
			this.tbPos1X = new System.Windows.Forms.TextBox();
			this.tbPos1Y = new System.Windows.Forms.TextBox();
			this.label19 = new System.Windows.Forms.Label();
			this.label20 = new System.Windows.Forms.Label();
			this.tbPos2X = new System.Windows.Forms.TextBox();
			this.tbPos2Y = new System.Windows.Forms.TextBox();
			this.cbGetPos2 = new System.Windows.Forms.CheckBox();
			this.timerGetPos2 = new System.Windows.Forms.Timer(this.components);
			this.timerAutoMine = new System.Windows.Forms.Timer(this.components);
			this.tbAutomineCounter = new System.Windows.Forms.TextBox();
			this.label21 = new System.Windows.Forms.Label();
			this.label22 = new System.Windows.Forms.Label();
			this.tbTimer2Interval = new System.Windows.Forms.TextBox();
			this.label23 = new System.Windows.Forms.Label();
			this.tbTimer3Interval = new System.Windows.Forms.TextBox();
			this.comboBoxOperation1 = new System.Windows.Forms.ComboBox();
			this.comboBoxType1 = new System.Windows.Forms.ComboBox();
			this.label24 = new System.Windows.Forms.Label();
			this.label25 = new System.Windows.Forms.Label();
			this.label26 = new System.Windows.Forms.Label();
			this.comboBoxFn1 = new System.Windows.Forms.ComboBox();
			this.comboBoxKey1 = new System.Windows.Forms.ComboBox();
			this.label27 = new System.Windows.Forms.Label();
			this.tbTimer1Value = new System.Windows.Forms.TextBox();
			this.label10 = new System.Windows.Forms.Label();
			this.tbTimer5Interval = new System.Windows.Forms.TextBox();
			this.label28 = new System.Windows.Forms.Label();
			this.tbTimer4Interval = new System.Windows.Forms.TextBox();
			this.comboBoxOperation5 = new System.Windows.Forms.ComboBox();
			this.comboBoxOperation4 = new System.Windows.Forms.ComboBox();
			this.comboBoxType5 = new System.Windows.Forms.ComboBox();
			this.comboBoxType4 = new System.Windows.Forms.ComboBox();
			this.label29 = new System.Windows.Forms.Label();
			this.label30 = new System.Windows.Forms.Label();
			this.label31 = new System.Windows.Forms.Label();
			this.label32 = new System.Windows.Forms.Label();
			this.label33 = new System.Windows.Forms.Label();
			this.label34 = new System.Windows.Forms.Label();
			this.comboBoxFn5 = new System.Windows.Forms.ComboBox();
			this.comboBoxKey5 = new System.Windows.Forms.ComboBox();
			this.comboBoxFn4 = new System.Windows.Forms.ComboBox();
			this.comboBoxKey4 = new System.Windows.Forms.ComboBox();
			this.label35 = new System.Windows.Forms.Label();
			this.tbTimer5Value = new System.Windows.Forms.TextBox();
			this.label36 = new System.Windows.Forms.Label();
			this.tbTimer4Value = new System.Windows.Forms.TextBox();
			this.cbTimer5 = new System.Windows.Forms.CheckBox();
			this.cbTimer4 = new System.Windows.Forms.CheckBox();
			this.timer4 = new System.Windows.Forms.Timer(this.components);
			this.timer5 = new System.Windows.Forms.Timer(this.components);
			this.SuspendLayout();
			// 
			// tbCurrentHealth
			// 
			this.tbCurrentHealth.Location = new System.Drawing.Point(85, 5);
			this.tbCurrentHealth.Name = "tbCurrentHealth";
			this.tbCurrentHealth.Size = new System.Drawing.Size(35, 20);
			this.tbCurrentHealth.TabIndex = 0;
			this.tbCurrentHealth.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// tbMaxHealth
			// 
			this.tbMaxHealth.Location = new System.Drawing.Point(135, 5);
			this.tbMaxHealth.Name = "tbMaxHealth";
			this.tbMaxHealth.Size = new System.Drawing.Size(35, 20);
			this.tbMaxHealth.TabIndex = 1;
			this.tbMaxHealth.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(120, 10);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(12, 13);
			this.label1.TabIndex = 2;
			this.label1.Text = "/";
			this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(120, 30);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(12, 13);
			this.label2.TabIndex = 5;
			this.label2.Text = "/";
			this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// tbMaxEndurance
			// 
			this.tbMaxEndurance.Location = new System.Drawing.Point(135, 25);
			this.tbMaxEndurance.Name = "tbMaxEndurance";
			this.tbMaxEndurance.Size = new System.Drawing.Size(35, 20);
			this.tbMaxEndurance.TabIndex = 4;
			this.tbMaxEndurance.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// tbCurrentEndurance
			// 
			this.tbCurrentEndurance.Location = new System.Drawing.Point(85, 25);
			this.tbCurrentEndurance.Name = "tbCurrentEndurance";
			this.tbCurrentEndurance.Size = new System.Drawing.Size(35, 20);
			this.tbCurrentEndurance.TabIndex = 3;
			this.tbCurrentEndurance.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(120, 50);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(12, 13);
			this.label3.TabIndex = 8;
			this.label3.Text = "/";
			this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// tbMaxMana
			// 
			this.tbMaxMana.Location = new System.Drawing.Point(135, 45);
			this.tbMaxMana.Name = "tbMaxMana";
			this.tbMaxMana.Size = new System.Drawing.Size(35, 20);
			this.tbMaxMana.TabIndex = 7;
			this.tbMaxMana.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// tbCurrentMana
			// 
			this.tbCurrentMana.Location = new System.Drawing.Point(85, 45);
			this.tbCurrentMana.Name = "tbCurrentMana";
			this.tbCurrentMana.Size = new System.Drawing.Size(35, 20);
			this.tbCurrentMana.TabIndex = 6;
			this.tbCurrentMana.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.Color.DarkRed;
			this.label4.Location = new System.Drawing.Point(5, 10);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(80, 15);
			this.label4.TabIndex = 9;
			this.label4.Text = "Health:";
			this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// label5
			// 
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.ForeColor = System.Drawing.Color.DarkGreen;
			this.label5.Location = new System.Drawing.Point(5, 30);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(80, 15);
			this.label5.TabIndex = 10;
			this.label5.Text = "Endurance:";
			this.label5.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// label6
			// 
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.ForeColor = System.Drawing.Color.DarkBlue;
			this.label6.Location = new System.Drawing.Point(5, 50);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(80, 15);
			this.label6.TabIndex = 11;
			this.label6.Text = "Mana:";
			this.label6.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// btnReadValues
			// 
			this.btnReadValues.Location = new System.Drawing.Point(195, 10);
			this.btnReadValues.Name = "btnReadValues";
			this.btnReadValues.Size = new System.Drawing.Size(120, 23);
			this.btnReadValues.TabIndex = 12;
			this.btnReadValues.Text = "Start Reading Values";
			this.btnReadValues.UseVisualStyleBackColor = true;
			this.btnReadValues.Click += new System.EventHandler(this.BtnStartTimerClick);
			// 
			// btnTestClick
			// 
			this.btnTestClick.Location = new System.Drawing.Point(125, 395);
			this.btnTestClick.Name = "btnTestClick";
			this.btnTestClick.Size = new System.Drawing.Size(120, 23);
			this.btnTestClick.TabIndex = 13;
			this.btnTestClick.Text = "Test Click";
			this.btnTestClick.UseVisualStyleBackColor = true;
			this.btnTestClick.Click += new System.EventHandler(this.BtnTestClickClick);
			// 
			// timerUpdateGUI
			// 
			this.timerUpdateGUI.Interval = 500;
			this.timerUpdateGUI.Tick += new System.EventHandler(this.TimerUpdateGUITick);
			// 
			// btnAutoMine
			// 
			this.btnAutoMine.Location = new System.Drawing.Point(125, 370);
			this.btnAutoMine.Name = "btnAutoMine";
			this.btnAutoMine.Size = new System.Drawing.Size(120, 23);
			this.btnAutoMine.TabIndex = 14;
			this.btnAutoMine.Text = "AutoMine Start";
			this.btnAutoMine.UseVisualStyleBackColor = true;
			this.btnAutoMine.Click += new System.EventHandler(this.BtnAutoMineClick);
			// 
			// timer1
			// 
			this.timer1.Interval = 3000;
			this.timer1.Tick += new System.EventHandler(this.Timer1Tick);
			// 
			// timer2
			// 
			this.timer2.Interval = 3000;
			this.timer2.Tick += new System.EventHandler(this.Timer2Tick);
			// 
			// timer3
			// 
			this.timer3.Interval = 3000;
			this.timer3.Tick += new System.EventHandler(this.Timer3Tick);
			// 
			// cbTimer1
			// 
			this.cbTimer1.Location = new System.Drawing.Point(30, 105);
			this.cbTimer1.Name = "cbTimer1";
			this.cbTimer1.Size = new System.Drawing.Size(64, 20);
			this.cbTimer1.TabIndex = 15;
			this.cbTimer1.Text = "Timer1 :";
			this.cbTimer1.TextAlign = System.Drawing.ContentAlignment.BottomRight;
			this.cbTimer1.UseVisualStyleBackColor = true;
			this.cbTimer1.CheckedChanged += new System.EventHandler(this.CbTimer1CheckedChanged);
			// 
			// cbTimer2
			// 
			this.cbTimer2.Location = new System.Drawing.Point(30, 130);
			this.cbTimer2.Name = "cbTimer2";
			this.cbTimer2.Size = new System.Drawing.Size(64, 20);
			this.cbTimer2.TabIndex = 16;
			this.cbTimer2.Text = "Timer2 :";
			this.cbTimer2.TextAlign = System.Drawing.ContentAlignment.BottomRight;
			this.cbTimer2.UseVisualStyleBackColor = true;
			this.cbTimer2.CheckedChanged += new System.EventHandler(this.CbTimer2CheckedChanged);
			// 
			// cbTimer3
			// 
			this.cbTimer3.Location = new System.Drawing.Point(30, 155);
			this.cbTimer3.Name = "cbTimer3";
			this.cbTimer3.Size = new System.Drawing.Size(64, 20);
			this.cbTimer3.TabIndex = 17;
			this.cbTimer3.Text = "Timer3 :";
			this.cbTimer3.TextAlign = System.Drawing.ContentAlignment.BottomRight;
			this.cbTimer3.UseVisualStyleBackColor = true;
			this.cbTimer3.CheckedChanged += new System.EventHandler(this.CbTimer3CheckedChanged);
			// 
			// tbTimer1Interval
			// 
			this.tbTimer1Interval.Location = new System.Drawing.Point(135, 105);
			this.tbTimer1Interval.Name = "tbTimer1Interval";
			this.tbTimer1Interval.Size = new System.Drawing.Size(50, 20);
			this.tbTimer1Interval.TabIndex = 18;
			this.tbTimer1Interval.Text = "600";
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(90, 110);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(45, 15);
			this.label7.TabIndex = 19;
			this.label7.Text = "Interval:";
			this.label7.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(188, 135);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(25, 13);
			this.label8.TabIndex = 21;
			this.label8.Text = "IF  (";
			this.label8.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// tbTimer2Value
			// 
			this.tbTimer2Value.Location = new System.Drawing.Point(353, 130);
			this.tbTimer2Value.Name = "tbTimer2Value";
			this.tbTimer2Value.Size = new System.Drawing.Size(40, 20);
			this.tbTimer2Value.TabIndex = 20;
			this.tbTimer2Value.Text = "600";
			this.tbTimer2Value.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(188, 160);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(25, 13);
			this.label9.TabIndex = 23;
			this.label9.Text = "IF  (";
			this.label9.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// tbTimer3Value
			// 
			this.tbTimer3Value.Location = new System.Drawing.Point(353, 155);
			this.tbTimer3Value.Name = "tbTimer3Value";
			this.tbTimer3Value.Size = new System.Drawing.Size(40, 20);
			this.tbTimer3Value.TabIndex = 22;
			this.tbTimer3Value.Text = "600";
			this.tbTimer3Value.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// comboBoxFn2
			// 
			this.comboBoxFn2.FormattingEnabled = true;
			this.comboBoxFn2.Items.AddRange(new object[] {
									"F1",
									"F2",
									"F3",
									"F4",
									"F5",
									"F6",
									"F7",
									"F8",
									"F9",
									"F10",
									"F11",
									"F12"});
			this.comboBoxFn2.Location = new System.Drawing.Point(498, 130);
			this.comboBoxFn2.Name = "comboBoxFn2";
			this.comboBoxFn2.Size = new System.Drawing.Size(45, 21);
			this.comboBoxFn2.TabIndex = 27;
			this.comboBoxFn2.Text = "F6";
			// 
			// comboBoxKey2
			// 
			this.comboBoxKey2.FormattingEnabled = true;
			this.comboBoxKey2.Items.AddRange(new object[] {
									"SHIFT",
									"CTRL",
									"ALT"});
			this.comboBoxKey2.Location = new System.Drawing.Point(423, 130);
			this.comboBoxKey2.Name = "comboBoxKey2";
			this.comboBoxKey2.Size = new System.Drawing.Size(60, 21);
			this.comboBoxKey2.TabIndex = 26;
			this.comboBoxKey2.Text = "CTRL";
			// 
			// comboBoxFn3
			// 
			this.comboBoxFn3.FormattingEnabled = true;
			this.comboBoxFn3.Items.AddRange(new object[] {
									"F1",
									"F2",
									"F3",
									"F4",
									"F5",
									"F6",
									"F7",
									"F8",
									"F9",
									"F10",
									"F11",
									"F12"});
			this.comboBoxFn3.Location = new System.Drawing.Point(498, 155);
			this.comboBoxFn3.Name = "comboBoxFn3";
			this.comboBoxFn3.Size = new System.Drawing.Size(45, 21);
			this.comboBoxFn3.TabIndex = 29;
			this.comboBoxFn3.Text = "F7";
			// 
			// comboBoxKey3
			// 
			this.comboBoxKey3.FormattingEnabled = true;
			this.comboBoxKey3.Items.AddRange(new object[] {
									"SHIFT",
									"CTRL",
									"ALT"});
			this.comboBoxKey3.Location = new System.Drawing.Point(423, 155);
			this.comboBoxKey3.Name = "comboBoxKey3";
			this.comboBoxKey3.Size = new System.Drawing.Size(60, 21);
			this.comboBoxKey3.TabIndex = 28;
			this.comboBoxKey3.Text = "CTRL";
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Location = new System.Drawing.Point(398, 135);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(20, 13);
			this.label11.TabIndex = 31;
			this.label11.Text = ")  {";
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Location = new System.Drawing.Point(398, 160);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(20, 13);
			this.label12.TabIndex = 32;
			this.label12.Text = ")  {";
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Location = new System.Drawing.Point(483, 160);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(13, 13);
			this.label13.TabIndex = 34;
			this.label13.Text = "+";
			// 
			// label14
			// 
			this.label14.AutoSize = true;
			this.label14.Location = new System.Drawing.Point(483, 135);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(13, 13);
			this.label14.TabIndex = 33;
			this.label14.Text = "+";
			// 
			// label15
			// 
			this.label15.AutoSize = true;
			this.label15.Location = new System.Drawing.Point(548, 160);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(11, 13);
			this.label15.TabIndex = 36;
			this.label15.Text = "}";
			// 
			// label16
			// 
			this.label16.AutoSize = true;
			this.label16.Location = new System.Drawing.Point(548, 135);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(11, 13);
			this.label16.TabIndex = 35;
			this.label16.Text = "}";
			// 
			// comboBoxType3
			// 
			this.comboBoxType3.FormattingEnabled = true;
			this.comboBoxType3.Items.AddRange(new object[] {
									"Health",
									"Endurance",
									"Mana"});
			this.comboBoxType3.Location = new System.Drawing.Point(213, 155);
			this.comboBoxType3.Name = "comboBoxType3";
			this.comboBoxType3.Size = new System.Drawing.Size(75, 21);
			this.comboBoxType3.TabIndex = 38;
			this.comboBoxType3.Text = "Timer";
			// 
			// comboBoxType2
			// 
			this.comboBoxType2.FormattingEnabled = true;
			this.comboBoxType2.Items.AddRange(new object[] {
									"Health",
									"Endurance",
									"Mana",
									"Timer"});
			this.comboBoxType2.Location = new System.Drawing.Point(213, 130);
			this.comboBoxType2.Name = "comboBoxType2";
			this.comboBoxType2.Size = new System.Drawing.Size(75, 21);
			this.comboBoxType2.TabIndex = 37;
			this.comboBoxType2.Text = "Timer";
			// 
			// comboBoxOperation3
			// 
			this.comboBoxOperation3.FormattingEnabled = true;
			this.comboBoxOperation3.Items.AddRange(new object[] {
									"<",
									"=",
									">"});
			this.comboBoxOperation3.Location = new System.Drawing.Point(298, 155);
			this.comboBoxOperation3.Name = "comboBoxOperation3";
			this.comboBoxOperation3.Size = new System.Drawing.Size(35, 21);
			this.comboBoxOperation3.TabIndex = 40;
			this.comboBoxOperation3.Text = "<";
			// 
			// comboBoxOperation2
			// 
			this.comboBoxOperation2.FormattingEnabled = true;
			this.comboBoxOperation2.Items.AddRange(new object[] {
									"<",
									"=",
									">"});
			this.comboBoxOperation2.Location = new System.Drawing.Point(298, 130);
			this.comboBoxOperation2.Name = "comboBoxOperation2";
			this.comboBoxOperation2.Size = new System.Drawing.Size(35, 21);
			this.comboBoxOperation2.TabIndex = 39;
			this.comboBoxOperation2.Text = "<";
			// 
			// tbMouseY
			// 
			this.tbMouseY.Location = new System.Drawing.Point(180, 295);
			this.tbMouseY.Name = "tbMouseY";
			this.tbMouseY.Size = new System.Drawing.Size(60, 20);
			this.tbMouseY.TabIndex = 42;
			this.tbMouseY.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// tbMouseX
			// 
			this.tbMouseX.Location = new System.Drawing.Point(180, 275);
			this.tbMouseX.Name = "tbMouseX";
			this.tbMouseX.Size = new System.Drawing.Size(60, 20);
			this.tbMouseX.TabIndex = 41;
			this.tbMouseX.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// label17
			// 
			this.label17.AutoSize = true;
			this.label17.Location = new System.Drawing.Point(155, 300);
			this.label17.Name = "label17";
			this.label17.Size = new System.Drawing.Size(17, 13);
			this.label17.TabIndex = 44;
			this.label17.Text = "Y:";
			this.label17.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// label18
			// 
			this.label18.AutoSize = true;
			this.label18.Location = new System.Drawing.Point(155, 280);
			this.label18.Name = "label18";
			this.label18.Size = new System.Drawing.Size(17, 13);
			this.label18.TabIndex = 43;
			this.label18.Text = "X:";
			this.label18.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// timerGetPos1
			// 
			this.timerGetPos1.Interval = 10000;
			this.timerGetPos1.Tick += new System.EventHandler(this.TimerGetPos1Tick);
			// 
			// cbGetPos1
			// 
			this.cbGetPos1.Location = new System.Drawing.Point(15, 320);
			this.cbGetPos1.Name = "cbGetPos1";
			this.cbGetPos1.Size = new System.Drawing.Size(125, 20);
			this.cbGetPos1.TabIndex = 45;
			this.cbGetPos1.Text = "Get first position:";
			this.cbGetPos1.UseVisualStyleBackColor = true;
			this.cbGetPos1.CheckedChanged += new System.EventHandler(this.CbGetPos1CheckedChanged);
			// 
			// tbPos1X
			// 
			this.tbPos1X.Location = new System.Drawing.Point(145, 320);
			this.tbPos1X.Name = "tbPos1X";
			this.tbPos1X.Size = new System.Drawing.Size(45, 20);
			this.tbPos1X.TabIndex = 47;
			this.tbPos1X.Text = "373";
			this.tbPos1X.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// tbPos1Y
			// 
			this.tbPos1Y.Location = new System.Drawing.Point(200, 320);
			this.tbPos1Y.Name = "tbPos1Y";
			this.tbPos1Y.Size = new System.Drawing.Size(45, 20);
			this.tbPos1Y.TabIndex = 46;
			this.tbPos1Y.Text = "415";
			this.tbPos1Y.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// label19
			// 
			this.label19.AutoSize = true;
			this.label19.Location = new System.Drawing.Point(190, 320);
			this.label19.Name = "label19";
			this.label19.Size = new System.Drawing.Size(10, 13);
			this.label19.TabIndex = 48;
			this.label19.Text = ":";
			this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label20
			// 
			this.label20.AutoSize = true;
			this.label20.Location = new System.Drawing.Point(190, 340);
			this.label20.Name = "label20";
			this.label20.Size = new System.Drawing.Size(10, 13);
			this.label20.TabIndex = 52;
			this.label20.Text = ":";
			this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// tbPos2X
			// 
			this.tbPos2X.Location = new System.Drawing.Point(145, 340);
			this.tbPos2X.Name = "tbPos2X";
			this.tbPos2X.Size = new System.Drawing.Size(45, 20);
			this.tbPos2X.TabIndex = 51;
			this.tbPos2X.Text = "0";
			this.tbPos2X.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// tbPos2Y
			// 
			this.tbPos2Y.Location = new System.Drawing.Point(200, 340);
			this.tbPos2Y.Name = "tbPos2Y";
			this.tbPos2Y.Size = new System.Drawing.Size(45, 20);
			this.tbPos2Y.TabIndex = 50;
			this.tbPos2Y.Text = "0";
			this.tbPos2Y.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// cbGetPos2
			// 
			this.cbGetPos2.Location = new System.Drawing.Point(15, 340);
			this.cbGetPos2.Name = "cbGetPos2";
			this.cbGetPos2.Size = new System.Drawing.Size(125, 20);
			this.cbGetPos2.TabIndex = 49;
			this.cbGetPos2.Text = "Get second position:";
			this.cbGetPos2.UseVisualStyleBackColor = true;
			this.cbGetPos2.CheckedChanged += new System.EventHandler(this.CbGetPos2CheckedChanged);
			// 
			// timerGetPos2
			// 
			this.timerGetPos2.Interval = 10000;
			this.timerGetPos2.Tick += new System.EventHandler(this.TimerGetPos2Tick);
			// 
			// timerAutoMine
			// 
			this.timerAutoMine.Interval = 6000;
			this.timerAutoMine.Tick += new System.EventHandler(this.TimerAutoMineTick);
			// 
			// tbAutomineCounter
			// 
			this.tbAutomineCounter.Location = new System.Drawing.Point(275, 320);
			this.tbAutomineCounter.Name = "tbAutomineCounter";
			this.tbAutomineCounter.Size = new System.Drawing.Size(45, 20);
			this.tbAutomineCounter.TabIndex = 53;
			this.tbAutomineCounter.Text = "15";
			this.tbAutomineCounter.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// label21
			// 
			this.label21.AutoSize = true;
			this.label21.Location = new System.Drawing.Point(260, 325);
			this.label21.Name = "label21";
			this.label21.Size = new System.Drawing.Size(14, 13);
			this.label21.TabIndex = 54;
			this.label21.Text = "X";
			// 
			// label22
			// 
			this.label22.Location = new System.Drawing.Point(90, 135);
			this.label22.Name = "label22";
			this.label22.Size = new System.Drawing.Size(45, 15);
			this.label22.TabIndex = 56;
			this.label22.Text = "Interval:";
			this.label22.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// tbTimer2Interval
			// 
			this.tbTimer2Interval.Location = new System.Drawing.Point(135, 130);
			this.tbTimer2Interval.Name = "tbTimer2Interval";
			this.tbTimer2Interval.Size = new System.Drawing.Size(50, 20);
			this.tbTimer2Interval.TabIndex = 55;
			this.tbTimer2Interval.Text = "600";
			// 
			// label23
			// 
			this.label23.Location = new System.Drawing.Point(90, 160);
			this.label23.Name = "label23";
			this.label23.Size = new System.Drawing.Size(45, 15);
			this.label23.TabIndex = 58;
			this.label23.Text = "Interval:";
			this.label23.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// tbTimer3Interval
			// 
			this.tbTimer3Interval.Location = new System.Drawing.Point(135, 155);
			this.tbTimer3Interval.Name = "tbTimer3Interval";
			this.tbTimer3Interval.Size = new System.Drawing.Size(50, 20);
			this.tbTimer3Interval.TabIndex = 57;
			this.tbTimer3Interval.Text = "600";
			// 
			// comboBoxOperation1
			// 
			this.comboBoxOperation1.FormattingEnabled = true;
			this.comboBoxOperation1.Items.AddRange(new object[] {
									"<",
									"=",
									">"});
			this.comboBoxOperation1.Location = new System.Drawing.Point(300, 105);
			this.comboBoxOperation1.Name = "comboBoxOperation1";
			this.comboBoxOperation1.Size = new System.Drawing.Size(35, 21);
			this.comboBoxOperation1.TabIndex = 67;
			this.comboBoxOperation1.Text = "<";
			// 
			// comboBoxType1
			// 
			this.comboBoxType1.FormattingEnabled = true;
			this.comboBoxType1.Items.AddRange(new object[] {
									"Health",
									"Endurance",
									"Mana",
									"Timer"});
			this.comboBoxType1.Location = new System.Drawing.Point(215, 105);
			this.comboBoxType1.Name = "comboBoxType1";
			this.comboBoxType1.Size = new System.Drawing.Size(75, 21);
			this.comboBoxType1.TabIndex = 66;
			this.comboBoxType1.Text = "Timer";
			// 
			// label24
			// 
			this.label24.AutoSize = true;
			this.label24.Location = new System.Drawing.Point(550, 110);
			this.label24.Name = "label24";
			this.label24.Size = new System.Drawing.Size(11, 13);
			this.label24.TabIndex = 65;
			this.label24.Text = "}";
			// 
			// label25
			// 
			this.label25.AutoSize = true;
			this.label25.Location = new System.Drawing.Point(485, 110);
			this.label25.Name = "label25";
			this.label25.Size = new System.Drawing.Size(13, 13);
			this.label25.TabIndex = 64;
			this.label25.Text = "+";
			// 
			// label26
			// 
			this.label26.AutoSize = true;
			this.label26.Location = new System.Drawing.Point(400, 110);
			this.label26.Name = "label26";
			this.label26.Size = new System.Drawing.Size(20, 13);
			this.label26.TabIndex = 63;
			this.label26.Text = ")  {";
			// 
			// comboBoxFn1
			// 
			this.comboBoxFn1.FormattingEnabled = true;
			this.comboBoxFn1.Items.AddRange(new object[] {
									"F1",
									"F2",
									"F3",
									"F4",
									"F5",
									"F6",
									"F7",
									"F8",
									"F9",
									"F10",
									"F11",
									"F12"});
			this.comboBoxFn1.Location = new System.Drawing.Point(500, 105);
			this.comboBoxFn1.Name = "comboBoxFn1";
			this.comboBoxFn1.Size = new System.Drawing.Size(45, 21);
			this.comboBoxFn1.TabIndex = 62;
			this.comboBoxFn1.Text = "F6";
			// 
			// comboBoxKey1
			// 
			this.comboBoxKey1.FormattingEnabled = true;
			this.comboBoxKey1.Items.AddRange(new object[] {
									"SHIFT",
									"CTRL",
									"ALT"});
			this.comboBoxKey1.Location = new System.Drawing.Point(425, 105);
			this.comboBoxKey1.Name = "comboBoxKey1";
			this.comboBoxKey1.Size = new System.Drawing.Size(60, 21);
			this.comboBoxKey1.TabIndex = 61;
			this.comboBoxKey1.Text = "CTRL";
			// 
			// label27
			// 
			this.label27.AutoSize = true;
			this.label27.Location = new System.Drawing.Point(190, 110);
			this.label27.Name = "label27";
			this.label27.Size = new System.Drawing.Size(25, 13);
			this.label27.TabIndex = 60;
			this.label27.Text = "IF  (";
			this.label27.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// tbTimer1Value
			// 
			this.tbTimer1Value.Location = new System.Drawing.Point(355, 105);
			this.tbTimer1Value.Name = "tbTimer1Value";
			this.tbTimer1Value.Size = new System.Drawing.Size(40, 20);
			this.tbTimer1Value.TabIndex = 59;
			this.tbTimer1Value.Text = "600";
			this.tbTimer1Value.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// label10
			// 
			this.label10.Location = new System.Drawing.Point(90, 210);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(45, 15);
			this.label10.TabIndex = 91;
			this.label10.Text = "Interval:";
			this.label10.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// tbTimer5Interval
			// 
			this.tbTimer5Interval.Location = new System.Drawing.Point(135, 205);
			this.tbTimer5Interval.Name = "tbTimer5Interval";
			this.tbTimer5Interval.Size = new System.Drawing.Size(50, 20);
			this.tbTimer5Interval.TabIndex = 90;
			this.tbTimer5Interval.Text = "600";
			// 
			// label28
			// 
			this.label28.Location = new System.Drawing.Point(90, 185);
			this.label28.Name = "label28";
			this.label28.Size = new System.Drawing.Size(45, 15);
			this.label28.TabIndex = 89;
			this.label28.Text = "Interval:";
			this.label28.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// tbTimer4Interval
			// 
			this.tbTimer4Interval.Location = new System.Drawing.Point(135, 180);
			this.tbTimer4Interval.Name = "tbTimer4Interval";
			this.tbTimer4Interval.Size = new System.Drawing.Size(50, 20);
			this.tbTimer4Interval.TabIndex = 88;
			this.tbTimer4Interval.Text = "600";
			// 
			// comboBoxOperation5
			// 
			this.comboBoxOperation5.FormattingEnabled = true;
			this.comboBoxOperation5.Items.AddRange(new object[] {
									"<",
									"=",
									">"});
			this.comboBoxOperation5.Location = new System.Drawing.Point(298, 205);
			this.comboBoxOperation5.Name = "comboBoxOperation5";
			this.comboBoxOperation5.Size = new System.Drawing.Size(35, 21);
			this.comboBoxOperation5.TabIndex = 87;
			this.comboBoxOperation5.Text = "<";
			// 
			// comboBoxOperation4
			// 
			this.comboBoxOperation4.FormattingEnabled = true;
			this.comboBoxOperation4.Items.AddRange(new object[] {
									"<",
									"=",
									">"});
			this.comboBoxOperation4.Location = new System.Drawing.Point(298, 180);
			this.comboBoxOperation4.Name = "comboBoxOperation4";
			this.comboBoxOperation4.Size = new System.Drawing.Size(35, 21);
			this.comboBoxOperation4.TabIndex = 86;
			this.comboBoxOperation4.Text = "<";
			// 
			// comboBoxType5
			// 
			this.comboBoxType5.FormattingEnabled = true;
			this.comboBoxType5.Items.AddRange(new object[] {
									"Health",
									"Endurance",
									"Mana"});
			this.comboBoxType5.Location = new System.Drawing.Point(213, 205);
			this.comboBoxType5.Name = "comboBoxType5";
			this.comboBoxType5.Size = new System.Drawing.Size(75, 21);
			this.comboBoxType5.TabIndex = 85;
			this.comboBoxType5.Text = "Health";
			// 
			// comboBoxType4
			// 
			this.comboBoxType4.FormattingEnabled = true;
			this.comboBoxType4.Items.AddRange(new object[] {
									"Health",
									"Endurance",
									"Mana",
									"Timer"});
			this.comboBoxType4.Location = new System.Drawing.Point(213, 180);
			this.comboBoxType4.Name = "comboBoxType4";
			this.comboBoxType4.Size = new System.Drawing.Size(75, 21);
			this.comboBoxType4.TabIndex = 84;
			this.comboBoxType4.Text = "Timer";
			// 
			// label29
			// 
			this.label29.AutoSize = true;
			this.label29.Location = new System.Drawing.Point(548, 210);
			this.label29.Name = "label29";
			this.label29.Size = new System.Drawing.Size(11, 13);
			this.label29.TabIndex = 83;
			this.label29.Text = "}";
			// 
			// label30
			// 
			this.label30.AutoSize = true;
			this.label30.Location = new System.Drawing.Point(548, 185);
			this.label30.Name = "label30";
			this.label30.Size = new System.Drawing.Size(11, 13);
			this.label30.TabIndex = 82;
			this.label30.Text = "}";
			// 
			// label31
			// 
			this.label31.AutoSize = true;
			this.label31.Location = new System.Drawing.Point(483, 210);
			this.label31.Name = "label31";
			this.label31.Size = new System.Drawing.Size(13, 13);
			this.label31.TabIndex = 81;
			this.label31.Text = "+";
			// 
			// label32
			// 
			this.label32.AutoSize = true;
			this.label32.Location = new System.Drawing.Point(483, 185);
			this.label32.Name = "label32";
			this.label32.Size = new System.Drawing.Size(13, 13);
			this.label32.TabIndex = 80;
			this.label32.Text = "+";
			// 
			// label33
			// 
			this.label33.AutoSize = true;
			this.label33.Location = new System.Drawing.Point(398, 210);
			this.label33.Name = "label33";
			this.label33.Size = new System.Drawing.Size(20, 13);
			this.label33.TabIndex = 79;
			this.label33.Text = ")  {";
			// 
			// label34
			// 
			this.label34.AutoSize = true;
			this.label34.Location = new System.Drawing.Point(398, 185);
			this.label34.Name = "label34";
			this.label34.Size = new System.Drawing.Size(20, 13);
			this.label34.TabIndex = 78;
			this.label34.Text = ")  {";
			// 
			// comboBoxFn5
			// 
			this.comboBoxFn5.FormattingEnabled = true;
			this.comboBoxFn5.Items.AddRange(new object[] {
									"F1",
									"F2",
									"F3",
									"F4",
									"F5",
									"F6",
									"F7",
									"F8",
									"F9",
									"F10",
									"F11",
									"F12"});
			this.comboBoxFn5.Location = new System.Drawing.Point(498, 205);
			this.comboBoxFn5.Name = "comboBoxFn5";
			this.comboBoxFn5.Size = new System.Drawing.Size(45, 21);
			this.comboBoxFn5.TabIndex = 77;
			this.comboBoxFn5.Text = "F7";
			// 
			// comboBoxKey5
			// 
			this.comboBoxKey5.FormattingEnabled = true;
			this.comboBoxKey5.Items.AddRange(new object[] {
									"SHIFT",
									"CTRL",
									"ALT"});
			this.comboBoxKey5.Location = new System.Drawing.Point(423, 205);
			this.comboBoxKey5.Name = "comboBoxKey5";
			this.comboBoxKey5.Size = new System.Drawing.Size(60, 21);
			this.comboBoxKey5.TabIndex = 76;
			this.comboBoxKey5.Text = "CTRL";
			// 
			// comboBoxFn4
			// 
			this.comboBoxFn4.FormattingEnabled = true;
			this.comboBoxFn4.Items.AddRange(new object[] {
									"F1",
									"F2",
									"F3",
									"F4",
									"F5",
									"F6",
									"F7",
									"F8",
									"F9",
									"F10",
									"F11",
									"F12"});
			this.comboBoxFn4.Location = new System.Drawing.Point(498, 180);
			this.comboBoxFn4.Name = "comboBoxFn4";
			this.comboBoxFn4.Size = new System.Drawing.Size(45, 21);
			this.comboBoxFn4.TabIndex = 75;
			this.comboBoxFn4.Text = "F6";
			// 
			// comboBoxKey4
			// 
			this.comboBoxKey4.FormattingEnabled = true;
			this.comboBoxKey4.Items.AddRange(new object[] {
									"SHIFT",
									"CTRL",
									"ALT"});
			this.comboBoxKey4.Location = new System.Drawing.Point(423, 180);
			this.comboBoxKey4.Name = "comboBoxKey4";
			this.comboBoxKey4.Size = new System.Drawing.Size(60, 21);
			this.comboBoxKey4.TabIndex = 74;
			this.comboBoxKey4.Text = "CTRL";
			// 
			// label35
			// 
			this.label35.AutoSize = true;
			this.label35.Location = new System.Drawing.Point(188, 210);
			this.label35.Name = "label35";
			this.label35.Size = new System.Drawing.Size(25, 13);
			this.label35.TabIndex = 73;
			this.label35.Text = "IF  (";
			this.label35.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// tbTimer5Value
			// 
			this.tbTimer5Value.Location = new System.Drawing.Point(353, 205);
			this.tbTimer5Value.Name = "tbTimer5Value";
			this.tbTimer5Value.Size = new System.Drawing.Size(40, 20);
			this.tbTimer5Value.TabIndex = 72;
			this.tbTimer5Value.Text = "600";
			this.tbTimer5Value.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// label36
			// 
			this.label36.AutoSize = true;
			this.label36.Location = new System.Drawing.Point(188, 185);
			this.label36.Name = "label36";
			this.label36.Size = new System.Drawing.Size(25, 13);
			this.label36.TabIndex = 71;
			this.label36.Text = "IF  (";
			this.label36.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// tbTimer4Value
			// 
			this.tbTimer4Value.Location = new System.Drawing.Point(353, 180);
			this.tbTimer4Value.Name = "tbTimer4Value";
			this.tbTimer4Value.Size = new System.Drawing.Size(40, 20);
			this.tbTimer4Value.TabIndex = 70;
			this.tbTimer4Value.Text = "600";
			this.tbTimer4Value.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// cbTimer5
			// 
			this.cbTimer5.Location = new System.Drawing.Point(30, 205);
			this.cbTimer5.Name = "cbTimer5";
			this.cbTimer5.Size = new System.Drawing.Size(64, 20);
			this.cbTimer5.TabIndex = 69;
			this.cbTimer5.Text = "Timer5 :";
			this.cbTimer5.TextAlign = System.Drawing.ContentAlignment.BottomRight;
			this.cbTimer5.UseVisualStyleBackColor = true;
			this.cbTimer5.CheckedChanged += new System.EventHandler(this.CbTimer5CheckedChanged);
			// 
			// cbTimer4
			// 
			this.cbTimer4.Location = new System.Drawing.Point(30, 180);
			this.cbTimer4.Name = "cbTimer4";
			this.cbTimer4.Size = new System.Drawing.Size(64, 20);
			this.cbTimer4.TabIndex = 68;
			this.cbTimer4.Text = "Timer4 :";
			this.cbTimer4.TextAlign = System.Drawing.ContentAlignment.BottomRight;
			this.cbTimer4.UseVisualStyleBackColor = true;
			this.cbTimer4.CheckedChanged += new System.EventHandler(this.CbTimer4CheckedChanged);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(607, 424);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.tbTimer5Interval);
			this.Controls.Add(this.label28);
			this.Controls.Add(this.tbTimer4Interval);
			this.Controls.Add(this.comboBoxOperation5);
			this.Controls.Add(this.comboBoxOperation4);
			this.Controls.Add(this.comboBoxType5);
			this.Controls.Add(this.comboBoxType4);
			this.Controls.Add(this.label29);
			this.Controls.Add(this.label30);
			this.Controls.Add(this.label31);
			this.Controls.Add(this.label32);
			this.Controls.Add(this.label33);
			this.Controls.Add(this.label34);
			this.Controls.Add(this.comboBoxFn5);
			this.Controls.Add(this.comboBoxKey5);
			this.Controls.Add(this.comboBoxFn4);
			this.Controls.Add(this.comboBoxKey4);
			this.Controls.Add(this.label35);
			this.Controls.Add(this.tbTimer5Value);
			this.Controls.Add(this.label36);
			this.Controls.Add(this.tbTimer4Value);
			this.Controls.Add(this.cbTimer5);
			this.Controls.Add(this.cbTimer4);
			this.Controls.Add(this.comboBoxOperation1);
			this.Controls.Add(this.comboBoxType1);
			this.Controls.Add(this.label24);
			this.Controls.Add(this.label25);
			this.Controls.Add(this.label26);
			this.Controls.Add(this.comboBoxFn1);
			this.Controls.Add(this.comboBoxKey1);
			this.Controls.Add(this.label27);
			this.Controls.Add(this.tbTimer1Value);
			this.Controls.Add(this.label23);
			this.Controls.Add(this.tbTimer3Interval);
			this.Controls.Add(this.label22);
			this.Controls.Add(this.tbTimer2Interval);
			this.Controls.Add(this.label21);
			this.Controls.Add(this.tbAutomineCounter);
			this.Controls.Add(this.label20);
			this.Controls.Add(this.tbPos2X);
			this.Controls.Add(this.tbPos2Y);
			this.Controls.Add(this.cbGetPos2);
			this.Controls.Add(this.label19);
			this.Controls.Add(this.tbPos1X);
			this.Controls.Add(this.tbPos1Y);
			this.Controls.Add(this.cbGetPos1);
			this.Controls.Add(this.label17);
			this.Controls.Add(this.label18);
			this.Controls.Add(this.tbMouseY);
			this.Controls.Add(this.tbMouseX);
			this.Controls.Add(this.comboBoxOperation3);
			this.Controls.Add(this.comboBoxOperation2);
			this.Controls.Add(this.comboBoxType3);
			this.Controls.Add(this.comboBoxType2);
			this.Controls.Add(this.label15);
			this.Controls.Add(this.label16);
			this.Controls.Add(this.label13);
			this.Controls.Add(this.label14);
			this.Controls.Add(this.label12);
			this.Controls.Add(this.label11);
			this.Controls.Add(this.comboBoxFn3);
			this.Controls.Add(this.comboBoxKey3);
			this.Controls.Add(this.comboBoxFn2);
			this.Controls.Add(this.comboBoxKey2);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.tbTimer3Value);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.tbTimer2Value);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.tbTimer1Interval);
			this.Controls.Add(this.cbTimer3);
			this.Controls.Add(this.cbTimer2);
			this.Controls.Add(this.cbTimer1);
			this.Controls.Add(this.btnAutoMine);
			this.Controls.Add(this.btnTestClick);
			this.Controls.Add(this.btnReadValues);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.tbMaxMana);
			this.Controls.Add(this.tbCurrentMana);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.tbMaxEndurance);
			this.Controls.Add(this.tbCurrentEndurance);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.tbMaxHealth);
			this.Controls.Add(this.tbCurrentHealth);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "MainForm";
			this.Text = "AranockAssist";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Timer timer5;
		private System.Windows.Forms.Timer timer4;
		private System.Windows.Forms.CheckBox cbTimer4;
		private System.Windows.Forms.CheckBox cbTimer5;
		private System.Windows.Forms.TextBox tbTimer4Value;
		private System.Windows.Forms.Label label36;
		private System.Windows.Forms.TextBox tbTimer5Value;
		private System.Windows.Forms.Label label35;
		private System.Windows.Forms.ComboBox comboBoxKey4;
		private System.Windows.Forms.ComboBox comboBoxFn4;
		private System.Windows.Forms.ComboBox comboBoxKey5;
		private System.Windows.Forms.ComboBox comboBoxFn5;
		private System.Windows.Forms.Label label34;
		private System.Windows.Forms.Label label33;
		private System.Windows.Forms.Label label32;
		private System.Windows.Forms.Label label31;
		private System.Windows.Forms.Label label30;
		private System.Windows.Forms.Label label29;
		private System.Windows.Forms.ComboBox comboBoxType4;
		private System.Windows.Forms.ComboBox comboBoxType5;
		private System.Windows.Forms.ComboBox comboBoxOperation4;
		private System.Windows.Forms.ComboBox comboBoxOperation5;
		private System.Windows.Forms.TextBox tbTimer4Interval;
		private System.Windows.Forms.Label label28;
		private System.Windows.Forms.TextBox tbTimer5Interval;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.TextBox tbTimer1Value;
		private System.Windows.Forms.Label label27;
		private System.Windows.Forms.Label label26;
		private System.Windows.Forms.Label label25;
		private System.Windows.Forms.Label label24;
		private System.Windows.Forms.ComboBox comboBoxType1;
		private System.Windows.Forms.ComboBox comboBoxOperation1;
		private System.Windows.Forms.TextBox tbTimer3Interval;
		private System.Windows.Forms.Label label23;
		private System.Windows.Forms.TextBox tbTimer2Interval;
		private System.Windows.Forms.Label label22;
		private System.Windows.Forms.Label label21;
		private System.Windows.Forms.TextBox tbAutomineCounter;
		private System.Windows.Forms.Timer timerAutoMine;
		private System.Windows.Forms.Timer timerGetPos2;
		private System.Windows.Forms.CheckBox cbGetPos2;
		private System.Windows.Forms.TextBox tbPos2Y;
		private System.Windows.Forms.TextBox tbPos2X;
		private System.Windows.Forms.Label label20;
		private System.Windows.Forms.Label label19;
		private System.Windows.Forms.TextBox tbPos1Y;
		private System.Windows.Forms.TextBox tbPos1X;
		private System.Windows.Forms.CheckBox cbGetPos1;
		private System.Windows.Forms.Timer timerGetPos1;
		private System.Windows.Forms.Label label18;
		private System.Windows.Forms.Label label17;
		private System.Windows.Forms.TextBox tbMouseX;
		private System.Windows.Forms.TextBox tbMouseY;
		private System.Windows.Forms.ComboBox comboBoxOperation2;
		private System.Windows.Forms.ComboBox comboBoxOperation3;
		private System.Windows.Forms.ComboBox comboBoxType2;
		private System.Windows.Forms.ComboBox comboBoxType3;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.ComboBox comboBoxKey3;
		private System.Windows.Forms.ComboBox comboBoxFn3;
		private System.Windows.Forms.ComboBox comboBoxKey2;
		private System.Windows.Forms.ComboBox comboBoxFn2;
		private System.Windows.Forms.ComboBox comboBoxFn1;
		private System.Windows.Forms.ComboBox comboBoxKey1;
		private System.Windows.Forms.TextBox tbTimer3Value;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.TextBox tbTimer2Value;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox tbTimer1Interval;
		private System.Windows.Forms.CheckBox cbTimer3;
		private System.Windows.Forms.CheckBox cbTimer2;
		private System.Windows.Forms.CheckBox cbTimer1;
		private System.Windows.Forms.Timer timer3;
		private System.Windows.Forms.Timer timer2;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.Button btnAutoMine;
		private System.Windows.Forms.Timer timerUpdateGUI;
		private System.Windows.Forms.Button btnTestClick;
		private System.Windows.Forms.Button btnReadValues;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox tbCurrentMana;
		private System.Windows.Forms.TextBox tbMaxMana;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox tbCurrentEndurance;
		private System.Windows.Forms.TextBox tbMaxEndurance;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox tbMaxHealth;
		private System.Windows.Forms.TextBox tbCurrentHealth;
	}
}
