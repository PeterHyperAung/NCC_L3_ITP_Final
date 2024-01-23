<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_main
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
        Me.cmd_load = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.cmd_input_data = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pnl_body = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmd_load
        '
        Me.cmd_load.Font = New System.Drawing.Font("Arial", 8.2!)
        Me.cmd_load.Location = New System.Drawing.Point(769, 12)
        Me.cmd_load.Name = "cmd_load"
        Me.cmd_load.Size = New System.Drawing.Size(138, 53)
        Me.cmd_load.TabIndex = 0
        Me.cmd_load.Text = "Mean, Median, Mode"
        Me.cmd_load.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.RoyalBlue
        Me.Panel1.Controls.Add(Me.cmd_input_data)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.cmd_load)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1100, 78)
        Me.Panel1.TabIndex = 2
        '
        'cmd_input_data
        '
        Me.cmd_input_data.Font = New System.Drawing.Font("Arial", 8.2!)
        Me.cmd_input_data.Location = New System.Drawing.Point(922, 12)
        Me.cmd_input_data.Name = "cmd_input_data"
        Me.cmd_input_data.Size = New System.Drawing.Size(166, 53)
        Me.cmd_input_data.TabIndex = 2
        Me.cmd_input_data.Text = "Spearman's Correlation Coefficient"
        Me.cmd_input_data.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Script MT Bold", 16.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.Label1.Location = New System.Drawing.Point(21, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(131, 34)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Stats App"
        '
        'pnl_body
        '
        Me.pnl_body.Location = New System.Drawing.Point(0, 78)
        Me.pnl_body.Name = "pnl_body"
        Me.pnl_body.Size = New System.Drawing.Size(1100, 760)
        Me.pnl_body.TabIndex = 2
        '
        'frm_main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1100, 838)
        Me.Controls.Add(Me.pnl_body)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frm_main"
        Me.Text = "Stats App"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents cmd_load As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents pnl_body As Panel
    Friend WithEvents cmd_input_data As Button
End Class
