namespace InspectorGadgetGui
{
    partial class ExecutionStepForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.EAXLabel = new System.Windows.Forms.Label();
            this.EDILabel = new System.Windows.Forms.Label();
            this.ECXLabel = new System.Windows.Forms.Label();
            this.EBPLabel = new System.Windows.Forms.Label();
            this.ESILabel = new System.Windows.Forms.Label();
            this.EBXLabel = new System.Windows.Forms.Label();
            this.EDXLabel = new System.Windows.Forms.Label();
            this.EIPLabel = new System.Windows.Forms.Label();
            this.ESPLabel = new System.Windows.Forms.Label();
            this.ESP = new System.Windows.Forms.Label();
            this.EDX = new System.Windows.Forms.Label();
            this.EBX = new System.Windows.Forms.Label();
            this.ESI = new System.Windows.Forms.Label();
            this.EBP = new System.Windows.Forms.Label();
            this.ECX = new System.Windows.Forms.Label();
            this.EDI = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.O = new System.Windows.Forms.Label();
            this.T = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.EIP = new System.Windows.Forms.Label();
            this.EIPInfo = new System.Windows.Forms.Label();
            this.ESPInfo = new System.Windows.Forms.Label();
            this.EDXInfo = new System.Windows.Forms.Label();
            this.EBXInfo = new System.Windows.Forms.Label();
            this.ESIInfo = new System.Windows.Forms.Label();
            this.EBPInfo = new System.Windows.Forms.Label();
            this.ECXInfo = new System.Windows.Forms.Label();
            this.EDIInfo = new System.Windows.Forms.Label();
            this.EAXInfo = new System.Windows.Forms.Label();
            this.S = new System.Windows.Forms.Label();
            this.A = new System.Windows.Forms.Label();
            this.Z = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.P = new System.Windows.Forms.Label();
            this.C = new System.Windows.Forms.Label();
            this.stackList = new System.Windows.Forms.ListView();
            this.Address = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Hexdump = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ASCII = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Comment = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CPIndex = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.EAX = new System.Windows.Forms.Label();
            this.stepNumber = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.stackLabel = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.Disassembly = new System.Windows.Forms.RichTextBox();
            this.stackMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editValueMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.replaceWithGadgetMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.lineLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.stackWorker = new System.ComponentModel.BackgroundWorker();
            this.stackMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // EAXLabel
            // 
            this.EAXLabel.AutoSize = true;
            this.EAXLabel.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EAXLabel.ForeColor = System.Drawing.Color.White;
            this.EAXLabel.Location = new System.Drawing.Point(7, 43);
            this.EAXLabel.Name = "EAXLabel";
            this.EAXLabel.Size = new System.Drawing.Size(28, 15);
            this.EAXLabel.TabIndex = 1;
            this.EAXLabel.Text = "EAX";
            // 
            // EDILabel
            // 
            this.EDILabel.AutoSize = true;
            this.EDILabel.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EDILabel.ForeColor = System.Drawing.Color.White;
            this.EDILabel.Location = new System.Drawing.Point(7, 148);
            this.EDILabel.Name = "EDILabel";
            this.EDILabel.Size = new System.Drawing.Size(28, 15);
            this.EDILabel.TabIndex = 2;
            this.EDILabel.Text = "EDI";
            // 
            // ECXLabel
            // 
            this.ECXLabel.AutoSize = true;
            this.ECXLabel.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ECXLabel.ForeColor = System.Drawing.Color.White;
            this.ECXLabel.Location = new System.Drawing.Point(7, 58);
            this.ECXLabel.Name = "ECXLabel";
            this.ECXLabel.Size = new System.Drawing.Size(28, 15);
            this.ECXLabel.TabIndex = 3;
            this.ECXLabel.Text = "ECX";
            // 
            // EBPLabel
            // 
            this.EBPLabel.AutoSize = true;
            this.EBPLabel.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EBPLabel.ForeColor = System.Drawing.Color.White;
            this.EBPLabel.Location = new System.Drawing.Point(7, 118);
            this.EBPLabel.Name = "EBPLabel";
            this.EBPLabel.Size = new System.Drawing.Size(28, 15);
            this.EBPLabel.TabIndex = 4;
            this.EBPLabel.Text = "EBP";
            // 
            // ESILabel
            // 
            this.ESILabel.AutoSize = true;
            this.ESILabel.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ESILabel.ForeColor = System.Drawing.Color.White;
            this.ESILabel.Location = new System.Drawing.Point(7, 133);
            this.ESILabel.Name = "ESILabel";
            this.ESILabel.Size = new System.Drawing.Size(28, 15);
            this.ESILabel.TabIndex = 5;
            this.ESILabel.Text = "ESI";
            // 
            // EBXLabel
            // 
            this.EBXLabel.AutoSize = true;
            this.EBXLabel.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EBXLabel.ForeColor = System.Drawing.Color.White;
            this.EBXLabel.Location = new System.Drawing.Point(7, 88);
            this.EBXLabel.Name = "EBXLabel";
            this.EBXLabel.Size = new System.Drawing.Size(28, 15);
            this.EBXLabel.TabIndex = 6;
            this.EBXLabel.Text = "EBX";
            // 
            // EDXLabel
            // 
            this.EDXLabel.AutoSize = true;
            this.EDXLabel.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EDXLabel.ForeColor = System.Drawing.Color.White;
            this.EDXLabel.Location = new System.Drawing.Point(7, 72);
            this.EDXLabel.Name = "EDXLabel";
            this.EDXLabel.Size = new System.Drawing.Size(28, 15);
            this.EDXLabel.TabIndex = 7;
            this.EDXLabel.Text = "EDX";
            // 
            // EIPLabel
            // 
            this.EIPLabel.AutoSize = true;
            this.EIPLabel.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EIPLabel.ForeColor = System.Drawing.Color.White;
            this.EIPLabel.Location = new System.Drawing.Point(7, 167);
            this.EIPLabel.Name = "EIPLabel";
            this.EIPLabel.Size = new System.Drawing.Size(28, 15);
            this.EIPLabel.TabIndex = 8;
            this.EIPLabel.Text = "EIP";
            // 
            // ESPLabel
            // 
            this.ESPLabel.AutoSize = true;
            this.ESPLabel.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ESPLabel.ForeColor = System.Drawing.Color.White;
            this.ESPLabel.Location = new System.Drawing.Point(7, 103);
            this.ESPLabel.Name = "ESPLabel";
            this.ESPLabel.Size = new System.Drawing.Size(28, 15);
            this.ESPLabel.TabIndex = 9;
            this.ESPLabel.Text = "ESP";
            // 
            // ESP
            // 
            this.ESP.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ESP.ForeColor = System.Drawing.Color.White;
            this.ESP.Location = new System.Drawing.Point(41, 103);
            this.ESP.Name = "ESP";
            this.ESP.Size = new System.Drawing.Size(65, 13);
            this.ESP.TabIndex = 17;
            this.ESP.Text = "00000000";
            this.ESP.MouseClick += new System.Windows.Forms.MouseEventHandler(this.registerLabel_MouseClick);
            // 
            // EDX
            // 
            this.EDX.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EDX.ForeColor = System.Drawing.Color.White;
            this.EDX.Location = new System.Drawing.Point(41, 73);
            this.EDX.Name = "EDX";
            this.EDX.Size = new System.Drawing.Size(65, 13);
            this.EDX.TabIndex = 16;
            this.EDX.Text = "00000000";
            this.EDX.MouseClick += new System.Windows.Forms.MouseEventHandler(this.registerLabel_MouseClick);
            // 
            // EBX
            // 
            this.EBX.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EBX.ForeColor = System.Drawing.Color.White;
            this.EBX.Location = new System.Drawing.Point(41, 88);
            this.EBX.Name = "EBX";
            this.EBX.Size = new System.Drawing.Size(65, 13);
            this.EBX.TabIndex = 15;
            this.EBX.Text = "00000000";
            this.EBX.MouseClick += new System.Windows.Forms.MouseEventHandler(this.registerLabel_MouseClick);
            // 
            // ESI
            // 
            this.ESI.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ESI.ForeColor = System.Drawing.Color.White;
            this.ESI.Location = new System.Drawing.Point(41, 133);
            this.ESI.Name = "ESI";
            this.ESI.Size = new System.Drawing.Size(65, 13);
            this.ESI.TabIndex = 14;
            this.ESI.Text = "00000000";
            this.ESI.MouseClick += new System.Windows.Forms.MouseEventHandler(this.registerLabel_MouseClick);
            // 
            // EBP
            // 
            this.EBP.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EBP.ForeColor = System.Drawing.Color.White;
            this.EBP.Location = new System.Drawing.Point(41, 118);
            this.EBP.Name = "EBP";
            this.EBP.Size = new System.Drawing.Size(65, 13);
            this.EBP.TabIndex = 13;
            this.EBP.Text = "00000000";
            this.EBP.MouseClick += new System.Windows.Forms.MouseEventHandler(this.registerLabel_MouseClick);
            // 
            // ECX
            // 
            this.ECX.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ECX.ForeColor = System.Drawing.Color.White;
            this.ECX.Location = new System.Drawing.Point(41, 58);
            this.ECX.Name = "ECX";
            this.ECX.Size = new System.Drawing.Size(65, 13);
            this.ECX.TabIndex = 12;
            this.ECX.Text = "00000000";
            this.ECX.MouseClick += new System.Windows.Forms.MouseEventHandler(this.registerLabel_MouseClick);
            // 
            // EDI
            // 
            this.EDI.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EDI.ForeColor = System.Drawing.Color.White;
            this.EDI.Location = new System.Drawing.Point(41, 148);
            this.EDI.Name = "EDI";
            this.EDI.Size = new System.Drawing.Size(65, 13);
            this.EDI.TabIndex = 11;
            this.EDI.Text = "00000000";
            this.EDI.MouseClick += new System.Windows.Forms.MouseEventHandler(this.registerLabel_MouseClick);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.White;
            this.label18.Location = new System.Drawing.Point(147, 187);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(14, 15);
            this.label18.TabIndex = 25;
            this.label18.Text = "S";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.White;
            this.label19.Location = new System.Drawing.Point(75, 187);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(14, 15);
            this.label19.TabIndex = 24;
            this.label19.Text = "A";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.White;
            this.label20.Location = new System.Drawing.Point(109, 187);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(14, 15);
            this.label20.TabIndex = 23;
            this.label20.Text = "Z";
            // 
            // O
            // 
            this.O.AutoSize = true;
            this.O.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.O.ForeColor = System.Drawing.Color.White;
            this.O.Location = new System.Drawing.Point(225, 187);
            this.O.Name = "O";
            this.O.Size = new System.Drawing.Size(14, 15);
            this.O.TabIndex = 22;
            this.O.Text = "O";
            // 
            // T
            // 
            this.T.AutoSize = true;
            this.T.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.T.ForeColor = System.Drawing.Color.White;
            this.T.Location = new System.Drawing.Point(186, 187);
            this.T.Name = "T";
            this.T.Size = new System.Drawing.Size(14, 15);
            this.T.TabIndex = 21;
            this.T.Text = "T";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.ForeColor = System.Drawing.Color.White;
            this.label23.Location = new System.Drawing.Point(40, 187);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(14, 15);
            this.label23.TabIndex = 20;
            this.label23.Text = "P";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.Color.White;
            this.label22.Location = new System.Drawing.Point(7, 187);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(14, 15);
            this.label22.TabIndex = 18;
            this.label22.Text = "C";
            // 
            // EIP
            // 
            this.EIP.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EIP.ForeColor = System.Drawing.Color.White;
            this.EIP.Location = new System.Drawing.Point(41, 167);
            this.EIP.Name = "EIP";
            this.EIP.Size = new System.Drawing.Size(65, 13);
            this.EIP.TabIndex = 26;
            this.EIP.Text = "00000000";
            this.EIP.MouseClick += new System.Windows.Forms.MouseEventHandler(this.registerLabel_MouseClick);
            // 
            // EIPInfo
            // 
            this.EIPInfo.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EIPInfo.ForeColor = System.Drawing.Color.White;
            this.EIPInfo.Location = new System.Drawing.Point(115, 167);
            this.EIPInfo.Name = "EIPInfo";
            this.EIPInfo.Size = new System.Drawing.Size(150, 12);
            this.EIPInfo.TabIndex = 35;
            this.EIPInfo.MouseClick += new System.Windows.Forms.MouseEventHandler(this.registerInfos_MouseClick);
            // 
            // ESPInfo
            // 
            this.ESPInfo.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ESPInfo.ForeColor = System.Drawing.Color.White;
            this.ESPInfo.Location = new System.Drawing.Point(115, 103);
            this.ESPInfo.Name = "ESPInfo";
            this.ESPInfo.Size = new System.Drawing.Size(150, 12);
            this.ESPInfo.TabIndex = 34;
            this.ESPInfo.MouseClick += new System.Windows.Forms.MouseEventHandler(this.registerInfos_MouseClick);
            // 
            // EDXInfo
            // 
            this.EDXInfo.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EDXInfo.ForeColor = System.Drawing.Color.White;
            this.EDXInfo.Location = new System.Drawing.Point(115, 73);
            this.EDXInfo.Name = "EDXInfo";
            this.EDXInfo.Size = new System.Drawing.Size(150, 12);
            this.EDXInfo.TabIndex = 33;
            this.EDXInfo.MouseClick += new System.Windows.Forms.MouseEventHandler(this.registerInfos_MouseClick);
            // 
            // EBXInfo
            // 
            this.EBXInfo.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EBXInfo.ForeColor = System.Drawing.Color.White;
            this.EBXInfo.Location = new System.Drawing.Point(115, 87);
            this.EBXInfo.Name = "EBXInfo";
            this.EBXInfo.Size = new System.Drawing.Size(150, 12);
            this.EBXInfo.TabIndex = 32;
            this.EBXInfo.MouseClick += new System.Windows.Forms.MouseEventHandler(this.registerInfos_MouseClick);
            // 
            // ESIInfo
            // 
            this.ESIInfo.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ESIInfo.ForeColor = System.Drawing.Color.White;
            this.ESIInfo.Location = new System.Drawing.Point(115, 133);
            this.ESIInfo.Name = "ESIInfo";
            this.ESIInfo.Size = new System.Drawing.Size(150, 12);
            this.ESIInfo.TabIndex = 31;
            this.ESIInfo.MouseClick += new System.Windows.Forms.MouseEventHandler(this.registerInfos_MouseClick);
            // 
            // EBPInfo
            // 
            this.EBPInfo.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EBPInfo.ForeColor = System.Drawing.Color.White;
            this.EBPInfo.Location = new System.Drawing.Point(115, 118);
            this.EBPInfo.Name = "EBPInfo";
            this.EBPInfo.Size = new System.Drawing.Size(150, 12);
            this.EBPInfo.TabIndex = 30;
            this.EBPInfo.MouseClick += new System.Windows.Forms.MouseEventHandler(this.registerInfos_MouseClick);
            // 
            // ECXInfo
            // 
            this.ECXInfo.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ECXInfo.ForeColor = System.Drawing.Color.White;
            this.ECXInfo.Location = new System.Drawing.Point(115, 58);
            this.ECXInfo.Name = "ECXInfo";
            this.ECXInfo.Size = new System.Drawing.Size(150, 12);
            this.ECXInfo.TabIndex = 29;
            this.ECXInfo.MouseClick += new System.Windows.Forms.MouseEventHandler(this.registerInfos_MouseClick);
            // 
            // EDIInfo
            // 
            this.EDIInfo.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EDIInfo.ForeColor = System.Drawing.Color.White;
            this.EDIInfo.Location = new System.Drawing.Point(115, 148);
            this.EDIInfo.Name = "EDIInfo";
            this.EDIInfo.Size = new System.Drawing.Size(150, 12);
            this.EDIInfo.TabIndex = 28;
            this.EDIInfo.MouseClick += new System.Windows.Forms.MouseEventHandler(this.registerInfos_MouseClick);
            // 
            // EAXInfo
            // 
            this.EAXInfo.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EAXInfo.ForeColor = System.Drawing.Color.White;
            this.EAXInfo.Location = new System.Drawing.Point(115, 43);
            this.EAXInfo.Name = "EAXInfo";
            this.EAXInfo.Size = new System.Drawing.Size(150, 12);
            this.EAXInfo.TabIndex = 27;
            this.EAXInfo.MouseClick += new System.Windows.Forms.MouseEventHandler(this.registerInfos_MouseClick);
            // 
            // S
            // 
            this.S.AutoSize = true;
            this.S.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.S.ForeColor = System.Drawing.Color.White;
            this.S.Location = new System.Drawing.Point(158, 187);
            this.S.Name = "S";
            this.S.Size = new System.Drawing.Size(14, 15);
            this.S.TabIndex = 42;
            this.S.Text = "0";
            // 
            // A
            // 
            this.A.AutoSize = true;
            this.A.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.A.ForeColor = System.Drawing.Color.White;
            this.A.Location = new System.Drawing.Point(86, 187);
            this.A.Name = "A";
            this.A.Size = new System.Drawing.Size(14, 15);
            this.A.TabIndex = 41;
            this.A.Text = "0";
            // 
            // Z
            // 
            this.Z.AutoSize = true;
            this.Z.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Z.ForeColor = System.Drawing.Color.White;
            this.Z.Location = new System.Drawing.Point(120, 187);
            this.Z.Name = "Z";
            this.Z.Size = new System.Drawing.Size(14, 15);
            this.Z.TabIndex = 40;
            this.Z.Text = "0";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(237, 187);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(14, 15);
            this.label13.TabIndex = 39;
            this.label13.Text = "0";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(197, 187);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(14, 15);
            this.label14.TabIndex = 38;
            this.label14.Text = "0";
            // 
            // P
            // 
            this.P.AutoSize = true;
            this.P.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.P.ForeColor = System.Drawing.Color.White;
            this.P.Location = new System.Drawing.Point(50, 187);
            this.P.Name = "P";
            this.P.Size = new System.Drawing.Size(14, 15);
            this.P.TabIndex = 37;
            this.P.Text = "0";
            // 
            // C
            // 
            this.C.AutoSize = true;
            this.C.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.C.ForeColor = System.Drawing.Color.White;
            this.C.Location = new System.Drawing.Point(19, 187);
            this.C.Name = "C";
            this.C.Size = new System.Drawing.Size(14, 15);
            this.C.TabIndex = 36;
            this.C.Text = "0";
            // 
            // stackList
            // 
            this.stackList.Alignment = System.Windows.Forms.ListViewAlignment.Left;
            this.stackList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.stackList.BackColor = System.Drawing.Color.Black;
            this.stackList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Address,
            this.Hexdump,
            this.ASCII,
            this.Comment,
            this.CPIndex});
            this.stackList.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stackList.ForeColor = System.Drawing.Color.White;
            this.stackList.FullRowSelect = true;
            this.stackList.Location = new System.Drawing.Point(0, 370);
            this.stackList.Name = "stackList";
            this.stackList.Size = new System.Drawing.Size(320, 379);
            this.stackList.TabIndex = 43;
            this.stackList.UseCompatibleStateImageBehavior = false;
            this.stackList.View = System.Windows.Forms.View.Details;
            this.stackList.VirtualListSize = 50;
            this.stackList.MouseClick += new System.Windows.Forms.MouseEventHandler(this.stackList_MouseClick);
            this.stackList.MouseDown += new System.Windows.Forms.MouseEventHandler(this.stackList_MouseDown);
            this.stackList.MouseEnter += new System.EventHandler(this.stackList_MouseEnter);
            this.stackList.MouseLeave += new System.EventHandler(this.stackList_MouseLeave);
            this.stackList.MouseMove += new System.Windows.Forms.MouseEventHandler(this.stackList_MouseMove);
            this.stackList.MouseUp += new System.Windows.Forms.MouseEventHandler(this.stackList_MouseUp);
            // 
            // Address
            // 
            this.Address.Text = "Address";
            this.Address.Width = 85;
            // 
            // Hexdump
            // 
            this.Hexdump.Text = "Hexdump";
            this.Hexdump.Width = 71;
            // 
            // ASCII
            // 
            this.ASCII.Text = "ASCII";
            this.ASCII.Width = 47;
            // 
            // Comment
            // 
            this.Comment.Text = "Comment";
            this.Comment.Width = 95;
            // 
            // CPIndex
            // 
            this.CPIndex.Text = "CP Index";
            this.CPIndex.Width = 0;
            // 
            // EAX
            // 
            this.EAX.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EAX.ForeColor = System.Drawing.Color.White;
            this.EAX.Location = new System.Drawing.Point(41, 43);
            this.EAX.Name = "EAX";
            this.EAX.Size = new System.Drawing.Size(65, 13);
            this.EAX.TabIndex = 10;
            this.EAX.Text = "00000000";
            this.EAX.MouseClick += new System.Windows.Forms.MouseEventHandler(this.registerLabel_MouseClick);
            // 
            // stepNumber
            // 
            this.stepNumber.AutoSize = true;
            this.stepNumber.ForeColor = System.Drawing.Color.White;
            this.stepNumber.Location = new System.Drawing.Point(6, 4);
            this.stepNumber.Name = "stepNumber";
            this.stepNumber.Size = new System.Drawing.Size(41, 13);
            this.stepNumber.TabIndex = 45;
            this.stepNumber.Text = "Step 1:";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.ForeColor = System.Drawing.Color.White;
            this.label24.Location = new System.Drawing.Point(7, 24);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(54, 13);
            this.label24.TabIndex = 46;
            this.label24.Text = "Registers:";
            // 
            // stackLabel
            // 
            this.stackLabel.AutoSize = true;
            this.stackLabel.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stackLabel.ForeColor = System.Drawing.Color.White;
            this.stackLabel.Location = new System.Drawing.Point(7, 351);
            this.stackLabel.Name = "stackLabel";
            this.stackLabel.Size = new System.Drawing.Size(56, 16);
            this.stackLabel.TabIndex = 47;
            this.stackLabel.Text = "Stack:";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.ForeColor = System.Drawing.Color.White;
            this.label28.Location = new System.Drawing.Point(7, 204);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(104, 16);
            this.label28.TabIndex = 48;
            this.label28.Text = "Disassembly:";
            // 
            // Disassembly
            // 
            this.Disassembly.BackColor = System.Drawing.Color.Black;
            this.Disassembly.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Disassembly.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Disassembly.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.Disassembly.Location = new System.Drawing.Point(9, 208);
            this.Disassembly.Margin = new System.Windows.Forms.Padding(0);
            this.Disassembly.Name = "Disassembly";
            this.Disassembly.ReadOnly = true;
            this.Disassembly.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.Disassembly.Size = new System.Drawing.Size(303, 137);
            this.Disassembly.TabIndex = 50;
            this.Disassembly.Text = "";
            this.Disassembly.WordWrap = false;
            // 
            // stackMenu
            // 
            this.stackMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editValueMenu,
            this.replaceWithGadgetMenu});
            this.stackMenu.Name = "MemoryMenu";
            this.stackMenu.Size = new System.Drawing.Size(173, 48);
            // 
            // editValueMenu
            // 
            this.editValueMenu.Name = "editValueMenu";
            this.editValueMenu.Size = new System.Drawing.Size(172, 22);
            this.editValueMenu.Text = "Manually edit value";
            this.editValueMenu.Click += new System.EventHandler(this.editStackValueMenu_Click);
            // 
            // replaceWithGadgetMenu
            // 
            this.replaceWithGadgetMenu.Name = "replaceWithGadgetMenu";
            this.replaceWithGadgetMenu.Size = new System.Drawing.Size(172, 22);
            this.replaceWithGadgetMenu.Text = "Replace with gadget";
            this.replaceWithGadgetMenu.Click += new System.EventHandler(this.replaceWithGadgetMenu_Click);
            // 
            // lineLabel
            // 
            this.lineLabel.BackColor = System.Drawing.Color.White;
            this.lineLabel.Location = new System.Drawing.Point(0, 0);
            this.lineLabel.Name = "lineLabel";
            this.lineLabel.Size = new System.Drawing.Size(1, 768);
            this.lineLabel.TabIndex = 51;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Dock = System.Windows.Forms.DockStyle.Right;
            this.label1.Location = new System.Drawing.Point(320, 0);
            this.label1.MinimumSize = new System.Drawing.Size(1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1, 750);
            this.label1.TabIndex = 52;
            // 
            // ExecutionStepForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(321, 750);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lineLabel);
            this.Controls.Add(this.label28);
            this.Controls.Add(this.Disassembly);
            this.Controls.Add(this.stackLabel);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.stepNumber);
            this.Controls.Add(this.stackList);
            this.Controls.Add(this.S);
            this.Controls.Add(this.A);
            this.Controls.Add(this.Z);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.P);
            this.Controls.Add(this.C);
            this.Controls.Add(this.EIPInfo);
            this.Controls.Add(this.ESPInfo);
            this.Controls.Add(this.EDXInfo);
            this.Controls.Add(this.EBXInfo);
            this.Controls.Add(this.ESIInfo);
            this.Controls.Add(this.EBPInfo);
            this.Controls.Add(this.ECXInfo);
            this.Controls.Add(this.EDIInfo);
            this.Controls.Add(this.EAXInfo);
            this.Controls.Add(this.EIP);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.O);
            this.Controls.Add(this.T);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.ESP);
            this.Controls.Add(this.EDX);
            this.Controls.Add(this.EBX);
            this.Controls.Add(this.ESI);
            this.Controls.Add(this.EBP);
            this.Controls.Add(this.ECX);
            this.Controls.Add(this.EDI);
            this.Controls.Add(this.EAX);
            this.Controls.Add(this.ESPLabel);
            this.Controls.Add(this.EIPLabel);
            this.Controls.Add(this.EDXLabel);
            this.Controls.Add(this.EBXLabel);
            this.Controls.Add(this.ESILabel);
            this.Controls.Add(this.EBPLabel);
            this.Controls.Add(this.ECXLabel);
            this.Controls.Add(this.EDILabel);
            this.Controls.Add(this.EAXLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(256, 648);
            this.Name = "ExecutionStepForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Simulation";
            this.Resize += new System.EventHandler(this.ExecutionStepForm_Resize);
            this.stackMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label EAXLabel;
        private System.Windows.Forms.Label EDILabel;
        private System.Windows.Forms.Label ECXLabel;
        private System.Windows.Forms.Label EBPLabel;
        private System.Windows.Forms.Label ESILabel;
        private System.Windows.Forms.Label EBXLabel;
        private System.Windows.Forms.Label EDXLabel;
        private System.Windows.Forms.Label EIPLabel;
        private System.Windows.Forms.Label ESPLabel;
        private System.Windows.Forms.Label ESP;
        private System.Windows.Forms.Label EDX;
        private System.Windows.Forms.Label EBX;
        private System.Windows.Forms.Label ESI;
        private System.Windows.Forms.Label EBP;
        private System.Windows.Forms.Label ECX;
        private System.Windows.Forms.Label EDI;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label O;
        private System.Windows.Forms.Label T;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label EIP;
        private System.Windows.Forms.Label EIPInfo;
        private System.Windows.Forms.Label ESPInfo;
        private System.Windows.Forms.Label EDXInfo;
        private System.Windows.Forms.Label EBXInfo;
        private System.Windows.Forms.Label ESIInfo;
        private System.Windows.Forms.Label EBPInfo;
        private System.Windows.Forms.Label ECXInfo;
        private System.Windows.Forms.Label EDIInfo;
        private System.Windows.Forms.Label EAXInfo;
        private System.Windows.Forms.Label S;
        private System.Windows.Forms.Label A;
        private System.Windows.Forms.Label Z;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label P;
        private System.Windows.Forms.Label C;
        public System.Windows.Forms.ListView stackList;
        private System.Windows.Forms.ColumnHeader Address;
        private System.Windows.Forms.ColumnHeader Hexdump;
        private System.Windows.Forms.ColumnHeader ASCII;
        private System.Windows.Forms.Label EAX;
        private System.Windows.Forms.Label stepNumber;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label stackLabel;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.RichTextBox Disassembly;
        private System.Windows.Forms.ColumnHeader Comment;
        private System.Windows.Forms.ContextMenuStrip stackMenu;
        private System.Windows.Forms.ToolStripMenuItem editValueMenu;
        private System.Windows.Forms.ToolStripMenuItem replaceWithGadgetMenu;
        private System.Windows.Forms.ColumnHeader CPIndex;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Label lineLabel;
        private System.Windows.Forms.Label label1;
        private System.ComponentModel.BackgroundWorker stackWorker;

    }
}