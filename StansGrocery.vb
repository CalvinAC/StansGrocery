'Calvin Coxen
'RCET 0265
'Fall 2020
'

Option Explicit On
Option Strict On


Public Class StansGroceryForm
    Dim food(256, 2) As String
    Dim filter As Integer

    Sub LoadDataArray()
        Dim temp() As String
        Dim secondArray() As String
        Dim thirdArray() As String


        temp = Split(My.Resources.Grocery, vbLf)

        For i = LBound(temp) To UBound(temp) - 1
            secondArray = Split(temp(i), Chr(34) & "," & Chr(34))
            thirdArray = Split(secondArray(0), "$$ITM")
            Console.Write(thirdArray(1))
            Me.food$(i, 0) = thirdArray(1)
            thirdArray = Split(secondArray(1), "##LOC")
            Console.Write(thirdArray(1))
            Me.food$(i, 1) = thirdArray(1)
            thirdArray = Split(secondArray(2), "%%CAT")
            thirdArray = Split(thirdArray(1), Chr(34))
            Console.WriteLine(thirdArray(0))
            Me.food$(i, 2) = thirdArray(0)

        Next


        Console.WriteLine(My.Resources.Grocery)


    End Sub

    Function Search() As Integer
        Dim searchString As String = "apples"


        For i = LBound(Me.food$) To UBound(Me.food$)
            If Me.food$(i, 0) = searchString Then
                Return i

            End If

        Next

        Return -1
    End Function
    Private Sub StansGrocery_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadDataArray()
    End Sub

    Private Sub SelectFormToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SelectFormToolStripMenuItem.Click
        SplashScreenForm.Show()
    End Sub

    Sub Tester()
        Dim tempDataArray(255) As String

        tempDataArray(255) = My.Resources.Grocery.ToArray

    End Sub

    Private Sub SearchButton_Click(sender As Object, e As EventArgs) Handles SearchButton.Click
        Dim tempDataArray(255) As String
        tempDataArray(255) = My.Resources.Grocery.ToArray
        DisplayListBox.Items.Add(tempDataArray(255))
        'DisplayLabel.text = CStr(Search())
        DisplayLabel.Text = $"{food$(Search(), 0)}{food$(Search(), 1)}{food$(Search(), 2)}"
        LoadDataArray()


    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DisplayListBox.SelectedIndexChanged

    End Sub

End Class
