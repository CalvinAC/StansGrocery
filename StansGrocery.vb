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

        'Splits the array 
        temp = Split(My.Resources.Grocery, vbLf)

        For i = LBound(temp) To UBound(temp) - 1
            'Creates second array from the first split array
            'Sorts by commas
            secondArray = Split(temp(i), Chr(34) & "," & Chr(34))
            'Creates a third array, filters items from textfile by "$$ITM"
            'Stores filtered items into the thirdarray
            thirdArray = Split(secondArray(0), "$$ITM")
            Console.Write(thirdArray(1))
            'The thirdarray is sent to the global food array
            Me.food$(i, 0) = thirdArray(1)
            'Filters items from textfile by "##LOC"
            thirdArray = Split(secondArray(1), "##LOC")
            Console.Write(thirdArray(1))
            Me.food$(i, 1) = thirdArray(1).PadLeft(2)
            'Filters items from textfile by "%%CAT"
            thirdArray = Split(secondArray(2), "%%CAT")
            thirdArray = Split(thirdArray(1), Chr(34))
            Console.WriteLine(thirdArray(0))
            Me.food$(i, 2) = thirdArray(0)
        Next

    End Sub

    Sub LoadListBox()

        For i = LBound(Me.food$) To UBound(Me.food$) - 1

            'Loads the list box with the data stored in food array
            If food(i, 0) <> "" And DisplayListBox.Items.Contains(food(i, 0)) = False Then
                DisplayListBox.Items.Add(food(i, 0))
            End If
            DisplayListBox.Sorted = True

        Next
    End Sub

    Private Sub StansGrocery_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadDataArray()
        LoadListBox()
        CategoryButton.Checked = True
    End Sub

    Private Sub SearchButton_Click(sender As Object, e As EventArgs) Handles SearchButton.Click, SearchToolStripMenuItem.Click

        DisplayListBox.Items.Clear()
        Dim searchString As String = SearchBox.Text

        Try
            For i = LBound(Me.food$) To UBound(Me.food$) - 1
                'Compares text of the search box with any matching text in the food array and displays it into the listbox
                If InStr(Me.food$(i, 0), searchString, CompareMethod.Text) <> 0 Or InStr(Me.food$(i, 2), searchString, CompareMethod.Text) > 0 Then
                    DisplayListBox.Items.Add(Me.food$(i, 0))
                End If

            Next
        Catch ex As Exception
        End Try

    End Sub

    Private Sub CategoryButton_CheckedChanged(sender As Object, e As EventArgs) Handles CategoryButton.CheckedChanged

        'Loads data from the 3rd column of the food array into the combo box
        If CategoryButton.Checked = True Then
            DisplayComboBox.Items.Clear()
            For i = LBound(food) To UBound(food) - 1
                If food(i, 2) <> "" And DisplayComboBox.Items.Contains(food(i, 2)) = False Then
                    DisplayComboBox.Items.Add(food(i, 2))
                End If
                DisplayComboBox.Sorted = True
            Next
            ComboLabel.Text = "Category"
            DisplayComboBox.Items.Insert(0, " ~Show All~") ' Select this after load
        Else

        End If


    End Sub

    Private Sub AisleButton_CheckedChanged(sender As Object, e As EventArgs) Handles AisleButton.CheckedChanged

        'Loads data from the 2nd cloumn of the food array into the combo box
        If AisleButton.Checked = True Then
            DisplayComboBox.Items.Clear()
            For i = LBound(Me.food$) To UBound(Me.food$) - 1
                If food(i, 1) <> "  " And DisplayComboBox.Items.Contains(food(i, 1)) = False Then
                    DisplayComboBox.Items.Add(food(i, 1))
                End If
                DisplayComboBox.Sorted = True
            Next
            ComboLabel.Text = "Aisle"
            DisplayComboBox.Items.Insert(0, " ~Show All~")
        Else

        End If
    End Sub

    Private Sub SearchBox_TextChanged(sender As Object, e As EventArgs) Handles SearchBox.TextChanged


        DisplayLabel.Text = Nothing
        If SearchBox.TextLength = 1 Then
            DisplayLabel.Text = "Please be more specific."
        ElseIf SearchBox.Text = "zzz" Then
            Me.Close()
        Else
        End If

    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        AboutForm.Show()
        Me.Hide()
    End Sub

    Private Sub DisplayComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DisplayComboBox.SelectedIndexChanged

        'Loads the combo box based on which radio button is selected
        DisplayListBox.Items.Clear()
        If CategoryButton.Checked = True Then
            For i = LBound(Me.food$) To UBound(Me.food$) - 1
                If DisplayComboBox.SelectedItem.ToString = food(i, 2) Then ' Show All does not show all items -TJR
                    DisplayListBox.Items.Add(food(i, 0))
                End If
            Next

        ElseIf AisleButton.Checked = True Then
            For i = LBound(Me.food$) To UBound(Me.food$) - 1
                If DisplayComboBox.SelectedItem.ToString = food(i, 1) Then
                    DisplayListBox.Items.Add(food(i, 0))
                End If
            Next

        End If

    End Sub

    Private Sub DisplayListBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DisplayListBox.SelectedIndexChanged

        'Iterates through the food array 
        For a = 0 To 255
            For b = 0 To 2
                'Searches for item selcted in the display box
                If DisplayListBox.SelectedItem.ToString = food(a, b) Then
                    'Displays text telling where to find the item
                    DisplayLabel.Text = "You will find " & food(a, b) & " on Aisle " &
                        food(a, b + 1) & " With the " & food(a, b + 2)
                End If

            Next
        Next
    End Sub

    Private Sub SelectFormToolStripMenuItem_Click(sender As Object, e As EventArgs)
        SplashScreenForm.Show()
    End Sub
End Class
