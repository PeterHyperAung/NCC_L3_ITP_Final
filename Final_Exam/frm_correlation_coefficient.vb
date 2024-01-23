Imports System.IO

Public Class frm_spearman
    Dim x_file_error As Boolean = False
    Dim x_fetched_data As Boolean = False
    Dim x_file_arr As String()

    Dim y_file_error As Boolean = False
    Dim y_fetched_data As Boolean = False
    Dim y_file_arr As String()

    Dim x_input_error As Boolean = False
    Dim x_txt_arr As String()

    Dim y_input_error As Boolean = False
    Dim y_txt_arr As String()


    Private Sub cmd_desc_Click(sender As Object, e As EventArgs) Handles cmd_desc.Click
        frm_correlation_coefficient_desc.ShowDialog()
    End Sub

    Function get_dp()
        If (IsNumeric(txt_dp.Text)) Then
            If txt_dp.Text > 10 Then
                MessageBox.Show("Decimal places should not be greater than 10")
            Else
                Return txt_dp.Text
            End If
        Else
            Return 2
        End If
    End Function

    Function fetch_input_x_data()
        Dim data As String = rtxt_x_data.Text
        If (data.Trim() = "") Then
            x_input_error = True
        Else
            Dim tempArr As String() = data.Split(",")

            Dim index As Integer = 0
            While index < tempArr.Length
                If (Not IsNumeric(tempArr(index).Trim())) Then
                    MessageBox.Show("There're wrong data or incorrect formats")
                    x_input_error = True
                    Exit While
                Else
                    x_input_error = False
                End If
                index += 1
            End While

            If (Not x_input_error) Then
                x_txt_arr = tempArr
            End If
        End If
    End Function

    Function fetch_input_y_data()
        Dim data As String = rtxt_y_data.Text
        If (data.Trim() = "") Then
            y_input_error = True
        Else
            Dim tempArr As String() = data.Split(",")

            Dim index As Integer = 0
            While index < tempArr.Length
                If (Not IsNumeric(tempArr(index).Trim())) Then
                    MessageBox.Show("There're wrong data or incorrect formats")
                    y_input_error = True
                    Exit While
                Else
                    y_input_error = False
                End If
                index += 1
            End While

            If (Not y_input_error) Then
                y_txt_arr = tempArr
            End If
        End If
    End Function


    Function handle_y_fileload()
        Dim fileDialog As New OpenFileDialog()

        fileDialog.Title = "Select File"
        fileDialog.Filter = "Text Files (*.txt)|*.txt"

        If fileDialog.ShowDialog() = DialogResult.OK Then
            Dim reader As StreamReader = New StreamReader(fileDialog.FileName)
            Dim data As String = reader.ReadToEnd()
            reader.Close()

            If (data.Trim() = "") Then
                MessageBox.Show("Error!! There is no data inside the text file")
            Else
                Dim tempArr As String() = data.Split(vbCrLf)

                Dim index As Integer = 0
                While index < tempArr.Length
                    If (Not IsNumeric(tempArr(index).Trim())) Then
                        MessageBox.Show("There're wrong data or incorrect formats")
                        y_file_error = True
                        Exit While
                    Else
                        y_file_error = False
                    End If
                    index += 1
                End While

                y_fetched_data = True

                If (Not y_file_error) Then
                    y_file_arr = tempArr
                End If
            End If

        End If
    End Function

    Function handle_x_fileload()
        Dim fileDialog As New OpenFileDialog()

        fileDialog.Title = "Select File"
        fileDialog.Filter = "Text Files (*.txt)|*.txt"

        If fileDialog.ShowDialog() = DialogResult.OK Then
            Dim reader As StreamReader = New StreamReader(fileDialog.FileName)
            Dim data As String = reader.ReadToEnd()
            reader.Close()

            If (data.Trim() = "") Then
                MessageBox.Show("Error!! There is no data inside the text file")
            Else
                Dim tempArr As String() = data.Split(vbCrLf)

                Dim index As Integer = 0
                While index < tempArr.Length
                    If (Not IsNumeric(tempArr(index).Trim())) Then
                        MessageBox.Show("There're wrong data or incorrect formats")
                        x_file_error = True
                        Exit While
                    Else
                        x_file_error = False
                    End If
                    index += 1
                End While

                x_fetched_data = True

                If (Not x_file_error) Then
                    x_file_arr = tempArr
                End If
            End If

        End If
    End Function

    Function calc_correrlation_coefficient(arr1 As String(), arr2 As String())
        Dim n As Integer = arr1.Length
        Dim x_arr(n - 1) As Double
        For idx = 0 To n - 1
            x_arr(idx) = arr1(idx)
        Next

        Dim y_arr(n - 1) As Double
        For idx = 0 To n - 1
            y_arr(idx) = arr2(idx)
        Next

        Dim rank_diff(n - 1) As Double
        For i As Integer = 0 To n - 1
            Dim x = eval_rank(x_arr, i)
            Dim y = eval_rank(y_arr, i)

            rank_diff(i) = x - y
        Next

        Dim summation_d_square As Double = 0
        For idx = 0 To rank_diff.Length - 1
            summation_d_square += (rank_diff(idx) * rank_diff(idx))
        Next


        Return 1 - (6 * summation_d_square) / (n * (n * n - 1))
    End Function

    Function eval_rank(arr As Double(), index As Integer)
        Dim sorted_arr(arr.Length - 1) As Double
        For idx = 0 To arr.Length - 1
            sorted_arr(idx) = arr(idx)
        Next

        Array.Sort(sorted_arr)

        For idx = 0 To sorted_arr.Length - 1
            If (sorted_arr(idx) = arr(index)) Then
                Return (arr.Length - idx)
            End If
        Next

    End Function

    Private Sub frm_spearman_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        pbx_x_load.BackgroundImage = Image.FromFile("file_upload.png")
        pbx_x_load.BackgroundImageLayout = ImageLayout.Stretch

        pbx_y_load.BackgroundImage = Image.FromFile("file_upload.png")
        pbx_y_load.BackgroundImageLayout = ImageLayout.Stretch
    End Sub



    Private Sub cmd_load_x_Click(sender As Object, e As EventArgs) Handles cmd_load_x.Click
        handle_x_fileload()
    End Sub

    Private Sub pbx_x_load_Click(sender As Object, e As EventArgs) Handles pbx_x_load.Click
        handle_x_fileload()
    End Sub
    Private Sub cmd_load_y_Click(sender As Object, e As EventArgs) Handles cmd_load_y.Click
        handle_y_fileload()
    End Sub

    Private Sub pbx_y_load_Click(sender As Object, e As EventArgs) Handles pbx_y_load.Click
        handle_y_fileload()
    End Sub

    Private Sub cmd_calc_file_Click(sender As Object, e As EventArgs) Handles cmd_calc_file.Click
        Dim dp As Integer = get_dp()
        If (Not x_file_error And x_fetched_data And Not y_file_error And y_fetched_data) Then
            If (x_file_arr.Length <> y_file_arr.Length) Then
                MessageBox.Show("Both data sets' length should be equal.")
            Else
                Dim result As Double = Math.Round(calc_correrlation_coefficient(x_file_arr, y_file_arr), dp)
                MessageBox.Show(result)
                Dim output As String = $"Result : Answer is {result} and it is a "
                If 0.7 <= result And result <= 1 Then
                    output += "strong positive correlation."
                ElseIf 0.3 <= result And result < 0.7 Then
                    output += "moderate positive correlation."
                ElseIf 0 < result And result < 0.3 Then
                    output += "weak positive correlation."
                ElseIf -0.3 < result And result < 0 Then
                    output += "weak negative correlation."
                ElseIf -0.7 < result And result <= -0.3 Then
                    output += "moderate negative correlation."
                ElseIf -1 <= result And result <= -0.7 Then
                    output += "strong negative correlation."
                Else
                    output += "no monotonic Relationship."
                End If

                lbl_result.Text = output


            End If
        Else
            If (Not x_fetched_data And Not y_fetched_data) Then
                MessageBox.Show("You haven't selected your files!")
            ElseIf (Not x_fetched_data) Then
                MessageBox.Show("You haven't selected your file for x data!")
            ElseIf (Not y_fetched_data) Then
                MessageBox.Show("You haven't selected your file for y data!")
            ElseIf (x_file_error) Then
                MessageBox.Show("There's an error while loading file for x data!")
            ElseIf (y_file_error) Then
                MessageBox.Show("There's an error while loading file for y data!")
            Else
                MessageBox.Show("Something is wrong with your files! Please try again.")
            End If
        End If
    End Sub

    Private Sub cmd_calc_input_Click(sender As Object, e As EventArgs) Handles cmd_calc_input.Click
        Dim dp As Integer = get_dp()

        fetch_input_x_data()
        fetch_input_y_data()

        If (Not x_input_error And Not y_input_error) Then
            If (x_txt_arr.Length <> y_txt_arr.Length) Then
                MessageBox.Show("Both data sets' length should be equal.")
            Else
                Dim result As Double = Math.Round(calc_correrlation_coefficient(x_txt_arr, y_txt_arr), dp)
                MessageBox.Show(result)
                Dim output As String = $"Result : Answer is {result} and it is a "
                If 0.7 <= result And result <= 1 Then
                    output += "strong positive correlation."
                ElseIf 0.3 <= result And result < 0.7 Then
                    output += "moderate positive correlation."
                ElseIf 0 < result And result < 0.3 Then
                    output += "weak positive correlation."
                ElseIf -0.3 < result And result < 0 Then
                    output += "weak negative correlation."
                ElseIf -0.7 < result And result <= -0.3 Then
                    output += "moderate negative correlation."
                ElseIf -1 <= result And result <= -0.7 Then
                    output += "strong negative correlation."
                Else
                    output += "no monotonic Relationship."
                End If

                lbl_result.Text = output

                x_txt_arr = {}
                y_txt_arr = {}
            End If
        Else
            If (rtxt_x_data.Text.Trim() = "") And (rtxt_y_data.Text.Trim() = "") Then
                MessageBox.Show("X and Y inputs are empty!")
            ElseIf (rtxt_x_data.Text.Trim() = "") Then
                MessageBox.Show("X input is empty!")
            ElseIf (rtxt_y_data.Text.Trim() = "") Then
                MessageBox.Show("Y input is empty!")
            ElseIf (x_input_error) Then
                MessageBox.Show("Wrong data in x input or data in input x isn't properly formatted to the criteria")
            ElseIf (y_input_error) Then
                MessageBox.Show("Wrong data in y input or data in input y isn't properly formatted to the criteria")
            Else
                MessageBox.Show("Something went wrong! Please try again.")
            End If
        End If

    End Sub
End Class