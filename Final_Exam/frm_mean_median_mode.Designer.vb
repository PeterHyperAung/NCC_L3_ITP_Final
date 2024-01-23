<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_mean_median_mode
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
        Me.cmd_get_data = New System.Windows.Forms.Button()
        Me.gbx_method = New System.Windows.Forms.GroupBox()
        Me.rdo_mode = New System.Windows.Forms.RadioButton()
        Me.rdo_median = New System.Windows.Forms.RadioButton()
        Me.rdo_mean = New System.Windows.Forms.RadioButton()
        Me.cmd_calc_input = New System.Windows.Forms.Button()
        Me.lbl_data = New System.Windows.Forms.Label()
        Me.rtxt_data = New System.Windows.Forms.RichTextBox()
        Me.cmd_calc_file = New System.Windows.Forms.Button()
        Me.lbl_result = New System.Windows.Forms.Label()
        Me.lbl_dp = New System.Windows.Forms.Label()
        Me.txt_dp = New System.Windows.Forms.TextBox()
        Me.gbx_text_input = New System.Windows.Forms.GroupBox()
        Me.lbl_text_input_details = New System.Windows.Forms.Label()
        Me.gbx_file_input = New System.Windows.Forms.GroupBox()
        Me.pbx_get_data = New System.Windows.Forms.PictureBox()
        Me.lbl_file_input_details = New System.Windows.Forms.Label()
        Me.gbx_method.SuspendLayout()
        Me.gbx_text_input.SuspendLayout()
        Me.gbx_file_input.SuspendLayout()
        CType(Me.pbx_get_data, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmd_get_data
        '
        Me.cmd_get_data.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.cmd_get_data.Location = New System.Drawing.Point(74, 42)
        Me.cmd_get_data.Name = "cmd_get_data"
        Me.cmd_get_data.Padding = New System.Windows.Forms.Padding(10, 0, 10, 10)
        Me.cmd_get_data.Size = New System.Drawing.Size(150, 150)
        Me.cmd_get_data.TabIndex = 9
        Me.cmd_get_data.Text = "Load data from a text file"
        Me.cmd_get_data.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmd_get_data.UseVisualStyleBackColor = True
        '
        'gbx_method
        '
        Me.gbx_method.Controls.Add(Me.rdo_mode)
        Me.gbx_method.Controls.Add(Me.rdo_median)
        Me.gbx_method.Controls.Add(Me.rdo_mean)
        Me.gbx_method.Font = New System.Drawing.Font("Arial Black", 10.2!, System.Drawing.FontStyle.Bold)
        Me.gbx_method.ForeColor = System.Drawing.SystemColors.ControlText
        Me.gbx_method.Location = New System.Drawing.Point(381, 168)
        Me.gbx_method.Name = "gbx_method"
        Me.gbx_method.Size = New System.Drawing.Size(355, 101)
        Me.gbx_method.TabIndex = 12
        Me.gbx_method.TabStop = False
        Me.gbx_method.Text = "Choose A Method"
        '
        'rdo_mode
        '
        Me.rdo_mode.AutoSize = True
        Me.rdo_mode.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.rdo_mode.ForeColor = System.Drawing.SystemColors.ControlText
        Me.rdo_mode.Location = New System.Drawing.Point(262, 48)
        Me.rdo_mode.Name = "rdo_mode"
        Me.rdo_mode.Size = New System.Drawing.Size(64, 21)
        Me.rdo_mode.TabIndex = 4
        Me.rdo_mode.TabStop = True
        Me.rdo_mode.Text = "Mode"
        Me.rdo_mode.UseVisualStyleBackColor = True
        '
        'rdo_median
        '
        Me.rdo_median.AutoSize = True
        Me.rdo_median.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.rdo_median.ForeColor = System.Drawing.SystemColors.ControlText
        Me.rdo_median.Location = New System.Drawing.Point(138, 48)
        Me.rdo_median.Name = "rdo_median"
        Me.rdo_median.Size = New System.Drawing.Size(75, 21)
        Me.rdo_median.TabIndex = 3
        Me.rdo_median.TabStop = True
        Me.rdo_median.Text = "Median"
        Me.rdo_median.UseVisualStyleBackColor = True
        '
        'rdo_mean
        '
        Me.rdo_mean.AutoSize = True
        Me.rdo_mean.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.rdo_mean.ForeColor = System.Drawing.SystemColors.ControlText
        Me.rdo_mean.Location = New System.Drawing.Point(26, 48)
        Me.rdo_mean.Name = "rdo_mean"
        Me.rdo_mean.Size = New System.Drawing.Size(64, 21)
        Me.rdo_mean.TabIndex = 2
        Me.rdo_mean.TabStop = True
        Me.rdo_mean.Text = "Mean"
        Me.rdo_mean.UseVisualStyleBackColor = True
        '
        'cmd_calc_input
        '
        Me.cmd_calc_input.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.cmd_calc_input.Location = New System.Drawing.Point(125, 322)
        Me.cmd_calc_input.Name = "cmd_calc_input"
        Me.cmd_calc_input.Size = New System.Drawing.Size(146, 57)
        Me.cmd_calc_input.TabIndex = 11
        Me.cmd_calc_input.Text = "Calculate Input Data"
        Me.cmd_calc_input.UseVisualStyleBackColor = True
        '
        'lbl_data
        '
        Me.lbl_data.AutoSize = True
        Me.lbl_data.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_data.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lbl_data.Location = New System.Drawing.Point(47, 38)
        Me.lbl_data.Name = "lbl_data"
        Me.lbl_data.Size = New System.Drawing.Size(53, 24)
        Me.lbl_data.TabIndex = 14
        Me.lbl_data.Text = "Data"
        '
        'rtxt_data
        '
        Me.rtxt_data.BackColor = System.Drawing.Color.LightGray
        Me.rtxt_data.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.rtxt_data.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.rtxt_data.Location = New System.Drawing.Point(50, 64)
        Me.rtxt_data.Name = "rtxt_data"
        Me.rtxt_data.Size = New System.Drawing.Size(294, 216)
        Me.rtxt_data.TabIndex = 13
        Me.rtxt_data.Text = ""
        '
        'cmd_calc_file
        '
        Me.cmd_calc_file.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.cmd_calc_file.Location = New System.Drawing.Point(88, 251)
        Me.cmd_calc_file.Name = "cmd_calc_file"
        Me.cmd_calc_file.Size = New System.Drawing.Size(130, 57)
        Me.cmd_calc_file.TabIndex = 15
        Me.cmd_calc_file.Text = "Calculate File Data"
        Me.cmd_calc_file.UseVisualStyleBackColor = True
        '
        'lbl_result
        '
        Me.lbl_result.Font = New System.Drawing.Font("Arial", 14.0!, System.Drawing.FontStyle.Bold)
        Me.lbl_result.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lbl_result.Location = New System.Drawing.Point(5, 26)
        Me.lbl_result.Name = "lbl_result"
        Me.lbl_result.Size = New System.Drawing.Size(1095, 41)
        Me.lbl_result.TabIndex = 27
        Me.lbl_result.Text = "Result : "
        Me.lbl_result.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_dp
        '
        Me.lbl_dp.AutoSize = True
        Me.lbl_dp.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lbl_dp.Location = New System.Drawing.Point(413, 85)
        Me.lbl_dp.Name = "lbl_dp"
        Me.lbl_dp.Size = New System.Drawing.Size(279, 24)
        Me.lbl_dp.TabIndex = 29
        Me.lbl_dp.Text = "Decimal Places of the Result"
        '
        'txt_dp
        '
        Me.txt_dp.Location = New System.Drawing.Point(415, 121)
        Me.txt_dp.Name = "txt_dp"
        Me.txt_dp.Size = New System.Drawing.Size(285, 22)
        Me.txt_dp.TabIndex = 28
        '
        'gbx_text_input
        '
        Me.gbx_text_input.Controls.Add(Me.lbl_text_input_details)
        Me.gbx_text_input.Controls.Add(Me.lbl_data)
        Me.gbx_text_input.Controls.Add(Me.rtxt_data)
        Me.gbx_text_input.Controls.Add(Me.cmd_calc_input)
        Me.gbx_text_input.Font = New System.Drawing.Font("Arial Black", 10.2!, System.Drawing.FontStyle.Bold)
        Me.gbx_text_input.Location = New System.Drawing.Point(165, 311)
        Me.gbx_text_input.Name = "gbx_text_input"
        Me.gbx_text_input.Size = New System.Drawing.Size(400, 400)
        Me.gbx_text_input.TabIndex = 30
        Me.gbx_text_input.TabStop = False
        Me.gbx_text_input.Text = "Textbox Input"
        '
        'lbl_text_input_details
        '
        Me.lbl_text_input_details.AutoSize = True
        Me.lbl_text_input_details.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.lbl_text_input_details.Location = New System.Drawing.Point(51, 286)
        Me.lbl_text_input_details.Name = "lbl_text_input_details"
        Me.lbl_text_input_details.Size = New System.Drawing.Size(246, 16)
        Me.lbl_text_input_details.TabIndex = 18
        Me.lbl_text_input_details.Text = "Please provide with comma separated"
        '
        'gbx_file_input
        '
        Me.gbx_file_input.Controls.Add(Me.pbx_get_data)
        Me.gbx_file_input.Controls.Add(Me.lbl_file_input_details)
        Me.gbx_file_input.Controls.Add(Me.cmd_calc_file)
        Me.gbx_file_input.Controls.Add(Me.cmd_get_data)
        Me.gbx_file_input.Font = New System.Drawing.Font("Arial Black", 10.2!, System.Drawing.FontStyle.Bold)
        Me.gbx_file_input.Location = New System.Drawing.Point(626, 311)
        Me.gbx_file_input.Name = "gbx_file_input"
        Me.gbx_file_input.Size = New System.Drawing.Size(300, 330)
        Me.gbx_file_input.TabIndex = 31
        Me.gbx_file_input.TabStop = False
        Me.gbx_file_input.Text = "File Input"
        '
        'pbx_get_data
        '
        Me.pbx_get_data.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.pbx_get_data.Location = New System.Drawing.Point(114, 60)
        Me.pbx_get_data.Name = "pbx_get_data"
        Me.pbx_get_data.Size = New System.Drawing.Size(70, 70)
        Me.pbx_get_data.TabIndex = 20
        Me.pbx_get_data.TabStop = False
        '
        'lbl_file_input_details
        '
        Me.lbl_file_input_details.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.lbl_file_input_details.Location = New System.Drawing.Point(34, 196)
        Me.lbl_file_input_details.Name = "lbl_file_input_details"
        Me.lbl_file_input_details.Size = New System.Drawing.Size(248, 42)
        Me.lbl_file_input_details.TabIndex = 19
        Me.lbl_file_input_details.Text = "Please separate the data with new line and do not add extra new line."
        Me.lbl_file_input_details.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frm_mean_median_mode
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(1100, 760)
        Me.Controls.Add(Me.gbx_file_input)
        Me.Controls.Add(Me.gbx_text_input)
        Me.Controls.Add(Me.lbl_result)
        Me.Controls.Add(Me.lbl_dp)
        Me.Controls.Add(Me.txt_dp)
        Me.Controls.Add(Me.gbx_method)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frm_mean_median_mode"
        Me.Text = "frm_load_file"
        Me.gbx_method.ResumeLayout(False)
        Me.gbx_method.PerformLayout()
        Me.gbx_text_input.ResumeLayout(False)
        Me.gbx_text_input.PerformLayout()
        Me.gbx_file_input.ResumeLayout(False)
        CType(Me.pbx_get_data, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmd_get_data As Button
    Friend WithEvents gbx_method As GroupBox
    Friend WithEvents rdo_mode As RadioButton
    Friend WithEvents rdo_median As RadioButton
    Friend WithEvents rdo_mean As RadioButton
    Friend WithEvents cmd_calc_input As Button
    Friend WithEvents lbl_data As Label
    Friend WithEvents rtxt_data As RichTextBox
    Friend WithEvents cmd_calc_file As Button
    Friend WithEvents lbl_result As Label
    Friend WithEvents lbl_dp As Label
    Friend WithEvents txt_dp As TextBox
    Friend WithEvents gbx_text_input As GroupBox
    Friend WithEvents lbl_text_input_details As Label
    Friend WithEvents gbx_file_input As GroupBox
    Friend WithEvents lbl_file_input_details As Label
    Friend WithEvents pbx_get_data As PictureBox
End Class
