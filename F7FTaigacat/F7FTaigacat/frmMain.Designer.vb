<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.gbMainConfig = New System.Windows.Forms.GroupBox()
        Me.cmdStopRecording = New System.Windows.Forms.Button()
        Me.cmdStartRecording = New System.Windows.Forms.Button()
        Me.cmdPickSaveLocation = New System.Windows.Forms.Button()
        Me.txtSaveLocation = New System.Windows.Forms.TextBox()
        Me.lblSaveFileLocation = New System.Windows.Forms.Label()
        Me.chkCam3FTEnable = New System.Windows.Forms.CheckBox()
        Me.chkCam2FTEnable = New System.Windows.Forms.CheckBox()
        Me.chkCam1FTEnable = New System.Windows.Forms.CheckBox()
        Me.chkCam3FPSEnable = New System.Windows.Forms.CheckBox()
        Me.chkCam2FPSEnable = New System.Windows.Forms.CheckBox()
        Me.chkCam1FPSEnable = New System.Windows.Forms.CheckBox()
        Me.chkCam3EnableAnalyze = New System.Windows.Forms.CheckBox()
        Me.chkCam2EnableAnalyze = New System.Windows.Forms.CheckBox()
        Me.chkCam1EnableAnalyze = New System.Windows.Forms.CheckBox()
        Me.cmdCam3Color = New System.Windows.Forms.Button()
        Me.cmdCam2Color = New System.Windows.Forms.Button()
        Me.cmdCam1Color = New System.Windows.Forms.Button()
        Me.pcCam3Color = New System.Windows.Forms.PictureBox()
        Me.pbCam2Color = New System.Windows.Forms.PictureBox()
        Me.pbCam1Color = New System.Windows.Forms.PictureBox()
        Me.nudCam3MaxFPS = New System.Windows.Forms.NumericUpDown()
        Me.nudCam2MaxFPS = New System.Windows.Forms.NumericUpDown()
        Me.nudCam1MaxFPS = New System.Windows.Forms.NumericUpDown()
        Me.lblCam3MaxFPS = New System.Windows.Forms.Label()
        Me.lblCam2MaxFPS = New System.Windows.Forms.Label()
        Me.lblCam1MaxFPS = New System.Windows.Forms.Label()
        Me.txtCam3Text = New System.Windows.Forms.TextBox()
        Me.txtCam2Text = New System.Windows.Forms.TextBox()
        Me.txtCam1Text = New System.Windows.Forms.TextBox()
        Me.lblCam3Text = New System.Windows.Forms.Label()
        Me.lblCam2Text = New System.Windows.Forms.Label()
        Me.lblCam1Text = New System.Windows.Forms.Label()
        Me.cbVirCam3 = New System.Windows.Forms.ComboBox()
        Me.cbVirCam2 = New System.Windows.Forms.ComboBox()
        Me.lblVirtualCamSelect3 = New System.Windows.Forms.Label()
        Me.lblVirtualCamSelect2 = New System.Windows.Forms.Label()
        Me.cbVirCam1 = New System.Windows.Forms.ComboBox()
        Me.lblVirtualCamSelect1 = New System.Windows.Forms.Label()
        Me.gbRenderZone = New System.Windows.Forms.GroupBox()
        Me.pbRender = New System.Windows.Forms.PictureBox()
        Me.gbMainConfig.SuspendLayout()
        CType(Me.pcCam3Color, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbCam2Color, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbCam1Color, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudCam3MaxFPS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudCam2MaxFPS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudCam1MaxFPS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbRenderZone.SuspendLayout()
        CType(Me.pbRender, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gbMainConfig
        '
        Me.gbMainConfig.Controls.Add(Me.cmdStopRecording)
        Me.gbMainConfig.Controls.Add(Me.cmdStartRecording)
        Me.gbMainConfig.Controls.Add(Me.cmdPickSaveLocation)
        Me.gbMainConfig.Controls.Add(Me.txtSaveLocation)
        Me.gbMainConfig.Controls.Add(Me.lblSaveFileLocation)
        Me.gbMainConfig.Controls.Add(Me.chkCam3FTEnable)
        Me.gbMainConfig.Controls.Add(Me.chkCam2FTEnable)
        Me.gbMainConfig.Controls.Add(Me.chkCam1FTEnable)
        Me.gbMainConfig.Controls.Add(Me.chkCam3FPSEnable)
        Me.gbMainConfig.Controls.Add(Me.chkCam2FPSEnable)
        Me.gbMainConfig.Controls.Add(Me.chkCam1FPSEnable)
        Me.gbMainConfig.Controls.Add(Me.chkCam3EnableAnalyze)
        Me.gbMainConfig.Controls.Add(Me.chkCam2EnableAnalyze)
        Me.gbMainConfig.Controls.Add(Me.chkCam1EnableAnalyze)
        Me.gbMainConfig.Controls.Add(Me.cmdCam3Color)
        Me.gbMainConfig.Controls.Add(Me.cmdCam2Color)
        Me.gbMainConfig.Controls.Add(Me.cmdCam1Color)
        Me.gbMainConfig.Controls.Add(Me.pcCam3Color)
        Me.gbMainConfig.Controls.Add(Me.pbCam2Color)
        Me.gbMainConfig.Controls.Add(Me.pbCam1Color)
        Me.gbMainConfig.Controls.Add(Me.nudCam3MaxFPS)
        Me.gbMainConfig.Controls.Add(Me.nudCam2MaxFPS)
        Me.gbMainConfig.Controls.Add(Me.nudCam1MaxFPS)
        Me.gbMainConfig.Controls.Add(Me.lblCam3MaxFPS)
        Me.gbMainConfig.Controls.Add(Me.lblCam2MaxFPS)
        Me.gbMainConfig.Controls.Add(Me.lblCam1MaxFPS)
        Me.gbMainConfig.Controls.Add(Me.txtCam3Text)
        Me.gbMainConfig.Controls.Add(Me.txtCam2Text)
        Me.gbMainConfig.Controls.Add(Me.txtCam1Text)
        Me.gbMainConfig.Controls.Add(Me.lblCam3Text)
        Me.gbMainConfig.Controls.Add(Me.lblCam2Text)
        Me.gbMainConfig.Controls.Add(Me.lblCam1Text)
        Me.gbMainConfig.Controls.Add(Me.cbVirCam3)
        Me.gbMainConfig.Controls.Add(Me.cbVirCam2)
        Me.gbMainConfig.Controls.Add(Me.lblVirtualCamSelect3)
        Me.gbMainConfig.Controls.Add(Me.lblVirtualCamSelect2)
        Me.gbMainConfig.Controls.Add(Me.cbVirCam1)
        Me.gbMainConfig.Controls.Add(Me.lblVirtualCamSelect1)
        Me.gbMainConfig.Location = New System.Drawing.Point(12, 12)
        Me.gbMainConfig.Name = "gbMainConfig"
        Me.gbMainConfig.Size = New System.Drawing.Size(2070, 314)
        Me.gbMainConfig.TabIndex = 0
        Me.gbMainConfig.TabStop = False
        Me.gbMainConfig.Text = "Analysis Configuration"
        '
        'cmdStopRecording
        '
        Me.cmdStopRecording.Location = New System.Drawing.Point(102, 285)
        Me.cmdStopRecording.Name = "cmdStopRecording"
        Me.cmdStopRecording.Size = New System.Drawing.Size(75, 23)
        Me.cmdStopRecording.TabIndex = 37
        Me.cmdStopRecording.Text = "Stop"
        Me.cmdStopRecording.UseVisualStyleBackColor = True
        '
        'cmdStartRecording
        '
        Me.cmdStartRecording.Location = New System.Drawing.Point(21, 285)
        Me.cmdStartRecording.Name = "cmdStartRecording"
        Me.cmdStartRecording.Size = New System.Drawing.Size(75, 23)
        Me.cmdStartRecording.TabIndex = 36
        Me.cmdStartRecording.Text = "Start"
        Me.cmdStartRecording.UseVisualStyleBackColor = True
        '
        'cmdPickSaveLocation
        '
        Me.cmdPickSaveLocation.Location = New System.Drawing.Point(391, 259)
        Me.cmdPickSaveLocation.Name = "cmdPickSaveLocation"
        Me.cmdPickSaveLocation.Size = New System.Drawing.Size(35, 22)
        Me.cmdPickSaveLocation.TabIndex = 35
        Me.cmdPickSaveLocation.Text = "..."
        Me.cmdPickSaveLocation.UseVisualStyleBackColor = True
        '
        'txtSaveLocation
        '
        Me.txtSaveLocation.Location = New System.Drawing.Point(21, 260)
        Me.txtSaveLocation.Name = "txtSaveLocation"
        Me.txtSaveLocation.Size = New System.Drawing.Size(359, 20)
        Me.txtSaveLocation.TabIndex = 34
        '
        'lblSaveFileLocation
        '
        Me.lblSaveFileLocation.AutoSize = True
        Me.lblSaveFileLocation.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSaveFileLocation.Location = New System.Drawing.Point(18, 235)
        Me.lblSaveFileLocation.Name = "lblSaveFileLocation"
        Me.lblSaveFileLocation.Size = New System.Drawing.Size(152, 16)
        Me.lblSaveFileLocation.TabIndex = 33
        Me.lblSaveFileLocation.Text = "Video Save Location"
        '
        'chkCam3FTEnable
        '
        Me.chkCam3FTEnable.AutoSize = True
        Me.chkCam3FTEnable.Location = New System.Drawing.Point(1766, 104)
        Me.chkCam3FTEnable.Name = "chkCam3FTEnable"
        Me.chkCam3FTEnable.Size = New System.Drawing.Size(142, 17)
        Me.chkCam3FTEnable.TabIndex = 32
        Me.chkCam3FTEnable.Text = "Enable Frametime Graph"
        Me.chkCam3FTEnable.UseVisualStyleBackColor = True
        '
        'chkCam2FTEnable
        '
        Me.chkCam2FTEnable.AutoSize = True
        Me.chkCam2FTEnable.Location = New System.Drawing.Point(1045, 104)
        Me.chkCam2FTEnable.Name = "chkCam2FTEnable"
        Me.chkCam2FTEnable.Size = New System.Drawing.Size(142, 17)
        Me.chkCam2FTEnable.TabIndex = 31
        Me.chkCam2FTEnable.Text = "Enable Frametime Graph"
        Me.chkCam2FTEnable.UseVisualStyleBackColor = True
        '
        'chkCam1FTEnable
        '
        Me.chkCam1FTEnable.AutoSize = True
        Me.chkCam1FTEnable.Location = New System.Drawing.Point(324, 104)
        Me.chkCam1FTEnable.Name = "chkCam1FTEnable"
        Me.chkCam1FTEnable.Size = New System.Drawing.Size(142, 17)
        Me.chkCam1FTEnable.TabIndex = 30
        Me.chkCam1FTEnable.Text = "Enable Frametime Graph"
        Me.chkCam1FTEnable.UseVisualStyleBackColor = True
        '
        'chkCam3FPSEnable
        '
        Me.chkCam3FPSEnable.AutoSize = True
        Me.chkCam3FPSEnable.Location = New System.Drawing.Point(1766, 81)
        Me.chkCam3FPSEnable.Name = "chkCam3FPSEnable"
        Me.chkCam3FPSEnable.Size = New System.Drawing.Size(114, 17)
        Me.chkCam3FPSEnable.TabIndex = 29
        Me.chkCam3FPSEnable.Text = "Enable FPS Graph"
        Me.chkCam3FPSEnable.UseVisualStyleBackColor = True
        '
        'chkCam2FPSEnable
        '
        Me.chkCam2FPSEnable.AutoSize = True
        Me.chkCam2FPSEnable.Location = New System.Drawing.Point(1045, 81)
        Me.chkCam2FPSEnable.Name = "chkCam2FPSEnable"
        Me.chkCam2FPSEnable.Size = New System.Drawing.Size(114, 17)
        Me.chkCam2FPSEnable.TabIndex = 28
        Me.chkCam2FPSEnable.Text = "Enable FPS Graph"
        Me.chkCam2FPSEnable.UseVisualStyleBackColor = True
        '
        'chkCam1FPSEnable
        '
        Me.chkCam1FPSEnable.AutoSize = True
        Me.chkCam1FPSEnable.Location = New System.Drawing.Point(324, 81)
        Me.chkCam1FPSEnable.Name = "chkCam1FPSEnable"
        Me.chkCam1FPSEnable.Size = New System.Drawing.Size(114, 17)
        Me.chkCam1FPSEnable.TabIndex = 27
        Me.chkCam1FPSEnable.Text = "Enable FPS Graph"
        Me.chkCam1FPSEnable.UseVisualStyleBackColor = True
        '
        'chkCam3EnableAnalyze
        '
        Me.chkCam3EnableAnalyze.AutoSize = True
        Me.chkCam3EnableAnalyze.Location = New System.Drawing.Point(1745, 58)
        Me.chkCam3EnableAnalyze.Name = "chkCam3EnableAnalyze"
        Me.chkCam3EnableAnalyze.Size = New System.Drawing.Size(100, 17)
        Me.chkCam3EnableAnalyze.TabIndex = 26
        Me.chkCam3EnableAnalyze.Text = "Enable Analysis"
        Me.chkCam3EnableAnalyze.UseVisualStyleBackColor = True
        '
        'chkCam2EnableAnalyze
        '
        Me.chkCam2EnableAnalyze.AutoSize = True
        Me.chkCam2EnableAnalyze.Location = New System.Drawing.Point(1024, 58)
        Me.chkCam2EnableAnalyze.Name = "chkCam2EnableAnalyze"
        Me.chkCam2EnableAnalyze.Size = New System.Drawing.Size(100, 17)
        Me.chkCam2EnableAnalyze.TabIndex = 25
        Me.chkCam2EnableAnalyze.Text = "Enable Analysis"
        Me.chkCam2EnableAnalyze.UseVisualStyleBackColor = True
        '
        'chkCam1EnableAnalyze
        '
        Me.chkCam1EnableAnalyze.AutoSize = True
        Me.chkCam1EnableAnalyze.Location = New System.Drawing.Point(303, 58)
        Me.chkCam1EnableAnalyze.Name = "chkCam1EnableAnalyze"
        Me.chkCam1EnableAnalyze.Size = New System.Drawing.Size(100, 17)
        Me.chkCam1EnableAnalyze.TabIndex = 24
        Me.chkCam1EnableAnalyze.Text = "Enable Analysis"
        Me.chkCam1EnableAnalyze.UseVisualStyleBackColor = True
        '
        'cmdCam3Color
        '
        Me.cmdCam3Color.Location = New System.Drawing.Point(1601, 160)
        Me.cmdCam3Color.Name = "cmdCam3Color"
        Me.cmdCam3Color.Size = New System.Drawing.Size(75, 23)
        Me.cmdCam3Color.TabIndex = 23
        Me.cmdCam3Color.Text = "Cam 3 Color"
        Me.cmdCam3Color.UseVisualStyleBackColor = True
        '
        'cmdCam2Color
        '
        Me.cmdCam2Color.Location = New System.Drawing.Point(879, 160)
        Me.cmdCam2Color.Name = "cmdCam2Color"
        Me.cmdCam2Color.Size = New System.Drawing.Size(75, 23)
        Me.cmdCam2Color.TabIndex = 22
        Me.cmdCam2Color.Text = "Cam 2 Color"
        Me.cmdCam2Color.UseVisualStyleBackColor = True
        '
        'cmdCam1Color
        '
        Me.cmdCam1Color.Location = New System.Drawing.Point(159, 160)
        Me.cmdCam1Color.Name = "cmdCam1Color"
        Me.cmdCam1Color.Size = New System.Drawing.Size(75, 23)
        Me.cmdCam1Color.TabIndex = 21
        Me.cmdCam1Color.Text = "Cam 1 Color"
        Me.cmdCam1Color.UseVisualStyleBackColor = True
        '
        'pcCam3Color
        '
        Me.pcCam3Color.Image = CType(resources.GetObject("pcCam3Color.Image"), System.Drawing.Image)
        Me.pcCam3Color.Location = New System.Drawing.Point(1563, 156)
        Me.pcCam3Color.Name = "pcCam3Color"
        Me.pcCam3Color.Size = New System.Drawing.Size(32, 32)
        Me.pcCam3Color.TabIndex = 20
        Me.pcCam3Color.TabStop = False
        '
        'pbCam2Color
        '
        Me.pbCam2Color.Image = CType(resources.GetObject("pbCam2Color.Image"), System.Drawing.Image)
        Me.pbCam2Color.Location = New System.Drawing.Point(841, 156)
        Me.pbCam2Color.Name = "pbCam2Color"
        Me.pbCam2Color.Size = New System.Drawing.Size(32, 32)
        Me.pbCam2Color.TabIndex = 19
        Me.pbCam2Color.TabStop = False
        '
        'pbCam1Color
        '
        Me.pbCam1Color.Image = CType(resources.GetObject("pbCam1Color.Image"), System.Drawing.Image)
        Me.pbCam1Color.Location = New System.Drawing.Point(121, 156)
        Me.pbCam1Color.Name = "pbCam1Color"
        Me.pbCam1Color.Size = New System.Drawing.Size(32, 32)
        Me.pbCam1Color.TabIndex = 18
        Me.pbCam1Color.TabStop = False
        '
        'nudCam3MaxFPS
        '
        Me.nudCam3MaxFPS.Location = New System.Drawing.Point(1463, 163)
        Me.nudCam3MaxFPS.Maximum = New Decimal(New Integer() {120, 0, 0, 0})
        Me.nudCam3MaxFPS.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudCam3MaxFPS.Name = "nudCam3MaxFPS"
        Me.nudCam3MaxFPS.Size = New System.Drawing.Size(80, 20)
        Me.nudCam3MaxFPS.TabIndex = 17
        Me.nudCam3MaxFPS.Value = New Decimal(New Integer() {60, 0, 0, 0})
        '
        'nudCam2MaxFPS
        '
        Me.nudCam2MaxFPS.Location = New System.Drawing.Point(742, 163)
        Me.nudCam2MaxFPS.Maximum = New Decimal(New Integer() {120, 0, 0, 0})
        Me.nudCam2MaxFPS.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudCam2MaxFPS.Name = "nudCam2MaxFPS"
        Me.nudCam2MaxFPS.Size = New System.Drawing.Size(80, 20)
        Me.nudCam2MaxFPS.TabIndex = 16
        Me.nudCam2MaxFPS.Value = New Decimal(New Integer() {60, 0, 0, 0})
        '
        'nudCam1MaxFPS
        '
        Me.nudCam1MaxFPS.Location = New System.Drawing.Point(21, 163)
        Me.nudCam1MaxFPS.Maximum = New Decimal(New Integer() {120, 0, 0, 0})
        Me.nudCam1MaxFPS.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudCam1MaxFPS.Name = "nudCam1MaxFPS"
        Me.nudCam1MaxFPS.Size = New System.Drawing.Size(80, 20)
        Me.nudCam1MaxFPS.TabIndex = 15
        Me.nudCam1MaxFPS.Value = New Decimal(New Integer() {60, 0, 0, 0})
        '
        'lblCam3MaxFPS
        '
        Me.lblCam3MaxFPS.AutoSize = True
        Me.lblCam3MaxFPS.Location = New System.Drawing.Point(1460, 147)
        Me.lblCam3MaxFPS.Name = "lblCam3MaxFPS"
        Me.lblCam3MaxFPS.Size = New System.Drawing.Size(83, 13)
        Me.lblCam3MaxFPS.TabIndex = 14
        Me.lblCam3MaxFPS.Text = "Cam 3 Max FPS"
        '
        'lblCam2MaxFPS
        '
        Me.lblCam2MaxFPS.AutoSize = True
        Me.lblCam2MaxFPS.Location = New System.Drawing.Point(739, 147)
        Me.lblCam2MaxFPS.Name = "lblCam2MaxFPS"
        Me.lblCam2MaxFPS.Size = New System.Drawing.Size(83, 13)
        Me.lblCam2MaxFPS.TabIndex = 13
        Me.lblCam2MaxFPS.Text = "Cam 2 Max FPS"
        '
        'lblCam1MaxFPS
        '
        Me.lblCam1MaxFPS.AutoSize = True
        Me.lblCam1MaxFPS.Location = New System.Drawing.Point(18, 147)
        Me.lblCam1MaxFPS.Name = "lblCam1MaxFPS"
        Me.lblCam1MaxFPS.Size = New System.Drawing.Size(83, 13)
        Me.lblCam1MaxFPS.TabIndex = 12
        Me.lblCam1MaxFPS.Text = "Cam 1 Max FPS"
        '
        'txtCam3Text
        '
        Me.txtCam3Text.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCam3Text.Location = New System.Drawing.Point(1463, 108)
        Me.txtCam3Text.Name = "txtCam3Text"
        Me.txtCam3Text.Size = New System.Drawing.Size(250, 29)
        Me.txtCam3Text.TabIndex = 11
        '
        'txtCam2Text
        '
        Me.txtCam2Text.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCam2Text.Location = New System.Drawing.Point(742, 108)
        Me.txtCam2Text.Name = "txtCam2Text"
        Me.txtCam2Text.Size = New System.Drawing.Size(250, 29)
        Me.txtCam2Text.TabIndex = 10
        '
        'txtCam1Text
        '
        Me.txtCam1Text.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCam1Text.Location = New System.Drawing.Point(21, 108)
        Me.txtCam1Text.Name = "txtCam1Text"
        Me.txtCam1Text.Size = New System.Drawing.Size(250, 29)
        Me.txtCam1Text.TabIndex = 9
        '
        'lblCam3Text
        '
        Me.lblCam3Text.AutoSize = True
        Me.lblCam3Text.Location = New System.Drawing.Point(1460, 92)
        Me.lblCam3Text.Name = "lblCam3Text"
        Me.lblCam3Text.Size = New System.Drawing.Size(61, 13)
        Me.lblCam3Text.TabIndex = 8
        Me.lblCam3Text.Text = "Cam 3 Text"
        '
        'lblCam2Text
        '
        Me.lblCam2Text.AutoSize = True
        Me.lblCam2Text.Location = New System.Drawing.Point(739, 92)
        Me.lblCam2Text.Name = "lblCam2Text"
        Me.lblCam2Text.Size = New System.Drawing.Size(61, 13)
        Me.lblCam2Text.TabIndex = 7
        Me.lblCam2Text.Text = "Cam 2 Text"
        '
        'lblCam1Text
        '
        Me.lblCam1Text.AutoSize = True
        Me.lblCam1Text.Location = New System.Drawing.Point(18, 92)
        Me.lblCam1Text.Name = "lblCam1Text"
        Me.lblCam1Text.Size = New System.Drawing.Size(61, 13)
        Me.lblCam1Text.TabIndex = 6
        Me.lblCam1Text.Text = "Cam 1 Text"
        '
        'cbVirCam3
        '
        Me.cbVirCam3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbVirCam3.FormattingEnabled = True
        Me.cbVirCam3.Items.AddRange(New Object() {"[PLACEHOLDER]", "Game Capture 4K60 Pro MK.2 Video"})
        Me.cbVirCam3.Location = New System.Drawing.Point(1463, 56)
        Me.cbVirCam3.Name = "cbVirCam3"
        Me.cbVirCam3.Size = New System.Drawing.Size(250, 21)
        Me.cbVirCam3.TabIndex = 5
        '
        'cbVirCam2
        '
        Me.cbVirCam2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbVirCam2.FormattingEnabled = True
        Me.cbVirCam2.Items.AddRange(New Object() {"[PLACEHOLDER]", "Game Capture 4K60 Pro MK.2 Video"})
        Me.cbVirCam2.Location = New System.Drawing.Point(742, 56)
        Me.cbVirCam2.Name = "cbVirCam2"
        Me.cbVirCam2.Size = New System.Drawing.Size(250, 21)
        Me.cbVirCam2.TabIndex = 4
        '
        'lblVirtualCamSelect3
        '
        Me.lblVirtualCamSelect3.AutoSize = True
        Me.lblVirtualCamSelect3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVirtualCamSelect3.Location = New System.Drawing.Point(1458, 17)
        Me.lblVirtualCamSelect3.Name = "lblVirtualCamSelect3"
        Me.lblVirtualCamSelect3.Size = New System.Drawing.Size(267, 25)
        Me.lblVirtualCamSelect3.TabIndex = 3
        Me.lblVirtualCamSelect3.Text = "Virtual Camera 3 Selection"
        '
        'lblVirtualCamSelect2
        '
        Me.lblVirtualCamSelect2.AutoSize = True
        Me.lblVirtualCamSelect2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVirtualCamSelect2.Location = New System.Drawing.Point(737, 17)
        Me.lblVirtualCamSelect2.Name = "lblVirtualCamSelect2"
        Me.lblVirtualCamSelect2.Size = New System.Drawing.Size(267, 25)
        Me.lblVirtualCamSelect2.TabIndex = 2
        Me.lblVirtualCamSelect2.Text = "Virtual Camera 2 Selection"
        '
        'cbVirCam1
        '
        Me.cbVirCam1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbVirCam1.FormattingEnabled = True
        Me.cbVirCam1.Items.AddRange(New Object() {"[PLACEHOLDER]", "Game Capture 4K60 Pro MK.2 Video"})
        Me.cbVirCam1.Location = New System.Drawing.Point(21, 56)
        Me.cbVirCam1.Name = "cbVirCam1"
        Me.cbVirCam1.Size = New System.Drawing.Size(250, 21)
        Me.cbVirCam1.TabIndex = 1
        '
        'lblVirtualCamSelect1
        '
        Me.lblVirtualCamSelect1.AutoSize = True
        Me.lblVirtualCamSelect1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVirtualCamSelect1.Location = New System.Drawing.Point(16, 17)
        Me.lblVirtualCamSelect1.Name = "lblVirtualCamSelect1"
        Me.lblVirtualCamSelect1.Size = New System.Drawing.Size(267, 25)
        Me.lblVirtualCamSelect1.TabIndex = 0
        Me.lblVirtualCamSelect1.Text = "Virtual Camera 1 Selection"
        '
        'gbRenderZone
        '
        Me.gbRenderZone.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbRenderZone.Controls.Add(Me.pbRender)
        Me.gbRenderZone.Location = New System.Drawing.Point(12, 332)
        Me.gbRenderZone.Name = "gbRenderZone"
        Me.gbRenderZone.Size = New System.Drawing.Size(2070, 875)
        Me.gbRenderZone.TabIndex = 1
        Me.gbRenderZone.TabStop = False
        Me.gbRenderZone.Text = "Render"
        '
        'pbRender
        '
        Me.pbRender.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pbRender.Image = CType(resources.GetObject("pbRender.Image"), System.Drawing.Image)
        Me.pbRender.Location = New System.Drawing.Point(6, 19)
        Me.pbRender.Name = "pbRender"
        Me.pbRender.Size = New System.Drawing.Size(2058, 850)
        Me.pbRender.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbRender.TabIndex = 0
        Me.pbRender.TabStop = False
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(2094, 1219)
        Me.Controls.Add(Me.gbRenderZone)
        Me.Controls.Add(Me.gbMainConfig)
        Me.Name = "frmMain"
        Me.Text = "Project TaigaCat - Codename/WIP"
        Me.gbMainConfig.ResumeLayout(False)
        Me.gbMainConfig.PerformLayout()
        CType(Me.pcCam3Color, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbCam2Color, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbCam1Color, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudCam3MaxFPS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudCam2MaxFPS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudCam1MaxFPS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbRenderZone.ResumeLayout(False)
        CType(Me.pbRender, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents gbMainConfig As GroupBox
    Friend WithEvents lblVirtualCamSelect1 As Label
    Friend WithEvents cbVirCam1 As ComboBox
    Friend WithEvents lblVirtualCamSelect2 As Label
    Friend WithEvents lblVirtualCamSelect3 As Label
    Friend WithEvents cbVirCam3 As ComboBox
    Friend WithEvents cbVirCam2 As ComboBox
    Friend WithEvents gbRenderZone As GroupBox
    Friend WithEvents lblCam3Text As Label
    Friend WithEvents lblCam2Text As Label
    Friend WithEvents lblCam1Text As Label
    Friend WithEvents txtCam3Text As TextBox
    Friend WithEvents txtCam2Text As TextBox
    Friend WithEvents txtCam1Text As TextBox
    Friend WithEvents lblCam3MaxFPS As Label
    Friend WithEvents lblCam2MaxFPS As Label
    Friend WithEvents lblCam1MaxFPS As Label
    Friend WithEvents nudCam3MaxFPS As NumericUpDown
    Friend WithEvents nudCam2MaxFPS As NumericUpDown
    Friend WithEvents nudCam1MaxFPS As NumericUpDown
    Friend WithEvents pbRender As PictureBox
    Friend WithEvents pbCam1Color As PictureBox
    Friend WithEvents pcCam3Color As PictureBox
    Friend WithEvents pbCam2Color As PictureBox
    Friend WithEvents cmdCam1Color As Button
    Friend WithEvents cmdCam3Color As Button
    Friend WithEvents cmdCam2Color As Button
    Friend WithEvents chkCam3EnableAnalyze As CheckBox
    Friend WithEvents chkCam2EnableAnalyze As CheckBox
    Friend WithEvents chkCam1EnableAnalyze As CheckBox
    Friend WithEvents chkCam3FTEnable As CheckBox
    Friend WithEvents chkCam2FTEnable As CheckBox
    Friend WithEvents chkCam1FTEnable As CheckBox
    Friend WithEvents chkCam3FPSEnable As CheckBox
    Friend WithEvents chkCam2FPSEnable As CheckBox
    Friend WithEvents chkCam1FPSEnable As CheckBox
    Friend WithEvents lblSaveFileLocation As Label
    Friend WithEvents cmdPickSaveLocation As Button
    Friend WithEvents txtSaveLocation As TextBox
    Friend WithEvents cmdStopRecording As Button
    Friend WithEvents cmdStartRecording As Button
End Class
