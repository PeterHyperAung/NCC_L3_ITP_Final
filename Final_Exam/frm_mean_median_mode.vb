Imports System.IO
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Button

Public Class frm_mean_median_mode
    Dim file_arr As String()
    Dim txt_arr As String()
    Dim file_error As Boolean = False
    Dim input_error As Boolean = False
    Dim fetched_data As Boolean = False


    Function get_rdo_val() As String
        If rdo_mean.Checked Then
            Return "MEAN"
        ElseIf rdo_median.Checked Then
            Return "MEDIAN"
        ElseIf rdo_mode.Checked Then
            Return "MODE"
        End If

        Return ""
    End Function

    Function calc_mean(arr As String())
        Dim sum As Double = 0
        For Each number As Double In arr
            sum += number
        Next

        Dim mean As Double = sum / arr.Length
        Return mean
    End Function

    Function calc_median(arr As String())
        Dim med_arr(arr.Length - 1) As Double

        For idx = 0 To arr.Length - 1
            med_arr(idx) = arr(idx)
        Next

        Array.Sort(med_arr)

        If med_arr.Length Mod 2 = 1 Then
            Dim mid_num As Integer = med_arr.Length \ 2
            Return med_arr(mid_num)
        Else
            Dim mid_num1 As Integer = med_arr.Length \ 2 - 1, mid_num2 As Integer = med_arr.Length \ 2
            Return (med_arr(mid_num1) + med_arr(mid_num2)) / 2.0
        End If
    End Function

    Function calc_mode(arr As String())
        If (arr.Length = 1) Then
            Return arr(0)
        End If

        Dim dict As New Dictionary(Of Double, Integer), mostFrequency = 0, result As Double = Integer.MinValue

        For Each num As Double In arr
            If dict.ContainsKey(num) Then
                dict(num) += 1
            Else
                dict(num) = 1
            End If
        Next

        For Each pair In dict
            If pair.Value > mostFrequency Then
                result = pair.Key
                mostFrequency = pair.Value
            End If
        Next

        Return result
    End Function

    Function get_dp()
        If (IsNumeric(txt_dp.Text)) Then
            If txt_dp.Text > 10 Then
                MessageBox.Show("Decimal places should not be greater than 10")
            Else
                Return txt_dp.Text
            End If
        Else
            Return 0
        End If
    End Function

    Function fetch_input_data()
        Dim data As String = rtxt_data.Text
        If (data.Trim() = "") Then
            input_error = True
        Else
            Dim tempArr As String() = data.Split(",")

            Dim index As Integer = 0
            While index < tempArr.Length
                If (Not IsNumeric(tempArr(index).Trim())) Then
                    MessageBox.Show("There're wrong data or incorrect formats")
                    input_error = True
                    Exit While
                Else
                    input_error = False
                End If
                index += 1
            End While

            If (Not input_error) Then
                txt_arr = tempArr
            End If
        End If
    End Function

    Private Sub cmd_calc_input_Click(sender As Object, e As EventArgs) Handles cmd_calc_input.Click
        Dim dp As Integer = get_dp()
        fetch_input_data()
        If (Not input_error) Then
            Dim method As String = get_rdo_val()
            If method = "" Then
                MessageBox.Show("Please select a method")
            ElseIf method = "MEAN" Then
                Dim result As Double = Math.Round(calc_mean(txt_arr), dp)
                lbl_result.Text = $"Result: Mean of the data set is {result}."
            ElseIf method = "MEDIAN" Then
                Dim result As Double = Math.Round(calc_median(txt_arr), dp)
                lbl_result.Text = $"Result: Median of the data set is {result}."
            ElseIf method = "MODE" Then
                Dim result As Double = Math.Round(calc_mode(txt_arr), dp)
                If result <> Integer.MinValue Then
                    lbl_result.Text = $"Result: Mode of the data set is {result}."
                Else
                    lbl_result.Text = "Result: There's no mode."
                End If
            Else
                MessageBox.Show("Something went wrong! Please try again.")
            End If
        Else
            If (rtxt_data.Text.Trim() = "") Then
                MessageBox.Show("There's no data in the input")
            ElseIf (input_error) Then
                MessageBox.Show("Wrong data in the input or data in the input isn't properly formatted to the criteria")
            Else
                MessageBox.Show("Something went wrong! Please try again.")
            End If
        End If
    End Sub


    Private Sub frm_mean_median_mode_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        pbx_get_data.BackgroundImage = Image.FromFile("file_upload.png")
        pbx_get_data.BackgroundImageLayout = ImageLayout.Stretch
    End Sub

    Function handle_file_load()
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
                        file_error = True
                        Exit While
                    Else
                        file_error = False
                    End If
                    index += 1
                End While

                fetched_data = True

                If (Not file_error) Then
                    file_arr = tempArr
                End If
            End If

        End If
    End Function

    Private Sub cmd_get_data_Click(sender As Object, e As EventArgs) Handles cmd_get_data.Click
        handle_file_load()
    End Sub

    Private Sub cmd_calc_file_Click(sender As Object, e As EventArgs) Handles cmd_calc_file.Click
        Dim dp As Integer = get_dp()
        If (Not file_error And fetched_data) Then
            Dim method As String = get_rdo_val()
            If method = "" Then
                MessageBox.Show("Please select a method")
            ElseIf method = "MEAN" Then
                Dim result As Double = Math.Round(calc_mean(file_arr), dp)
                lbl_result.Text = $"Result: Mean of the data set is {result}."
            ElseIf method = "MEDIAN" Then
                Dim result As Double = Math.Round(calc_median(file_arr), dp)
                lbl_result.Text = $"Result: Median of the data set is {result}."
            ElseIf method = "MODE" Then
                Dim result As Double = Math.Round(calc_mode(file_arr), dp)
                If result <> Integer.MinValue Then
                    lbl_result.Text = $"Result: Mode of the data set is {result}."
                Else
                    lbl_result.Text = "Result: There's no mode."
                End If
            Else
                MessageBox.Show("Something went wrong! Please try again.")
            End If
        Else
            If (Not fetched_data) Then
                MessageBox.Show("You haven't selected your file!")
            ElseIf (file_error) Then
                MessageBox.Show("There's an error while loading file!")
            Else
                MessageBox.Show("Something is wrong with your file! Please try again.")
            End If
        End If
    End Sub

    Private Sub pbx_get_data_Click(sender As Object, e As EventArgs) Handles pbx_get_data.Click
        handle_file_load()
    End Sub

End Class