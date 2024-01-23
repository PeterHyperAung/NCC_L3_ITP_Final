<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_spearman
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
        Me.lbl_dp = New System.Windows.Forms.Label()
        Me.txt_dp = New System.Windows.Forms.TextBox()
        Me.cmd_calc_file = New System.Windows.Forms.Button()
        Me.cmd_calc_input = New System.Windows.Forms.Button()
        Me.lbl_xdatainput_details = New System.Windows.Forms.Label()
        Me.lbl_x_input_title = New System.Windows.Forms.Label()
        Me.rtxt_x_data = New System.Windows.Forms.RichTextBox()
        Me.cmd_desc = New System.Windows.Forms.Button()
        Me.pbx_x_load = New System.Windows.Forms.PictureBox()
        Me.lbl_ydatainput_details = New System.Windows.Forms.Label()
        Me.lbl_y_input_title = New System.Windows.Forms.Label()
        Me.rtxt_y_data = New System.Windows.Forms.RichTextBox()
        Me.gbx_textbox_input = New System.Windows.Forms.GroupBox()
        Me.pbx_y_load = New System.Windows.Forms.PictureBox()
        Me.gbx_file_input = New System.Windows.Forms.GroupBox()
        Me.lbl_file_details = New System.Windows.Forms.Label()
        Me.cmd_load_x = New System.Windows.Forms.Button()
        Me.cmd_load_y = New System.Windows.Forms.Button()
        Me.gbx_desc = New System.Windows.Forms.GroupBox()
        Me.lbl_desc = New System.Windows.Forms.Label()
        Me.lbl_result = New System.Windows.Forms.Label()
        CType(Me.pbx_x_load, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbx_textbox_input.SuspendLayout()
        CType(Me.pbx_y_load, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbx_file_input.SuspendLayout()
        Me.gbx_desc.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbl_dp
        '
        Me.lbl_dp.AutoSize = True
        Me.lbl_dp.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lbl_dp.Location = New System.Drawing.Point(413, 85)
        Me.lbl_dp.Name = "lbl_dp"
        Me.lbl_dp.Size = New System.Drawing.Size(279, 24)
        Me.lbl_dp.TabIndex = 26
        Me.lbl_dp.Text = "Decimal Places of the Result"
        '
        'txt_dp
        '
        Me.txt_dp.Location = New System.Drawing.Point(415, 121)
        Me.txt_dp.Name = "txt_dp"
        Me.txt_dp.Size = New System.Drawing.Size(285, 22)
        Me.txt_dp.TabIndex = 25
        '
        'cmd_calc_file
        '
        Me.cmd_calc_file.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.cmd_calc_file.Location = New System.Drawing.Point(157, 245)
        Me.cmd_calc_file.Name = "cmd_calc_file"
        Me.cmd_calc_file.Size = New System.Drawing.Size(130, 57)
        Me.cmd_calc_file.TabIndex = 24
        Me.cmd_calc_file.Text = "Calculate File Data"
        Me.cmd_calc_file.UseVisualStyleBackColor = True
        '
        'cmd_calc_input
        '
        Me.cmd_calc_input.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.cmd_calc_input.Location = New System.Drawing.Point(134, 456)
        Me.cmd_calc_input.Name = "cmd_calc_input"
        Me.cmd_calc_input.Size = New System.Drawing.Size(146, 57)
        Me.cmd_calc_input.TabIndex = 20
        Me.cmd_calc_input.Text = "Calculate Input Data"
        Me.cmd_calc_input.UseVisualStyleBackColor = True
        '
        'lbl_xdatainput_details
        '
        Me.lbl_xdatainput_details.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.lbl_xdatainput_details.Location = New System.Drawing.Point(29, 194)
        Me.lbl_xdatainput_details.Name = "lbl_xdatainput_details"
        Me.lbl_xdatainput_details.Size = New System.Drawing.Size(391, 37)
        Me.lbl_xdatainput_details.TabIndex = 29
        Me.lbl_xdatainput_details.Text = "Please provide with comma separated and with the same order as corresponding y va" &
    "lues"
        '
        'lbl_x_input_title
        '
        Me.lbl_x_input_title.AutoSize = True
        Me.lbl_x_input_title.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_x_input_title.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lbl_x_input_title.Location = New System.Drawing.Point(28, 51)
        Me.lbl_x_input_title.Name = "lbl_x_input_title"
        Me.lbl_x_input_title.Size = New System.Drawing.Size(86, 24)
        Me.lbl_x_input_title.TabIndex = 28
        Me.lbl_x_input_title.Text = "x's Data"
        '
        'rtxt_x_data
        '
        Me.rtxt_x_data.BackColor = System.Drawing.Color.LightGray
        Me.rtxt_x_data.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.rtxt_x_data.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.rtxt_x_data.Location = New System.Drawing.Point(32, 81)
        Me.rtxt_x_data.Name = "rtxt_x_data"
        Me.rtxt_x_data.Size = New System.Drawing.Size(366, 100)
        Me.rtxt_x_data.TabIndex = 27
        Me.rtxt_x_data.Text = ""
        '
        'cmd_desc
        '
        Me.cmd_desc.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.cmd_desc.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.cmd_desc.Location = New System.Drawing.Point(140, 105)
        Me.cmd_desc.Name = "cmd_desc"
        Me.cmd_desc.Size = New System.Drawing.Size(158, 67)
        Me.cmd_desc.TabIndex = 34
        Me.cmd_desc.Text = "Click to see it!"
        Me.cmd_desc.UseVisualStyleBackColor = True
        '
        'pbx_x_load
        '
        Me.pbx_x_load.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.pbx_x_load.Location = New System.Drawing.Point(91, 63)
        Me.pbx_x_load.Name = "pbx_x_load"
        Me.pbx_x_load.Size = New System.Drawing.Size(70, 70)
        Me.pbx_x_load.TabIndex = 0
        Me.pbx_x_load.TabStop = False
        '
        'lbl_ydatainput_details
        '
        Me.lbl_ydatainput_details.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.lbl_ydatainput_details.Location = New System.Drawing.Point(29, 396)
        Me.lbl_ydatainput_details.Name = "lbl_ydatainput_details"
        Me.lbl_ydatainput_details.Size = New System.Drawing.Size(391, 37)
        Me.lbl_ydatainput_details.TabIndex = 38
        Me.lbl_ydatainput_details.Text = "Please provide with comma separated and with the same order as corresponding x va" &
    "lues"
        '
        'lbl_y_input_title
        '
        Me.lbl_y_input_title.AutoSize = True
        Me.lbl_y_input_title.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_y_input_title.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lbl_y_input_title.Location = New System.Drawing.Point(28, 253)
        Me.lbl_y_input_title.Name = "lbl_y_input_title"
        Me.lbl_y_input_title.Size = New System.Drawing.Size(86, 24)
        Me.lbl_y_input_title.TabIndex = 37
        Me.lbl_y_input_title.Text = "y's Data"
        '
        'rtxt_y_data
        '
        Me.rtxt_y_data.BackColor = System.Drawing.Color.LightGray
        Me.rtxt_y_data.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.rtxt_y_data.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.rtxt_y_data.Location = New System.Drawing.Point(32, 283)
        Me.rtxt_y_data.Name = "rtxt_y_data"
        Me.rtxt_y_data.Size = New System.Drawing.Size(366, 100)
        Me.rtxt_y_data.TabIndex = 36
        Me.rtxt_y_data.Text = ""
        '
        'gbx_textbox_input
        '
        Me.gbx_textbox_input.Controls.Add(Me.lbl_ydatainput_details)
        Me.gbx_textbox_input.Controls.Add(Me.lbl_y_input_title)
        Me.gbx_textbox_input.Controls.Add(Me.rtxt_y_data)
        Me.gbx_textbox_input.Controls.Add(Me.lbl_xdatainput_details)
        Me.gbx_textbox_input.Controls.Add(Me.lbl_x_input_title)
        Me.gbx_textbox_input.Controls.Add(Me.rtxt_x_data)
        Me.gbx_textbox_input.Controls.Add(Me.cmd_calc_input)
        Me.gbx_textbox_input.Font = New System.Drawing.Font("Arial Black", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbx_textbox_input.Location = New System.Drawing.Point(84, 171)
        Me.gbx_textbox_input.Name = "gbx_textbox_input"
        Me.gbx_textbox_input.Size = New System.Drawing.Size(439, 539)
        Me.gbx_textbox_input.TabIndex = 39
        Me.gbx_textbox_input.TabStop = False
        Me.gbx_textbox_input.Text = "Textbox Input"
        '
        'pbx_y_load
        '
        Me.pbx_y_load.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.pbx_y_load.Location = New System.Drawing.Point(273, 63)
        Me.pbx_y_load.Name = "pbx_y_load"
        Me.pbx_y_load.Size = New System.Drawing.Size(70, 70)
        Me.pbx_y_load.TabIndex = 0
        Me.pbx_y_load.TabStop = False
        '
        'gbx_file_input
        '
        Me.gbx_file_input.Controls.Add(Me.pbx_y_load)
        Me.gbx_file_input.Controls.Add(Me.pbx_x_load)
        Me.gbx_file_input.Controls.Add(Me.lbl_file_details)
        Me.gbx_file_input.Controls.Add(Me.cmd_calc_file)
        Me.gbx_file_input.Controls.Add(Me.cmd_load_x)
        Me.gbx_file_input.Controls.Add(Me.cmd_load_y)
        Me.gbx_file_input.Font = New System.Drawing.Font("Arial Black", 10.2!, System.Drawing.FontStyle.Bold)
        Me.gbx_file_input.Location = New System.Drawing.Point(579, 172)
        Me.gbx_file_input.Name = "gbx_file_input"
        Me.gbx_file_input.Size = New System.Drawing.Size(439, 319)
        Me.gbx_file_input.TabIndex = 40
        Me.gbx_file_input.TabStop = False
        Me.gbx_file_input.Text = "File Input"
        '
        'lbl_file_details
        '
        Me.lbl_file_details.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.lbl_file_details.Location = New System.Drawing.Point(52, 204)
        Me.lbl_file_details.Name = "lbl_file_details"
        Me.lbl_file_details.Size = New System.Drawing.Size(332, 41)
        Me.lbl_file_details.TabIndex = 39
        Me.lbl_file_details.Text = "Please separate data in files with a new line and do not add extra new line"
        '
        'cmd_load_x
        '
        Me.cmd_load_x.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.cmd_load_x.Location = New System.Drawing.Point(51, 47)
        Me.cmd_load_x.Name = "cmd_load_x"
        Me.cmd_load_x.Padding = New System.Windows.Forms.Padding(10, 0, 10, 10)
        Me.cmd_load_x.Size = New System.Drawing.Size(150, 150)
        Me.cmd_load_x.TabIndex = 42
        Me.cmd_load_x.Text = "Load x's data from a text file "
        Me.cmd_load_x.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmd_load_x.UseVisualStyleBackColor = True
        '
        'cmd_load_y
        '
        Me.cmd_load_y.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.cmd_load_y.Location = New System.Drawing.Point(234, 47)
        Me.cmd_load_y.Name = "cmd_load_y"
        Me.cmd_load_y.Padding = New System.Windows.Forms.Padding(10, 0, 10, 10)
        Me.cmd_load_y.Size = New System.Drawing.Size(150, 150)
        Me.cmd_load_y.TabIndex = 44
        Me.cmd_load_y.Text = "Load y's data from a text file "
        Me.cmd_load_y.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmd_load_y.UseVisualStyleBackColor = True
        '
        'gbx_desc
        '
        Me.gbx_desc.Controls.Add(Me.lbl_desc)
        Me.gbx_desc.Controls.Add(Me.cmd_desc)
        Me.gbx_desc.Font = New System.Drawing.Font("Arial Black", 10.2!, System.Drawing.FontStyle.Bold)
        Me.gbx_desc.Location = New System.Drawing.Point(584, 515)
        Me.gbx_desc.Name = "gbx_desc"
        Me.gbx_desc.Size = New System.Drawing.Size(434, 195)
        Me.gbx_desc.TabIndex = 41
        Me.gbx_desc.TabStop = False
        Me.gbx_desc.Text = "Show Description"
        '
        'lbl_desc
        '
        Me.lbl_desc.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lbl_desc.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lbl_desc.Location = New System.Drawing.Point(27, 46)
        Me.lbl_desc.Name = "lbl_desc"
        Me.lbl_desc.Size = New System.Drawing.Size(401, 56)
        Me.lbl_desc.TabIndex = 39
        Me.lbl_desc.Text = "Description of the meaning of Spearman's Rank Correlation Coefficient"
        '
        'lbl_result
        '
        Me.lbl_result.Font = New System.Drawing.Font("Arial", 14.0!, System.Drawing.FontStyle.Bold)
        Me.lbl_result.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lbl_result.Location = New System.Drawing.Point(5, 26)
        Me.lbl_result.Name = "lbl_result"
        Me.lbl_result.Size = New System.Drawing.Size(1095, 41)
        Me.lbl_result.TabIndex = 42
        Me.lbl_result.Text = "Result : "
        Me.lbl_result.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frm_spearman
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(1100, 760)
        Me.Controls.Add(Me.lbl_result)
        Me.Controls.Add(Me.gbx_desc)
        Me.Controls.Add(Me.gbx_file_input)
        Me.Controls.Add(Me.gbx_textbox_input)
        Me.Controls.Add(Me.lbl_dp)
        Me.Controls.Add(Me.txt_dp)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frm_spearman"
        Me.Text = "frm_input_data"
        CType(Me.pbx_x_load, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbx_textbox_input.ResumeLayout(False)
        Me.gbx_textbox_input.PerformLayout()
        CType(Me.pbx_y_load, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbx_file_input.ResumeLayout(False)
        Me.gbx_desc.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl_dp As Label
    Friend WithEvents txt_dp As TextBox
    Friend WithEvents cmd_calc_file As Button
    Friend WithEvents cmd_calc_input As Button
    Friend WithEvents lbl_xdatainput_details As Label
    Friend WithEvents lbl_x_input_title As Label
    Friend WithEvents rtxt_x_data As RichTextBox
    Friend WithEvents cmd_desc As Button
    Friend WithEvents lbl_ydatainput_details As Label
    Friend WithEvents lbl_y_input_title As Label
    Friend WithEvents rtxt_y_data As RichTextBox
    Friend WithEvents gbx_textbox_input As GroupBox
    Friend WithEvents pbx_x_load As PictureBox
    Friend WithEvents pbx_y_load As PictureBox
    Friend WithEvents gbx_file_input As GroupBox
    Friend WithEvents gbx_desc As GroupBox
    Friend WithEvents lbl_desc As Label
    Friend WithEvents lbl_file_details As Label
    Friend WithEvents cmd_load_x As Button
    Friend WithEvents cmd_load_y As Button
    Friend WithEvents lbl_result As Label
End Class
