﻿Public Class AboutForm

    Private Sub AboutForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AboutLabel.Text = "Made by: Calvin Coxen" & vbNewLine & "Fall 2020" & vbNewLine & "RCET 0265" & vbNewLine & "Stans Grocery" & vbNewLine & "Version Alpha"

    End Sub

    Private Sub AboutForm_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        StansGroceryForm.Show()
    End Sub
End Class