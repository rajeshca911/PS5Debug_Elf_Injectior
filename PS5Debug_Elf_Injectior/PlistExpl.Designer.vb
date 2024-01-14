<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PlistExpl
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.LblProcess = New System.Windows.Forms.Label()
        Me.CMBplist = New System.Windows.Forms.ComboBox()
        Me.lblElfCount = New System.Windows.Forms.Label()
        Me.BtnSend = New System.Windows.Forms.Button()
        Me.CmbElfs = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtStat = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.LblProcess)
        Me.Panel1.Controls.Add(Me.CMBplist)
        Me.Panel1.Controls.Add(Me.lblElfCount)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(198, 188)
        Me.Panel1.TabIndex = 0
        '
        'LblProcess
        '
        Me.LblProcess.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.LblProcess.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblProcess.Location = New System.Drawing.Point(0, 134)
        Me.LblProcess.Name = "LblProcess"
        Me.LblProcess.Size = New System.Drawing.Size(196, 26)
        Me.LblProcess.TabIndex = 6
        Me.LblProcess.Text = "No Process Selected"
        Me.LblProcess.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'CMBplist
        '
        Me.CMBplist.Dock = System.Windows.Forms.DockStyle.Top
        Me.CMBplist.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CMBplist.FormattingEnabled = True
        Me.CMBplist.Location = New System.Drawing.Point(0, 26)
        Me.CMBplist.Name = "CMBplist"
        Me.CMBplist.Size = New System.Drawing.Size(196, 28)
        Me.CMBplist.TabIndex = 0
        '
        'lblElfCount
        '
        Me.lblElfCount.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lblElfCount.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblElfCount.Location = New System.Drawing.Point(0, 160)
        Me.lblElfCount.Name = "lblElfCount"
        Me.lblElfCount.Size = New System.Drawing.Size(196, 26)
        Me.lblElfCount.TabIndex = 5
        Me.lblElfCount.Text = "Total Elf Files"
        Me.lblElfCount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'BtnSend
        '
        Me.BtnSend.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSend.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.BtnSend.Location = New System.Drawing.Point(282, 44)
        Me.BtnSend.Name = "BtnSend"
        Me.BtnSend.Size = New System.Drawing.Size(106, 32)
        Me.BtnSend.TabIndex = 2
        Me.BtnSend.Text = "Send"
        Me.BtnSend.UseVisualStyleBackColor = True
        '
        'CmbElfs
        '
        Me.CmbElfs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbElfs.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.CmbElfs.FormattingEnabled = True
        Me.CmbElfs.Location = New System.Drawing.Point(282, 9)
        Me.CmbElfs.Name = "CmbElfs"
        Me.CmbElfs.Size = New System.Drawing.Size(209, 29)
        Me.CmbElfs.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label2.Location = New System.Drawing.Point(204, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 26)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Elf Files"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TxtStat
        '
        Me.TxtStat.BackColor = System.Drawing.Color.Snow
        Me.TxtStat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtStat.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtStat.Location = New System.Drawing.Point(203, 86)
        Me.TxtStat.Multiline = True
        Me.TxtStat.Name = "TxtStat"
        Me.TxtStat.Size = New System.Drawing.Size(288, 101)
        Me.TxtStat.TabIndex = 5
        Me.TxtStat.Text = "Process Info"
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(196, 26)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Select Process:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PlistExpl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Snow
        Me.ClientSize = New System.Drawing.Size(497, 188)
        Me.Controls.Add(Me.TxtStat)
        Me.Controls.Add(Me.CmbElfs)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.BtnSend)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "PlistExpl"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Process Explorer"
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents CMBplist As ComboBox
    Friend WithEvents BtnSend As Button
    Friend WithEvents CmbElfs As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents lblElfCount As Label
    Friend WithEvents LblProcess As Label
    Friend WithEvents TxtStat As TextBox
    Friend WithEvents Label1 As Label
End Class
