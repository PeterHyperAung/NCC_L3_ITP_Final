<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_correlation_coefficient_desc
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_correlation_coefficient_desc))
        Me.lbl_desc = New System.Windows.Forms.Label()
        Me.pbx_formula = New System.Windows.Forms.PictureBox()
        Me.lbl_title = New System.Windows.Forms.Label()
        CType(Me.pbx_formula, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_desc
        '
        Me.lbl_desc.Font = New System.Drawing.Font("Arial", 9.5!)
        Me.lbl_desc.Location = New System.Drawing.Point(59, 127)
        Me.lbl_desc.Name = "lbl_desc"
        Me.lbl_desc.Size = New System.Drawing.Size(589, 165)
        Me.lbl_desc.TabIndex = 36
        Me.lbl_desc.Text = resources.GetString("lbl_desc.Text")
        Me.lbl_desc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pbx_formula
        '
        Me.pbx_formula.Location = New System.Drawing.Point(354, 39)
        Me.pbx_formula.Name = "pbx_formula"
        Me.pbx_formula.Size = New System.Drawing.Size(189, 77)
        Me.pbx_formula.TabIndex = 37
        Me.pbx_formula.TabStop = False
        '
        'lbl_title
        '
        Me.lbl_title.AutoSize = True
        Me.lbl_title.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_title.Location = New System.Drawing.Point(189, 64)
        Me.lbl_title.Name = "lbl_title"
        Me.lbl_title.Size = New System.Drawing.Size(146, 24)
        Me.lbl_title.TabIndex = 38
        Me.lbl_title.Text = "The formula is"
        '
        'frm_correlation_coefficient_desc
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(711, 304)
        Me.Controls.Add(Me.lbl_title)
        Me.Controls.Add(Me.pbx_formula)
        Me.Controls.Add(Me.lbl_desc)
        Me.Name = "frm_correlation_coefficient_desc"
        Me.Text = "Spearman's Rank Correlation Coefficient Description"
        CType(Me.pbx_formula, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_desc As Label
    Friend WithEvents pbx_formula As PictureBox
    Friend WithEvents lbl_title As Label
End Class
