Public Class Form1
    Private Sub btntotal_Click(sender As Object, e As EventArgs) Handles btntotal.Click
        'missing test counter
        If prelim1.Text = "" Then
            lblinc1.Text = 1
        End If
        If prelim2.Text = "" Then
            lblinc2.Text = 1
        End If
        If prelim3.Text = "" Then
            lblinc3.Text = 1
        End If
        If midterm1.Text = "" Then
            lblinc4.Text = 1
        End If
        If midterm2.Text = "" Then
            lblinc5.Text = 1
        End If
        If midterm3.Text = "" Then
            lblinc6.Text = 1
        End If
        If final1.Text = "" Then
            lblinc7.Text = 1
        End If
        If final2.Text = "" Then
            lblinc8.Text = 1
        End If
        If final3.Text = "" Then
            lblinc9.Text = 1
        End If

        'total missing test counter
        inctotal.Text = incomplete(lblinc1.Text, lblinc2.Text, lblinc3.Text, lblinc4.Text, lblinc5.Text, lblinc6.Text, lblinc7.Text, lblinc8.Text, lblinc9.Text)

        prelimtotal.Text = prelims(Val(prelim1.Text), Val(prelim2.Text), Val(prelim3.Text))
        prelimweight.Text = pweight(prelimtotal.Text)

        midtermstotal.Text = prelims(Val(midterm1.Text), Val(midterm2.Text), Val(midterm3.Text))
        midtermweight.Text = mweight(midtermstotal.Text)

        finalstotal.Text = prelims(Val(midterm1.Text), Val(midterm2.Text), Val(midterm3.Text))
        finalweight.Text = mweight(midtermstotal.Text)

        totgrade.Text = grade(Val(prelimweight.Text), Val(midtermweight.Text), Val(finalweight.Text))

        If Val(totgrade.Text) > 90 Then
            letremark.Text = "A"
            remark.Text = "Passed"
        ElseIf Val(totgrade.Text) > 80 Then
            letremark.Text = "B"
            remark.Text = "Passed"
        ElseIf Val(totgrade.Text) > 70 Then
            letremark.Text = "C"
            remark.Text = "Passed"
        ElseIf Val(totgrade.Text) > 60 Then
            letremark.Text = "D"
            remark.Text = "Passed"
        Else
            letremark.Text = "F"
            remark.Text = "Failed"
        End If


    End Sub

    Private Sub btnclear_Click(sender As Object, e As EventArgs) Handles btnclear.Click
        txtname.Clear()
        txtsection.Clear()
        txtid.Clear()
        prelim1.Clear()
        prelim2.Clear()
        prelim3.Clear()
        midterm1.Clear()
        midterm2.Clear()
        midterm3.Clear()
        final1.Clear()
        final2.Clear()
        final3.Clear()
        prelimtotal.Text = ""
        prelimweight.Text = ""
        midtermstotal.Text = ""
        midtermweight.Text = ""
        finalstotal.Text = ""
        finalweight.Text = ""
        letremark.Text = ""
        remark.Text = ""
        totgrade.Text = ""
        listarrays.Items.Clear()
        lblinc1.Text = ""
        lblinc2.Text = ""
        lblinc3.Text = ""
        lblinc4.Text = ""
        lblinc5.Text = ""
        lblinc6.Text = ""
        lblinc7.Text = ""
        lblinc8.Text = ""
        lblinc9.Text = ""
        inctotal.Text = ""

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form2.Show()
        If Val(inctotal.Text) = 3 Then
            Form2.dgv.Rows.Add(txtname.Text, txtsection.Text, txtid.Text, prelim1.Text, prelim2.Text, prelim3.Text, midterm1.Text, midterm2.Text, midterm3.Text, final1.Text, final2.Text, final3.Text, prelimweight.Text, midtermweight.Text, finalweight.Text, letremark.Text, "incomplete", totgrade.Text)
        ElseIf Val(inctotal.Text) > 3 Then
            Form2.dgv.Rows.Add(txtname.Text, txtsection.Text, txtid.Text, prelim1.Text, prelim2.Text, prelim3.Text, midterm1.Text, midterm2.Text, midterm3.Text, final1.Text, final2.Text, final3.Text, prelimweight.Text, midtermweight.Text, finalweight.Text, letremark.Text, "dropped", totgrade.Text)
        Else
            Form2.dgv.Rows.Add(txtname.Text, txtsection.Text, txtid.Text, prelim1.Text, prelim2.Text, prelim3.Text, midterm1.Text, midterm2.Text, midterm3.Text, final1.Text, final2.Text, final3.Text, prelimweight.Text, midtermweight.Text, finalweight.Text, letremark.Text, remark.Text, totgrade.Text)
        End If
    End Sub

    Private Sub btnsearch_Click(sender As Object, e As EventArgs) Handles btnsearch.Click
        clearlist()
        Dim str(20) As String
        str(0) = "NAME: " + txtname.Text
        str(1) = "SECTION: " + txtsection.Text
        str(2) = "ID: " + txtid.Text
        str(3) = "Prelim 1: " + prelim1.Text
        str(4) = "Prelim 2: " + prelim2.Text
        str(5) = "Prelim 3: " + prelim3.Text
        str(6) = "Midterm 1: " + midterm1.Text
        str(7) = "Midterm 2: " + midterm2.Text
        str(8) = "Midterm 3: " + midterm3.Text
        str(9) = "Final 1: " + final1.Text
        str(10) = "Final 2: " + final2.Text
        str(11) = "Final 3: " + final3.Text
        str(12) = "Prelim Total: " + prelimtotal.Text
        str(13) = "Prelim weihgt: " + prelimweight.Text
        str(14) = "Midterm Total: " + midtermstotal.Text
        str(15) = "Midterm weight: " + midtermweight.Text
        str(16) = "Final Total: " + finalstotal.Text
        str(17) = "Final weight: " + finalweight.Text
        str(18) = "Letter Remark: " + letremark.Text
        str(19) = "Remark: " + remark.Text
        str(20) = "Total Grade: " + totgrade.Text

        For num As Integer = 0 To str.Length - 1
            listArrays.Items.Add(str(num))
        Next
    End Sub

    Private Sub clearlist()
        listArrays.Items.Clear()
    End Sub

    Private Sub btnupdate_Click(sender As Object, e As EventArgs) Handles btnupdate.Click
        Dim newdatarow As DataGridViewRow
        Dim index As Integer
        newdatarow = Form2.dgv.Rows(index)

        newdatarow.Cells(0).Value = txtname.Text
        newdatarow.Cells(1).Value = txtsection.Text
        newdatarow.Cells(2).Value = txtid.Text
        newdatarow.Cells(3).Value = prelim1.Text
        newdatarow.Cells(4).Value = prelim2.Text
        newdatarow.Cells(5).Value = prelim3.Text
        newdatarow.Cells(6).Value = midterm1.Text
        newdatarow.Cells(7).Value = midterm2.Text
        newdatarow.Cells(8).Value = midterm3.Text
        newdatarow.Cells(9).Value = final1.Text
        newdatarow.Cells(10).Value = final2.Text
        newdatarow.Cells(11).Value = final3.Text
        newdatarow.Cells(12).Value = prelimweight.Text
        newdatarow.Cells(13).Value = midtermweight.Text
        newdatarow.Cells(14).Value = finalweight.Text
        newdatarow.Cells(15).Value = letremark.Text
        newdatarow.Cells(16).Value = remark.Text
        newdatarow.Cells(17).Value = totgrade.Text
    End Sub
End Class
