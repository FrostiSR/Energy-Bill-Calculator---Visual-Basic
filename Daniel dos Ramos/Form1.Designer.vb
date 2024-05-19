<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Txtbegin = New System.Windows.Forms.TextBox()
        Me.lblBeginstand = New System.Windows.Forms.Label()
        Me.lblEindstand = New System.Windows.Forms.Label()
        Me.Txteind = New System.Windows.Forms.TextBox()
        Me.lblFase = New System.Windows.Forms.Label()
        Me.lblFaseB = New System.Windows.Forms.Label()
        Me.btnbereken = New System.Windows.Forms.Button()
        Me.btnInformation = New System.Windows.Forms.Button()
        Me.Labelverbruikers = New System.Windows.Forms.Label()
        Me.LabelRekening = New System.Windows.Forms.Label()
        Me.LabelTotaal = New System.Windows.Forms.Label()
        Me.ComboBoxFase = New System.Windows.Forms.ComboBox()
        Me.lblVerbruik = New System.Windows.Forms.Label()
        Me.lblrekening = New System.Windows.Forms.Label()
        Me.lblTotaal = New System.Windows.Forms.Label()
        Me.LabelFasebedrag = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnclear = New System.Windows.Forms.Button()
        Me.btnsluiten = New System.Windows.Forms.Button()
        Me.MonthCalendar1 = New System.Windows.Forms.MonthCalendar()
        Me.LabelTime = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Txtbegin
        '
        Me.Txtbegin.BackColor = System.Drawing.Color.Orchid
        Me.Txtbegin.Font = New System.Drawing.Font("Rockwell", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txtbegin.Location = New System.Drawing.Point(187, 168)
        Me.Txtbegin.Name = "Txtbegin"
        Me.Txtbegin.Size = New System.Drawing.Size(117, 45)
        Me.Txtbegin.TabIndex = 0
        '
        'lblBeginstand
        '
        Me.lblBeginstand.AutoSize = True
        Me.lblBeginstand.BackColor = System.Drawing.Color.Transparent
        Me.lblBeginstand.Font = New System.Drawing.Font("Prototype", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBeginstand.Location = New System.Drawing.Point(12, 174)
        Me.lblBeginstand.Name = "lblBeginstand"
        Me.lblBeginstand.Size = New System.Drawing.Size(169, 35)
        Me.lblBeginstand.TabIndex = 1
        Me.lblBeginstand.Text = "Beginstand"
        '
        'lblEindstand
        '
        Me.lblEindstand.AutoSize = True
        Me.lblEindstand.BackColor = System.Drawing.Color.Transparent
        Me.lblEindstand.Font = New System.Drawing.Font("Prototype", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEindstand.Location = New System.Drawing.Point(362, 174)
        Me.lblEindstand.Name = "lblEindstand"
        Me.lblEindstand.Size = New System.Drawing.Size(151, 35)
        Me.lblEindstand.TabIndex = 3
        Me.lblEindstand.Text = "Eindstand"
        '
        'Txteind
        '
        Me.Txteind.BackColor = System.Drawing.Color.Orchid
        Me.Txteind.Font = New System.Drawing.Font("Rockwell", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txteind.Location = New System.Drawing.Point(519, 168)
        Me.Txteind.Name = "Txteind"
        Me.Txteind.Size = New System.Drawing.Size(117, 45)
        Me.Txteind.TabIndex = 2
        '
        'lblFase
        '
        Me.lblFase.AutoSize = True
        Me.lblFase.BackColor = System.Drawing.Color.Transparent
        Me.lblFase.Font = New System.Drawing.Font("Prototype", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFase.Location = New System.Drawing.Point(236, 221)
        Me.lblFase.Name = "lblFase"
        Me.lblFase.Size = New System.Drawing.Size(81, 35)
        Me.lblFase.TabIndex = 5
        Me.lblFase.Text = "Fase"
        '
        'lblFaseB
        '
        Me.lblFaseB.AutoSize = True
        Me.lblFaseB.BackColor = System.Drawing.Color.Transparent
        Me.lblFaseB.Font = New System.Drawing.Font("Prototype", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFaseB.Location = New System.Drawing.Point(8, 383)
        Me.lblFaseB.Name = "lblFaseB"
        Me.lblFaseB.Size = New System.Drawing.Size(185, 35)
        Me.lblFaseB.TabIndex = 12
        Me.lblFaseB.Text = "Fase bedrag"
        '
        'btnbereken
        '
        Me.btnbereken.BackColor = System.Drawing.Color.Gold
        Me.btnbereken.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnbereken.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnbereken.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnbereken.Font = New System.Drawing.Font("Prototype", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnbereken.ForeColor = System.Drawing.Color.DarkViolet
        Me.btnbereken.Location = New System.Drawing.Point(199, 489)
        Me.btnbereken.Name = "btnbereken"
        Me.btnbereken.Size = New System.Drawing.Size(254, 57)
        Me.btnbereken.TabIndex = 15
        Me.btnbereken.Text = "Bereken"
        Me.btnbereken.UseVisualStyleBackColor = False
        '
        'btnInformation
        '
        Me.btnInformation.BackColor = System.Drawing.Color.Transparent
        Me.btnInformation.BackgroundImage = Global.Daniel_dos_Ramos.My.Resources.Resources.information_icon_51087
        Me.btnInformation.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnInformation.FlatAppearance.BorderSize = 0
        Me.btnInformation.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnInformation.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnInformation.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnInformation.Location = New System.Drawing.Point(587, -5)
        Me.btnInformation.Name = "btnInformation"
        Me.btnInformation.Size = New System.Drawing.Size(64, 64)
        Me.btnInformation.TabIndex = 16
        Me.btnInformation.UseVisualStyleBackColor = False
        '
        'Labelverbruikers
        '
        Me.Labelverbruikers.BackColor = System.Drawing.Color.Orchid
        Me.Labelverbruikers.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Labelverbruikers.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.Labelverbruikers.Font = New System.Drawing.Font("Rockwell", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Labelverbruikers.ForeColor = System.Drawing.Color.Blue
        Me.Labelverbruikers.Location = New System.Drawing.Point(199, 272)
        Me.Labelverbruikers.Name = "Labelverbruikers"
        Me.Labelverbruikers.Size = New System.Drawing.Size(117, 46)
        Me.Labelverbruikers.TabIndex = 17
        '
        'LabelRekening
        '
        Me.LabelRekening.BackColor = System.Drawing.Color.Orchid
        Me.LabelRekening.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LabelRekening.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.LabelRekening.Font = New System.Drawing.Font("Rockwell", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelRekening.ForeColor = System.Drawing.Color.Blue
        Me.LabelRekening.Location = New System.Drawing.Point(199, 330)
        Me.LabelRekening.Name = "LabelRekening"
        Me.LabelRekening.Size = New System.Drawing.Size(117, 45)
        Me.LabelRekening.TabIndex = 18
        '
        'LabelTotaal
        '
        Me.LabelTotaal.BackColor = System.Drawing.Color.Orchid
        Me.LabelTotaal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LabelTotaal.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.LabelTotaal.Font = New System.Drawing.Font("Rockwell", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelTotaal.ForeColor = System.Drawing.Color.DarkGreen
        Me.LabelTotaal.Location = New System.Drawing.Point(199, 436)
        Me.LabelTotaal.Name = "LabelTotaal"
        Me.LabelTotaal.Size = New System.Drawing.Size(117, 45)
        Me.LabelTotaal.TabIndex = 19
        '
        'ComboBoxFase
        '
        Me.ComboBoxFase.BackColor = System.Drawing.Color.Orchid
        Me.ComboBoxFase.Font = New System.Drawing.Font("Rockwell", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBoxFase.FormattingEnabled = True
        Me.ComboBoxFase.Items.AddRange(New Object() {"1", "2", "3"})
        Me.ComboBoxFase.Location = New System.Drawing.Point(323, 221)
        Me.ComboBoxFase.Name = "ComboBoxFase"
        Me.ComboBoxFase.Size = New System.Drawing.Size(117, 44)
        Me.ComboBoxFase.TabIndex = 20
        '
        'lblVerbruik
        '
        Me.lblVerbruik.AutoSize = True
        Me.lblVerbruik.BackColor = System.Drawing.Color.Transparent
        Me.lblVerbruik.Font = New System.Drawing.Font("Prototype", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVerbruik.Location = New System.Drawing.Point(61, 283)
        Me.lblVerbruik.Name = "lblVerbruik"
        Me.lblVerbruik.Size = New System.Drawing.Size(132, 35)
        Me.lblVerbruik.TabIndex = 8
        Me.lblVerbruik.Text = "Verbruik"
        '
        'lblrekening
        '
        Me.lblrekening.AutoSize = True
        Me.lblrekening.BackColor = System.Drawing.Color.Transparent
        Me.lblrekening.Font = New System.Drawing.Font("Prototype", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblrekening.Location = New System.Drawing.Point(51, 332)
        Me.lblrekening.Name = "lblrekening"
        Me.lblrekening.Size = New System.Drawing.Size(142, 35)
        Me.lblrekening.TabIndex = 10
        Me.lblrekening.Text = "Rekening"
        '
        'lblTotaal
        '
        Me.lblTotaal.AutoSize = True
        Me.lblTotaal.BackColor = System.Drawing.Color.Transparent
        Me.lblTotaal.Font = New System.Drawing.Font("Prototype", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotaal.Location = New System.Drawing.Point(93, 444)
        Me.lblTotaal.Name = "lblTotaal"
        Me.lblTotaal.Size = New System.Drawing.Size(100, 35)
        Me.lblTotaal.TabIndex = 14
        Me.lblTotaal.Text = "Totaal"
        '
        'LabelFasebedrag
        '
        Me.LabelFasebedrag.BackColor = System.Drawing.Color.Orchid
        Me.LabelFasebedrag.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LabelFasebedrag.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.LabelFasebedrag.Font = New System.Drawing.Font("Rockwell", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelFasebedrag.ForeColor = System.Drawing.Color.Blue
        Me.LabelFasebedrag.Location = New System.Drawing.Point(199, 382)
        Me.LabelFasebedrag.Name = "LabelFasebedrag"
        Me.LabelFasebedrag.Size = New System.Drawing.Size(117, 45)
        Me.LabelFasebedrag.TabIndex = 21
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.Daniel_dos_Ramos.My.Resources.Resources.Untitled_1
        Me.PictureBox1.Location = New System.Drawing.Point(153, -30)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(360, 192)
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'btnclear
        '
        Me.btnclear.BackColor = System.Drawing.Color.Fuchsia
        Me.btnclear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnclear.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnclear.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnclear.Font = New System.Drawing.Font("Prototype", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnclear.ForeColor = System.Drawing.Color.Gold
        Me.btnclear.Location = New System.Drawing.Point(459, 489)
        Me.btnclear.Name = "btnclear"
        Me.btnclear.Size = New System.Drawing.Size(177, 57)
        Me.btnclear.TabIndex = 22
        Me.btnclear.Text = "Clear"
        Me.btnclear.UseVisualStyleBackColor = False
        '
        'btnsluiten
        '
        Me.btnsluiten.BackColor = System.Drawing.Color.Fuchsia
        Me.btnsluiten.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnsluiten.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnsluiten.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnsluiten.Font = New System.Drawing.Font("Prototype", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsluiten.ForeColor = System.Drawing.Color.Gold
        Me.btnsluiten.Location = New System.Drawing.Point(16, 489)
        Me.btnsluiten.Name = "btnsluiten"
        Me.btnsluiten.Size = New System.Drawing.Size(177, 57)
        Me.btnsluiten.TabIndex = 23
        Me.btnsluiten.Text = "Sluiten "
        Me.btnsluiten.UseVisualStyleBackColor = False
        '
        'MonthCalendar1
        '
        Me.MonthCalendar1.Location = New System.Drawing.Point(368, 319)
        Me.MonthCalendar1.Name = "MonthCalendar1"
        Me.MonthCalendar1.TabIndex = 24
        '
        'LabelTime
        '
        Me.LabelTime.BackColor = System.Drawing.Color.Transparent
        Me.LabelTime.Font = New System.Drawing.Font("Prototype", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelTime.ForeColor = System.Drawing.Color.Indigo
        Me.LabelTime.Location = New System.Drawing.Point(385, 277)
        Me.LabelTime.Name = "LabelTime"
        Me.LabelTime.Size = New System.Drawing.Size(200, 38)
        Me.LabelTime.TabIndex = 25
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Daniel_dos_Ramos.My.Resources.Resources.polygonal_background_in_purple_and_yellow_1095_285
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(648, 558)
        Me.Controls.Add(Me.LabelTime)
        Me.Controls.Add(Me.MonthCalendar1)
        Me.Controls.Add(Me.btnsluiten)
        Me.Controls.Add(Me.btnclear)
        Me.Controls.Add(Me.LabelFasebedrag)
        Me.Controls.Add(Me.ComboBoxFase)
        Me.Controls.Add(Me.LabelTotaal)
        Me.Controls.Add(Me.LabelRekening)
        Me.Controls.Add(Me.Labelverbruikers)
        Me.Controls.Add(Me.btnInformation)
        Me.Controls.Add(Me.btnbereken)
        Me.Controls.Add(Me.lblTotaal)
        Me.Controls.Add(Me.lblFaseB)
        Me.Controls.Add(Me.lblrekening)
        Me.Controls.Add(Me.lblVerbruik)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lblFase)
        Me.Controls.Add(Me.lblEindstand)
        Me.Controls.Add(Me.Txteind)
        Me.Controls.Add(Me.lblBeginstand)
        Me.Controls.Add(Me.Txtbegin)
        Me.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Daniel dos Ramos"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Txtbegin As TextBox
    Friend WithEvents lblBeginstand As Label
    Friend WithEvents lblEindstand As Label
    Friend WithEvents Txteind As TextBox
    Friend WithEvents lblFase As Label
    Friend WithEvents lblFaseB As Label
    Friend WithEvents btnbereken As Button
    Friend WithEvents btnInformation As Button
    Friend WithEvents Labelverbruikers As Label
    Friend WithEvents LabelRekening As Label
    Friend WithEvents LabelTotaal As Label
    Friend WithEvents ComboBoxFase As ComboBox
    Friend WithEvents lblVerbruik As Label
    Friend WithEvents lblrekening As Label
    Friend WithEvents lblTotaal As Label
    Friend WithEvents LabelFasebedrag As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnclear As Button
    Friend WithEvents btnsluiten As Button
    Friend WithEvents MonthCalendar1 As MonthCalendar
    Friend WithEvents LabelTime As Label
    Friend WithEvents Timer1 As Timer
End Class
