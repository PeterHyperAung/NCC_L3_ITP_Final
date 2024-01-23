Public Class frm_main
    Private Sub cmd_load_Click(sender As Object, e As EventArgs) Handles cmd_load.Click
        frm_mean_median_mode.Show()
        frm_spearman.Hide()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        frm_mean_median_mode.TopLevel = False
        Me.pnl_body.Controls.Add(frm_mean_median_mode)

        frm_spearman.TopLevel = False
        Me.pnl_body.Controls.Add(frm_spearman)

        frm_spearman.Hide()
        frm_mean_median_mode.Show()
    End Sub

    Private Sub cmd_input_data_Click(sender As Object, e As EventArgs) Handles cmd_input_data.Click
        frm_spearman.Show()
        frm_mean_median_mode.Hide()
    End Sub

End Class
