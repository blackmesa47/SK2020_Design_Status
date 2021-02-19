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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.sSciezka = New System.Windows.Forms.TextBox()
        Me.TextBoxStacja = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.StatisticsBox = New System.Windows.Forms.GroupBox()
        Me.labelInsimCounter = New System.Windows.Forms.Label()
        Me.labelEmailCounter = New System.Windows.Forms.Label()
        Me.labelPPTCounter = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.labelFRGCounter = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.buttonEksportDoCsv = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.errorMessageStationFilter = New System.Windows.Forms.Label()
        Me.s_FiltrStacjiAktywny = New System.Windows.Forms.CheckBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.s_UkryjFreeForDetailing2 = New System.Windows.Forms.CheckBox()
        Me.s_FilterLabel = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.ContextMenuPetla = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.OtwórzFolderToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.sFrgToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.sWfrgToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripTextBox1 = New System.Windows.Forms.ToolStripTextBox()
        Me.sWfrgShowCommentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.StatisticsBox.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.ContextMenuPetla.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(17, 491)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(214, 39)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Start / Odśwież"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(20, 472)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(169, 13)
        Me.ProgressBar1.TabIndex = 1
        '
        'sSciezka
        '
        Me.sSciezka.Location = New System.Drawing.Point(6, 32)
        Me.sSciezka.Name = "sSciezka"
        Me.sSciezka.Size = New System.Drawing.Size(199, 20)
        Me.sSciezka.TabIndex = 2
        '
        'TextBoxStacja
        '
        Me.TextBoxStacja.Location = New System.Drawing.Point(6, 38)
        Me.TextBoxStacja.Name = "TextBoxStacja"
        Me.TextBoxStacja.Size = New System.Drawing.Size(147, 20)
        Me.TextBoxStacja.TabIndex = 3
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToResizeColumns = False
        Me.DataGridView1.AllowUserToResizeRows = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(3, 3)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.Size = New System.Drawing.Size(932, 735)
        Me.DataGridView1.TabIndex = 4
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(6, 58)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(125, 17)
        Me.CheckBox1.TabIndex = 6
        Me.CheckBox1.Text = "Tylko ostatnie wersje"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(195, 472)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Label1"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(111, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Ścieżka dokumentacji"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.StatisticsBox)
        Me.GroupBox1.Controls.Add(Me.buttonEksportDoCsv)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.sSciezka)
        Me.GroupBox1.Controls.Add(Me.CheckBox1)
        Me.GroupBox1.Controls.Add(Me.ProgressBar1)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Location = New System.Drawing.Point(941, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(240, 735)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Ustawienia"
        '
        'StatisticsBox
        '
        Me.StatisticsBox.Controls.Add(Me.labelInsimCounter)
        Me.StatisticsBox.Controls.Add(Me.labelEmailCounter)
        Me.StatisticsBox.Controls.Add(Me.labelPPTCounter)
        Me.StatisticsBox.Controls.Add(Me.Label9)
        Me.StatisticsBox.Controls.Add(Me.Label8)
        Me.StatisticsBox.Controls.Add(Me.Label7)
        Me.StatisticsBox.Controls.Add(Me.labelFRGCounter)
        Me.StatisticsBox.Controls.Add(Me.Label6)
        Me.StatisticsBox.Location = New System.Drawing.Point(6, 154)
        Me.StatisticsBox.Name = "StatisticsBox"
        Me.StatisticsBox.Size = New System.Drawing.Size(228, 167)
        Me.StatisticsBox.TabIndex = 22
        Me.StatisticsBox.TabStop = False
        Me.StatisticsBox.Text = "Statystyki"
        '
        'labelInsimCounter
        '
        Me.labelInsimCounter.Location = New System.Drawing.Point(142, 55)
        Me.labelInsimCounter.Name = "labelInsimCounter"
        Me.labelInsimCounter.Size = New System.Drawing.Size(80, 13)
        Me.labelInsimCounter.TabIndex = 23
        Me.labelInsimCounter.Text = "0"
        Me.labelInsimCounter.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'labelEmailCounter
        '
        Me.labelEmailCounter.Location = New System.Drawing.Point(142, 42)
        Me.labelEmailCounter.Name = "labelEmailCounter"
        Me.labelEmailCounter.Size = New System.Drawing.Size(80, 13)
        Me.labelEmailCounter.TabIndex = 22
        Me.labelEmailCounter.Text = "0"
        Me.labelEmailCounter.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'labelPPTCounter
        '
        Me.labelPPTCounter.Location = New System.Drawing.Point(142, 29)
        Me.labelPPTCounter.Name = "labelPPTCounter"
        Me.labelPPTCounter.Size = New System.Drawing.Size(80, 13)
        Me.labelPPTCounter.TabIndex = 21
        Me.labelPPTCounter.Text = "0"
        Me.labelPPTCounter.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(6, 55)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(40, 13)
        Me.Label9.TabIndex = 20
        Me.Label9.Text = "IN SIM"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(6, 42)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(108, 13)
        Me.Label8.TabIndex = 19
        Me.Label8.Text = "Email (po stronie kon)"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 29)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(60, 13)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "Powerpoint"
        '
        'labelFRGCounter
        '
        Me.labelFRGCounter.Location = New System.Drawing.Point(142, 16)
        Me.labelFRGCounter.Name = "labelFRGCounter"
        Me.labelFRGCounter.Size = New System.Drawing.Size(80, 13)
        Me.labelFRGCounter.TabIndex = 17
        Me.labelFRGCounter.Text = "0"
        Me.labelFRGCounter.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 16)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(85, 13)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "Free for detailing"
        '
        'buttonEksportDoCsv
        '
        Me.buttonEksportDoCsv.Location = New System.Drawing.Point(6, 699)
        Me.buttonEksportDoCsv.Name = "buttonEksportDoCsv"
        Me.buttonEksportDoCsv.Size = New System.Drawing.Size(228, 30)
        Me.buttonEksportDoCsv.TabIndex = 17
        Me.buttonEksportDoCsv.Text = "Eksport .csv"
        Me.buttonEksportDoCsv.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.errorMessageStationFilter)
        Me.GroupBox2.Controls.Add(Me.s_FiltrStacjiAktywny)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.s_UkryjFreeForDetailing2)
        Me.GroupBox2.Controls.Add(Me.s_FilterLabel)
        Me.GroupBox2.Controls.Add(Me.TextBoxStacja)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Location = New System.Drawing.Point(6, 327)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(228, 139)
        Me.GroupBox2.TabIndex = 16
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Filtry aktywne"
        '
        'errorMessageStationFilter
        '
        Me.errorMessageStationFilter.AutoSize = True
        Me.errorMessageStationFilter.Location = New System.Drawing.Point(7, 120)
        Me.errorMessageStationFilter.Name = "errorMessageStationFilter"
        Me.errorMessageStationFilter.Size = New System.Drawing.Size(102, 13)
        Me.errorMessageStationFilter.TabIndex = 17
        Me.errorMessageStationFilter.Text = "Numery stacji są OK"
        '
        's_FiltrStacjiAktywny
        '
        Me.s_FiltrStacjiAktywny.AutoSize = True
        Me.s_FiltrStacjiAktywny.Location = New System.Drawing.Point(159, 41)
        Me.s_FiltrStacjiAktywny.Name = "s_FiltrStacjiAktywny"
        Me.s_FiltrStacjiAktywny.Size = New System.Drawing.Size(63, 17)
        Me.s_FiltrStacjiAktywny.TabIndex = 16
        Me.s_FiltrStacjiAktywny.Text = "Aktywuj"
        Me.s_FiltrStacjiAktywny.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 84)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(60, 13)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Filtrowanie:"
        '
        's_UkryjFreeForDetailing2
        '
        Me.s_UkryjFreeForDetailing2.AutoSize = True
        Me.s_UkryjFreeForDetailing2.Location = New System.Drawing.Point(6, 64)
        Me.s_UkryjFreeForDetailing2.Name = "s_UkryjFreeForDetailing2"
        Me.s_UkryjFreeForDetailing2.Size = New System.Drawing.Size(131, 17)
        Me.s_UkryjFreeForDetailing2.TabIndex = 13
        Me.s_UkryjFreeForDetailing2.Text = "Ukryj Free for detailing"
        Me.s_UkryjFreeForDetailing2.UseVisualStyleBackColor = True
        '
        's_FilterLabel
        '
        Me.s_FilterLabel.Location = New System.Drawing.Point(138, 84)
        Me.s_FilterLabel.Name = "s_FilterLabel"
        Me.s_FilterLabel.Size = New System.Drawing.Size(80, 13)
        Me.s_FilterLabel.TabIndex = 15
        Me.s_FilterLabel.Text = "Label5"
        Me.s_FilterLabel.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 13)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Stacja"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.Controls.Add(Me.DataGridView1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.GroupBox1, 1, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1184, 761)
        Me.TableLayoutPanel1.TabIndex = 11
        '
        'ContextMenuPetla
        '
        Me.ContextMenuPetla.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OtwórzFolderToolStripMenuItem, Me.ToolStripSeparator1, Me.sFrgToolStripMenuItem, Me.sWfrgToolStripMenuItem, Me.sWfrgShowCommentToolStripMenuItem})
        Me.ContextMenuPetla.Name = "ContextMenuPetla"
        Me.ContextMenuPetla.Size = New System.Drawing.Size(375, 120)
        '
        'OtwórzFolderToolStripMenuItem
        '
        Me.OtwórzFolderToolStripMenuItem.Name = "OtwórzFolderToolStripMenuItem"
        Me.OtwórzFolderToolStripMenuItem.Size = New System.Drawing.Size(374, 22)
        Me.OtwórzFolderToolStripMenuItem.Text = "Otwórz folder"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(371, 6)
        '
        'sFrgToolStripMenuItem
        '
        Me.sFrgToolStripMenuItem.Name = "sFrgToolStripMenuItem"
        Me.sFrgToolStripMenuItem.Size = New System.Drawing.Size(374, 22)
        Me.sFrgToolStripMenuItem.Text = "Zwolnij konstrukcje do Detailingu"
        '
        'sWfrgToolStripMenuItem
        '
        Me.sWfrgToolStripMenuItem.Name = "sWfrgToolStripMenuItem"
        Me.sWfrgToolStripMenuItem.Size = New System.Drawing.Size(374, 22)
        Me.sWfrgToolStripMenuItem.Text = "Zwolnij konstrukcje warunkowo do Detailingu"
        '
        'ToolStripTextBox1
        '
        Me.ToolStripTextBox1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ToolStripTextBox1.Name = "ToolStripTextBox1"
        Me.ToolStripTextBox1.Size = New System.Drawing.Size(100, 23)
        Me.ToolStripTextBox1.Text = "Test string dsfi sydif ysdaiyf isydaify sdyfi ysdfy isdyfisyd iysdyfdsi yfisdyisd" &
    "y fisydify dsifyidsyfidsyfidsyfidsyfisdyifydsifysdifysi"
        '
        'sWfrgShowCommentToolStripMenuItem
        '
        Me.sWfrgShowCommentToolStripMenuItem.Name = "sWfrgShowCommentToolStripMenuItem"
        Me.sWfrgShowCommentToolStripMenuItem.Size = New System.Drawing.Size(374, 22)
        Me.sWfrgShowCommentToolStripMenuItem.Text = "Pokaz komentarz warunkowego zwolnienia do detailingu"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1184, 761)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.StatisticsBox.ResumeLayout(False)
        Me.StatisticsBox.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.ContextMenuPetla.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents sSciezka As TextBox
    Friend WithEvents TextBoxStacja As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents s_UkryjFreeForDetailing2 As CheckBox
    Friend WithEvents s_FilterLabel As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents s_FiltrStacjiAktywny As CheckBox
    Friend WithEvents buttonEksportDoCsv As Button
    Friend WithEvents StatisticsBox As GroupBox
    Friend WithEvents labelFRGCounter As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents labelPPTCounter As Label
    Friend WithEvents labelEmailCounter As Label
    Friend WithEvents labelInsimCounter As Label
    Friend WithEvents errorMessageStationFilter As Label
    Friend WithEvents ContextMenuPetla As ContextMenuStrip
    Friend WithEvents OtwórzFolderToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ToolStripTextBox1 As ToolStripTextBox
    Friend WithEvents sFrgToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents sWfrgToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents sWfrgShowCommentToolStripMenuItem As ToolStripMenuItem
End Class
