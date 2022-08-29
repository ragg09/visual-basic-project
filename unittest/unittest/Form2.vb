Public Class Form2
    Private Sub btnupdate_Click(sender As Object, e As EventArgs) Handles btnupdate.Click
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub btndelete_Click(sender As Object, e As EventArgs) Handles btndelete.Click
        For Each row As DataGridViewRow In dgv.SelectedRows
            dgv.Rows.Remove(row)
        Next
    End Sub

    Private Sub dgv_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv.CellClick
        Dim index As Integer
        Dim selectedrow As DataGridViewRow
        index = e.RowIndex
        selectedrow = dgv.Rows(index)
        Form1.txtname.Text = selectedrow.Cells(0).Value.ToString()
        Form1.txtsection.Text = selectedrow.Cells(1).Value.ToString()
        Form1.txtid.Text = selectedrow.Cells(2).Value.ToString()
        Form1.prelim1.Text = selectedrow.Cells(3).Value.ToString()
        Form1.prelim2.Text = selectedrow.Cells(4).Value.ToString()
        Form1.prelim3.Text = selectedrow.Cells(5).Value.ToString()
        Form1.midterm1.Text = selectedrow.Cells(6).Value.ToString()
        Form1.midterm2.Text = selectedrow.Cells(7).Value.ToString()
        Form1.midterm3.Text = selectedrow.Cells(8).Value.ToString()
        Form1.final1.Text = selectedrow.Cells(9).Value.ToString()
        Form1.final2.Text = selectedrow.Cells(10).Value.ToString()
        Form1.final3.Text = selectedrow.Cells(11).Value.ToString()
        Form1.prelimweight.Text = selectedrow.Cells(12).Value.ToString()
        Form1.finalweight.Text = selectedrow.Cells(13).Value.ToString()
        Form1.letremark.Text = selectedrow.Cells(14).Value.ToString()
        Form1.remark.Text = selectedrow.Cells(15).Value.ToString()
        Form1.totgrade.Text = selectedrow.Cells(16).Value.ToString()
    End Sub
End Class