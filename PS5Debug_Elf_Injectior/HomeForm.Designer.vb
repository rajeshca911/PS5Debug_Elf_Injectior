<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class HomeForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(HomeForm))
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.TxtIPaddr = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnFetchPL = New System.Windows.Forms.Button()
        Me.Statlabel = New System.Windows.Forms.Label()
        Me.BtnDebug = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.SettingsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CreditsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36.39456!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 63.60544!))
        Me.TableLayoutPanel1.Controls.Add(Me.TxtIPaddr, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(30, 26)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(290, 47)
        Me.TableLayoutPanel1.TabIndex = 4
        '
        'TxtIPaddr
        '
        Me.TxtIPaddr.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.TxtIPaddr.Location = New System.Drawing.Point(108, 3)
        Me.TxtIPaddr.Name = "TxtIPaddr"
        Me.TxtIPaddr.Size = New System.Drawing.Size(178, 29)
        Me.TxtIPaddr.TabIndex = 1
        Me.TxtIPaddr.Text = "192.168.0.105"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(3, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(98, 32)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "PS5 IP"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'BtnFetchPL
        '
        Me.BtnFetchPL.BackColor = System.Drawing.Color.Moccasin
        Me.BtnFetchPL.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnFetchPL.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnFetchPL.Image = Global.PS5Debug_Elf_Injectior.My.Resources.Resources.receipt_FILL0_wght400_GRAD0_opsz24
        Me.BtnFetchPL.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnFetchPL.Location = New System.Drawing.Point(97, 120)
        Me.BtnFetchPL.Name = "BtnFetchPL"
        Me.BtnFetchPL.Size = New System.Drawing.Size(176, 29)
        Me.BtnFetchPL.TabIndex = 6
        Me.BtnFetchPL.Text = "Fetch Processes"
        Me.BtnFetchPL.UseVisualStyleBackColor = False
        '
        'Statlabel
        '
        Me.Statlabel.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Statlabel.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Statlabel.Location = New System.Drawing.Point(24, 171)
        Me.Statlabel.Name = "Statlabel"
        Me.Statlabel.Size = New System.Drawing.Size(305, 23)
        Me.Statlabel.TabIndex = 5
        Me.Statlabel.Text = "[■] Idle."
        Me.Statlabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'BtnDebug
        '
        Me.BtnDebug.BackColor = System.Drawing.Color.MistyRose
        Me.BtnDebug.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnDebug.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnDebug.Image = Global.PS5Debug_Elf_Injectior.My.Resources.Resources.input_circle_FILL0_wght400_GRAD0_opsz24
        Me.BtnDebug.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnDebug.Location = New System.Drawing.Point(97, 83)
        Me.BtnDebug.Name = "BtnDebug"
        Me.BtnDebug.Size = New System.Drawing.Size(176, 29)
        Me.BtnDebug.TabIndex = 7
        Me.BtnDebug.Text = "Send PS5_Debug"
        Me.BtnDebug.UseVisualStyleBackColor = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SettingsToolStripMenuItem, Me.CreditsToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(350, 24)
        Me.MenuStrip1.TabIndex = 8
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'SettingsToolStripMenuItem
        '
        Me.SettingsToolStripMenuItem.Image = Global.PS5Debug_Elf_Injectior.My.Resources.Resources.settings_FILL0_wght400_GRAD0_opsz24
        Me.SettingsToolStripMenuItem.Name = "SettingsToolStripMenuItem"
        Me.SettingsToolStripMenuItem.Size = New System.Drawing.Size(77, 20)
        Me.SettingsToolStripMenuItem.Text = "Settings"
        '
        'CreditsToolStripMenuItem
        '
        Me.CreditsToolStripMenuItem.Image = Global.PS5Debug_Elf_Injectior.My.Resources.Resources.lightbulb_FILL0_wght400_GRAD0_opsz24
        Me.CreditsToolStripMenuItem.Name = "CreditsToolStripMenuItem"
        Me.CreditsToolStripMenuItem.Size = New System.Drawing.Size(72, 20)
        Me.CreditsToolStripMenuItem.Text = "Credits"
        '
        'HomeForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(350, 203)
        Me.Controls.Add(Me.BtnDebug)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.BtnFetchPL)
        Me.Controls.Add(Me.Statlabel)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "HomeForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PSDDebug_Elf_Injector"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents TxtIPaddr As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents BtnFetchPL As Button
    Friend WithEvents Statlabel As Label
    Friend WithEvents BtnDebug As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents SettingsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CreditsToolStripMenuItem As ToolStripMenuItem
End Class
