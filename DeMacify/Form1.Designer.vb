<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.perform = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.unTrash = New System.Windows.Forms.CheckBox()
        Me.unFsevents = New System.Windows.Forms.CheckBox()
        Me.unUnder = New System.Windows.Forms.CheckBox()
        Me.unDSS = New System.Windows.Forms.CheckBox()
        Me.dir = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.folder = New System.Windows.Forms.FolderBrowserDialog()
        Me.process = New System.Windows.Forms.ProgressBar()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'perform
        '
        Me.perform.Enabled = False
        Me.perform.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.perform.Location = New System.Drawing.Point(12, 151)
        Me.perform.Name = "perform"
        Me.perform.Size = New System.Drawing.Size(268, 23)
        Me.perform.TabIndex = 0
        Me.perform.Text = "<select a folder first>"
        Me.perform.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.unTrash)
        Me.GroupBox1.Controls.Add(Me.unFsevents)
        Me.GroupBox1.Controls.Add(Me.unUnder)
        Me.GroupBox1.Controls.Add(Me.unDSS)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.GroupBox1.Location = New System.Drawing.Point(12, 42)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(268, 103)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'unTrash
        '
        Me.unTrash.AutoSize = True
        Me.unTrash.Checked = True
        Me.unTrash.CheckState = System.Windows.Forms.CheckState.Checked
        Me.unTrash.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.unTrash.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.unTrash.Location = New System.Drawing.Point(6, 81)
        Me.unTrash.Name = "unTrash"
        Me.unTrash.Size = New System.Drawing.Size(254, 16)
        Me.unTrash.TabIndex = 3
        Me.unTrash.Text = "Delete Trashes folder (Kills all trashed files!)"
        Me.unTrash.UseVisualStyleBackColor = True
        '
        'unFsevents
        '
        Me.unFsevents.AutoSize = True
        Me.unFsevents.Checked = True
        Me.unFsevents.CheckState = System.Windows.Forms.CheckState.Checked
        Me.unFsevents.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.unFsevents.Location = New System.Drawing.Point(6, 59)
        Me.unFsevents.Name = "unFsevents"
        Me.unFsevents.Size = New System.Drawing.Size(202, 16)
        Me.unFsevents.TabIndex = 2
        Me.unFsevents.Text = "Remove fsevents/Spotlight caches"
        Me.unFsevents.UseVisualStyleBackColor = True
        '
        'unUnder
        '
        Me.unUnder.AutoSize = True
        Me.unUnder.Checked = True
        Me.unUnder.CheckState = System.Windows.Forms.CheckState.Checked
        Me.unUnder.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.unUnder.Location = New System.Drawing.Point(6, 37)
        Me.unUnder.Name = "unUnder"
        Me.unUnder.Size = New System.Drawing.Size(79, 16)
        Me.unUnder.TabIndex = 1
        Me.unUnder.Text = "Remove ._*"
        Me.unUnder.UseVisualStyleBackColor = True
        '
        'unDSS
        '
        Me.unDSS.AutoSize = True
        Me.unDSS.Checked = True
        Me.unDSS.CheckState = System.Windows.Forms.CheckState.Checked
        Me.unDSS.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.unDSS.Location = New System.Drawing.Point(6, 15)
        Me.unDSS.Name = "unDSS"
        Me.unDSS.Size = New System.Drawing.Size(115, 16)
        Me.unDSS.TabIndex = 0
        Me.unDSS.Text = "Remove .DS_Store"
        Me.unDSS.UseVisualStyleBackColor = True
        '
        'dir
        '
        Me.dir.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.dir.Location = New System.Drawing.Point(244, 13)
        Me.dir.Name = "dir"
        Me.dir.Size = New System.Drawing.Size(35, 23)
        Me.dir.TabIndex = 2
        Me.dir.Text = "Dir"
        Me.dir.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(12, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(226, 23)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Select a folder"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'process
        '
        Me.process.Location = New System.Drawing.Point(12, 180)
        Me.process.MarqueeAnimationSpeed = 1
        Me.process.Name = "process"
        Me.process.Size = New System.Drawing.Size(268, 23)
        Me.process.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.process.TabIndex = 5
        Me.process.Value = 50
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(0, 206)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(295, 24)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "DeMacify 1.0 by vladkorotnev, 2013"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(292, 229)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.process)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dir)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.perform)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Text = "Did a Mac shit on your disks again?"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents perform As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents unUnder As System.Windows.Forms.CheckBox
    Friend WithEvents unDSS As System.Windows.Forms.CheckBox
    Friend WithEvents dir As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents folder As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents process As System.Windows.Forms.ProgressBar
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents unFsevents As System.Windows.Forms.CheckBox
    Friend WithEvents unTrash As System.Windows.Forms.CheckBox

End Class
