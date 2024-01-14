<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HomeForm
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
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.TxtIPaddr = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnFetchPL = New System.Windows.Forms.Button()
        Me.Statlabel = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.OutsetDouble
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36.39456!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 63.60544!))
        Me.TableLayoutPanel1.Controls.Add(Me.TxtIPaddr, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(27, 26)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(297, 47)
        Me.TableLayoutPanel1.TabIndex = 4
        '
        'TxtIPaddr
        '
        Me.TxtIPaddr.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.TxtIPaddr.Location = New System.Drawing.Point(113, 6)
        Me.TxtIPaddr.Name = "TxtIPaddr"
        Me.TxtIPaddr.Size = New System.Drawing.Size(178, 29)
        Me.TxtIPaddr.TabIndex = 1
        Me.TxtIPaddr.Text = "192.168.0.105"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(6, 3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(98, 32)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "IP Address"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'BtnFetchPL
        '
        Me.BtnFetchPL.BackColor = System.Drawing.Color.MistyRose
        Me.BtnFetchPL.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnFetchPL.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.BtnFetchPL.Location = New System.Drawing.Point(32, 79)
        Me.BtnFetchPL.Name = "BtnFetchPL"
        Me.BtnFetchPL.Size = New System.Drawing.Size(289, 32)
        Me.BtnFetchPL.TabIndex = 6
        Me.BtnFetchPL.Text = "Fetch Processes"
        Me.BtnFetchPL.UseVisualStyleBackColor = False
        '
        'Statlabel
        '
        Me.Statlabel.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Statlabel.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Statlabel.Location = New System.Drawing.Point(24, 133)
        Me.Statlabel.Name = "Statlabel"
        Me.Statlabel.Size = New System.Drawing.Size(305, 23)
        Me.Statlabel.TabIndex = 5
        Me.Statlabel.Text = "[■] Idle."
        Me.Statlabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'HomeForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(350, 168)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.BtnFetchPL)
        Me.Controls.Add(Me.Statlabel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "HomeForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PSDDebug_Elf_Injector"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents TxtIPaddr As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents BtnFetchPL As Button
    Friend WithEvents Statlabel As Label
End Class
