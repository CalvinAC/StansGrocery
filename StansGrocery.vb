'Calvin Coxen
'RCET 0265
'Fall 2020
'Stans Grocery
'https://github.com/CalvinAC/StansGrocery

Option Explicit On
Option Strict On
Option Compare Text


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
            Me.food$(i, 1) = thirdArray(1).PadLeft(2)
            thirdArray = Split(secondArray(2), "%%CAT")
            thirdArray = Split(thirdArray(1), Chr(34))
            Console.WriteLine(thirdArray(0))
            Me.food$(i, 2) = thirdArray(0)
        Next

        Console.WriteLine(My.Resources.Grocery)

    End Sub

    Sub loadComboBox()
        If CategoryButton.Checked = True Then
            filter = 2
        Else
            filter = 1
        End If

        Try

            For i = LBound(food) To UBound(food) - 1
                If food(i, filter) <> "" And food$(i, filter) <> "  " And Not DisplayComboBox.Items.Contains(food(i, filter)) Then
                    DisplayComboBox.Items.Add(food(i, filter))

                End If

            Next

        Catch ex As Exception

        End Try
    End Sub

    Sub LoadListBox()

        For i = LBound(Me.food$) To UBound(Me.food$) - 1

            If food(i, 0) <> "" And DisplayListBox.Items.Contains(food(i, 0)) = False Then
                DisplayListBox.Items.Add(food(i, 0))
            End If
            DisplayListBox.Sorted = True

        Next
    End Sub
    Private Sub StansGrocery_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadDataArray()
        CategoryButton.Checked = True
    End Sub

    Private Sub SelectFormToolStripMenuItem_Click(sender As Object, e As EventArgs)
        SplashScreenForm.Show()
    End Sub

    Private Sub SearchButton_Click(sender As Object, e As EventArgs) Handles SearchButton.Click, SearchToolStripMenuItem.Click
        DisplayListBox.Items.Clear()
        DisplayComboBox.Items.Clear()
        Dim searchString As String = SearchBox.Text

        Try
            For i = LBound(Me.food$) To UBound(Me.food$) - 1
                If InStr(Me.food$(i, 0), searchString, CompareMethod.Text) <> 0 Or InStr(Me.food$(i, 1), searchString, CompareMethod.Text) > 0 Or InStr(Me.food$(i, 2), searchString, CompareMethod.Text) > 0 Then
                    DisplayListBox.Items.Add(Me.food$(i, 0))
                    DisplayComboBox.Items.Add(Me.food$(i, 2))
                End If

            Next
        Catch ex As Exception
        End Try

        DisplayComboBox.Items.Remove("  ")

    End Sub

    Private Sub CategoryButton_CheckedChanged(sender As Object, e As EventArgs) Handles CategoryButton.CheckedChanged
        DisplayComboBox.Items.Clear()
        For i = LBound(food) To UBound(food) - 1
            If food(i, 2) <> "" And DisplayComboBox.Items.Contains(food(i, 2)) = False Then
                DisplayComboBox.Items.Add(food(i, 2))
            End If
            DisplayComboBox.Sorted = True
        Next
        ComboLabel.Text = "Category"

        DisplayComboBox.Items.Insert(0, " ~Show All~")

    End Sub

    Private Sub AisleButton_CheckedChanged(sender As Object, e As EventArgs) Handles AisleButton.CheckedChanged
        DisplayComboBox.Items.Clear()

        For i = LBound(Me.food$) To UBound(Me.food$) - 1
            If food(i, 1) <> "  " And DisplayComboBox.Items.Contains(food(i, 1)) = False Then
                DisplayComboBox.Items.Add(food(i, 1))
            End If
            DisplayComboBox.Sorted = True
        Next
        ComboLabel.Text = "Aisle"

        DisplayComboBox.Items.Insert(0, " ~Show All~")
    End Sub

    Private Sub SearchBox_TextChanged(sender As Object, e As EventArgs) Handles SearchBox.TextChanged

        If SearchBox.Text = "zzz" Then
            Me.Close()
        End If

    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        AboutForm.Show()
        Me.Hide()
    End Sub

    Private Sub DisplayListBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DisplayListBox.SelectedIndexChanged

        For a = 0 To 255
            For b = 0 To 2
                If DisplayListBox.SelectedItem.ToString = food(a, b) Then
                    DisplayLabel.Text = "You can find " & food(a, b) & " on Aisle " &
                        food(a, b + 1) & " With the " & food(a, b + 2)
                End If

            Next
        Next
    End Sub

    Private Sub DisplayComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DisplayComboBox.SelectedIndexChanged
        For a = 0 To 255
            For b = 0 To 2
                If DisplayListBox.SelectedItem.ToString = food(a, b) Then
                    DisplayLabel.Text = "You can find " & food(a, b) & " on Aisle " &
                        food(a, b + 1) & " With the " & food(a, b + 2)
                End If

            Next
        Next

        For a = 0 To 255
            For b = 0 To 2
                If DisplayListBox.SelectedItem.ToString = food(a, b) Then
                    DisplayListBox.Text = "You can find " & food(a, b) & " on Aisle " &
                        food(a, b + 1) & " With the " & food(a, b + 2)
                End If

            Next
        Next
    End Sub
End Class
