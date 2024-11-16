Imports Microsoft.Office.Interop.Excel
Imports System.Runtime.InteropServices

Public Class Form1
    Private dtMembers As New DataTable
    Private isEditing As Boolean = False
    Private editingRowIndex As Integer = -1
    Private excelData As Object

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Initialize DataTable columns
        dtMembers.Columns.AddRange(New DataColumn() {
            New DataColumn("Name", GetType(String)),
            New DataColumn("Age", GetType(Integer)),
            New DataColumn("Address", GetType(String)),
            New DataColumn("DateOfBirth", GetType(Date)),
            New DataColumn("Religion", GetType(String)),
            New DataColumn("Phone", GetType(String)),
            New DataColumn("Email", GetType(String)),
            New DataColumn("Occupation", GetType(String)),
            New DataColumn("PaymentMethod", GetType(String)),
            New DataColumn("BankAccount", GetType(String)),
            New DataColumn("Reason", GetType(String))
        })

        ' Set DataGridView properties
        dgvMembers.DataSource = dtMembers
        dgvMembers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
    End Sub

    Private Sub ClearFields()
        txtName.Clear()
        txtAge.Clear()
        txtAddress.Clear()
        dtpDateOfBirth.Value = Date.Today
        txtReligion.Clear()
        txtPhone.Clear()
        txtEmail.Clear()
        txtOccupation.Clear()
        cboPaymentMethod.SelectedIndex = -1
        txtBankAccount.Clear()
        txtReason.Clear()
    End Sub

    Private Function ValidateInputs() As Boolean
        If String.IsNullOrWhiteSpace(txtName.Text) Then
            MessageBox.Show("Please enter a name.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If

        Dim age As Integer
        If Not Integer.TryParse(txtAge.Text, age) OrElse age <= 0 Then
            MessageBox.Show("Please enter a valid age.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If

        If String.IsNullOrWhiteSpace(txtAddress.Text) Then
            MessageBox.Show("Please enter an address.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If

        Return True
    End Function

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If Not ValidateInputs() Then Return

        If isEditing Then
            ' Update existing row
            dtMembers.Rows(editingRowIndex)("Name") = txtName.Text
            dtMembers.Rows(editingRowIndex)("Age") = Integer.Parse(txtAge.Text)
            dtMembers.Rows(editingRowIndex)("Address") = txtAddress.Text
            dtMembers.Rows(editingRowIndex)("DateOfBirth") = dtpDateOfBirth.Value
            dtMembers.Rows(editingRowIndex)("Religion") = txtReligion.Text
            dtMembers.Rows(editingRowIndex)("Phone") = txtPhone.Text
            dtMembers.Rows(editingRowIndex)("Email") = txtEmail.Text
            dtMembers.Rows(editingRowIndex)("Occupation") = txtOccupation.Text
            dtMembers.Rows(editingRowIndex)("PaymentMethod") = If(cboPaymentMethod.SelectedItem IsNot Nothing, cboPaymentMethod.SelectedItem.ToString(), "")
            dtMembers.Rows(editingRowIndex)("BankAccount") = txtBankAccount.Text
            dtMembers.Rows(editingRowIndex)("Reason") = txtReason.Text

            btnAdd.Text = "Add Member"
            isEditing = False
            editingRowIndex = -1
        Else
            ' Add new row
            dtMembers.Rows.Add(
                txtName.Text,
                Integer.Parse(txtAge.Text),
                txtAddress.Text,
                dtpDateOfBirth.Value,
                txtReligion.Text,
                txtPhone.Text,
                txtEmail.Text,
                txtOccupation.Text,
                If(cboPaymentMethod.SelectedItem IsNot Nothing, cboPaymentMethod.SelectedItem.ToString(), ""),
                txtBankAccount.Text,
                txtReason.Text
            )
        End If

        ClearFields()
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If dgvMembers.SelectedRows.Count = 0 Then
            MessageBox.Show("Please select a member to edit.", "Edit Member", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        Dim row = dgvMembers.SelectedRows(0)
        editingRowIndex = row.Index

        ' Fill fields with selected row data
        txtName.Text = row.Cells("Name").Value.ToString()
        txtAge.Text = row.Cells("Age").Value.ToString()
        txtAddress.Text = row.Cells("Address").Value.ToString()
        dtpDateOfBirth.Value = CDate(row.Cells("DateOfBirth").Value)
        txtReligion.Text = row.Cells("Religion").Value.ToString()
        txtPhone.Text = row.Cells("Phone").Value.ToString()
        txtEmail.Text = row.Cells("Email").Value.ToString()
        txtOccupation.Text = row.Cells("Occupation").Value.ToString()
        cboPaymentMethod.SelectedItem = row.Cells("PaymentMethod").Value.ToString()
        txtBankAccount.Text = row.Cells("BankAccount").Value.ToString()
        txtReason.Text = row.Cells("Reason").Value.ToString()

        btnAdd.Text = "Update Member"
        isEditing = True
    End Sub

    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
        If dgvMembers.SelectedRows.Count = 0 Then
            MessageBox.Show("Please select a member to remove.", "Remove Member", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        If MessageBox.Show("Are you sure you want to remove this member?", "Confirm Remove", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            dgvMembers.Rows.RemoveAt(dgvMembers.SelectedRows(0).Index)
        End If
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        Try
            Dim printDoc As New Printing.PrintDocument()
            AddHandler printDoc.PrintPage, AddressOf PrintDocument_PrintPage

            Dim printDialog As New PrintDialog()
            printDialog.Document = printDoc

            If printDialog.ShowDialog() = DialogResult.OK Then
                printDoc.Print()
            End If
        Catch ex As Exception
            MessageBox.Show("Error printing: " & ex.Message, "Print Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub PrintDocument_PrintPage(sender As Object, e As Printing.PrintPageEventArgs)
        Try
            ' Print logic here
            Dim format As New StringFormat
            format.Alignment = StringAlignment.Near
            format.LineAlignment = StringAlignment.Center

            Dim rect As New Rectangle(50, 50, e.MarginBounds.Width, 40)
            e.Graphics.DrawString("Membership List", New Font("Arial", 20, FontStyle.Bold), Brushes.Black, rect, format)

            Dim yPos As Integer = 100
            Dim font As New Font("Arial", 12)

            ' Print column headers
            For Each col As DataGridViewColumn In dgvMembers.Columns
                e.Graphics.DrawString(col.HeaderText, font, Brushes.Black, 50 + col.Index * 200, yPos)
            Next

            yPos += 30

            ' Print rows
            For Each row As DataGridViewRow In dgvMembers.Rows
                For Each cell As DataGridViewCell In row.Cells
                    e.Graphics.DrawString(cell.Value.ToString(), font, Brushes.Black, 50 + cell.ColumnIndex * 200, yPos)
                Next
                yPos += 30
            Next
        Catch ex As Exception
            MessageBox.Show("Error during printing: " & ex.Message, "Print Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnExport_Click(sender As Object, e As EventArgs) Handles btnExport.Click
        Try
            If dtMembers.Rows.Count = 0 Then
                MessageBox.Show("No data to export.", "Export Data", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Return
            End If

            Dim saveDialog As New SaveFileDialog()
            saveDialog.Filter = "CSV Files (*.csv)|*.csv"
            saveDialog.Title = "Export to CSV"
            saveDialog.FileName = "MembershipList.csv"

            If saveDialog.ShowDialog() = DialogResult.OK Then
                Using writer As New IO.StreamWriter(saveDialog.FileName)
                    ' Write headers
                    Dim headers = dtMembers.Columns.Cast(Of DataColumn)().Select(Function(column) column.ColumnName)
                    writer.WriteLine(String.Join(",", headers))

                    ' Write data rows
                    For Each row As DataRow In dtMembers.Rows
                        Dim fields = row.ItemArray.Select(Function(field) field.ToString())
                        writer.WriteLine(String.Join(",", fields))
                    Next
                End Using

                MessageBox.Show("Data exported successfully!", "Export Complete", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show("Error exporting data: " & ex.Message, "Export Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnImport_Click(sender As Object, e As EventArgs) Handles btnImport.Click
        Try
            Dim openDialog As New OpenFileDialog()
            openDialog.Filter = "CSV Files (*.csv)|*.csv"
            openDialog.Title = "Import from Excel or CSV"

            If openDialog.ShowDialog() = DialogResult.OK Then
                ' Clear existing data
                dtMembers.Rows.Clear()

                Using reader As New IO.StreamReader(openDialog.FileName)
                    ' Skip header row
                    reader.ReadLine()

                    ' Read data rows
                    While Not reader.EndOfStream
                        Dim fields = reader.ReadLine().Split(","c)
                        If fields.Length = dtMembers.Columns.Count Then
                            Dim newRow As DataRow = dtMembers.NewRow()
                            For i As Integer = 0 To fields.Length - 1
                                Select Case dtMembers.Columns(i).DataType
                                    Case GetType(Integer)
                                        newRow(i) = Integer.Parse(fields(i))
                                    Case GetType(Date)
                                        newRow(i) = Date.Parse(fields(i))
                                    Case Else
                                        newRow(i) = fields(i)
                                End Select
                            Next
                            dtMembers.Rows.Add(newRow)
                        End If
                    End While
                End Using

                MessageBox.Show("Data imported successfully!", "Import Complete", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show("Error importing data: " & ex.Message, "Import Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim searchTerm As String = txtSearch.Text.Trim().ToLower()
        Dim foundRows As New List(Of DataGridViewRow)

        For Each row As DataGridViewRow In dgvMembers.Rows
            For Each cell As DataGridViewCell In row.Cells
                If cell.Value IsNot Nothing AndAlso cell.Value.ToString().ToLower().Contains(searchTerm) Then
                    foundRows.Add(row)
                    Exit For
                End If
            Next
        Next

        If foundRows.Count = 0 Then
            MessageBox.Show("No results found.", "Search", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf foundRows.Count = 1 Then
            foundRows(0).Selected = True
            dgvMembers.FirstDisplayedScrollingRowIndex = foundRows(0).Index
        Else
            Dim resultMessage As String = "Multiple results found:" & Environment.NewLine
            For Each row In foundRows
                resultMessage &= "Name: " & row.Cells("Name").Value.ToString() & ", Age: " & row.Cells("Age").Value.ToString() & Environment.NewLine
            Next
            MessageBox.Show(resultMessage, "Search Results", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        If Not ValidateInputs() Then Return

        If isEditing Then
            ' Update existing row
            dtMembers.Rows(editingRowIndex)("Name") = txtName.Text
            dtMembers.Rows(editingRowIndex)("Age") = Integer.Parse(txtAge.Text)
            dtMembers.Rows(editingRowIndex)("Address") = txtAddress.Text
            dtMembers.Rows(editingRowIndex)("DateOfBirth") = dtpDateOfBirth.Value
            dtMembers.Rows(editingRowIndex)("Religion") = txtReligion.Text
            dtMembers.Rows(editingRowIndex)("Phone") = txtPhone.Text
            dtMembers.Rows(editingRowIndex)("Email") = txtEmail.Text
            dtMembers.Rows(editingRowIndex)("Occupation") = txtOccupation.Text
            dtMembers.Rows(editingRowIndex)("PaymentMethod") = If(cboPaymentMethod.SelectedItem IsNot Nothing, cboPaymentMethod.SelectedItem.ToString(), "")
            dtMembers.Rows(editingRowIndex)("BankAccount") = txtBankAccount.Text
            dtMembers.Rows(editingRowIndex)("Reason") = txtReason.Text

            btnAdd.Text = "Add Member"
            isEditing = False
            editingRowIndex = -1
        Else
            ' Add new row
            dtMembers.Rows.Add(
                txtName.Text,
                Integer.Parse(txtAge.Text),
                txtAddress.Text,
                dtpDateOfBirth.Value,
                txtReligion.Text,
                txtPhone.Text,
                txtEmail.Text,
                txtOccupation.Text,
                If(cboPaymentMethod.SelectedItem IsNot Nothing, cboPaymentMethod.SelectedItem.ToString(), ""),
                txtBankAccount.Text,
                txtReason.Text
            )
        End If

        ClearFields()
    End Sub

    Private Sub Label11_Click(sender As Object, e As EventArgs) Handles Label11.Click

    End Sub

    Private Sub PictureBox9_Click(sender As Object, e As EventArgs) Handles PictureBox9.Click
        Dim searchTerm As String = txtSearch.Text.Trim().ToLower()
        Dim foundRows As New List(Of DataGridViewRow)

        For Each row As DataGridViewRow In dgvMembers.Rows
            For Each cell As DataGridViewCell In row.Cells
                If cell.Value IsNot Nothing AndAlso cell.Value.ToString().ToLower().Contains(searchTerm) Then
                    foundRows.Add(row)
                    Exit For
                End If
            Next
        Next

        If foundRows.Count = 0 Then
            MessageBox.Show("No results found.", "Search", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf foundRows.Count = 1 Then
            foundRows(0).Selected = True
            dgvMembers.FirstDisplayedScrollingRowIndex = foundRows(0).Index
        Else
            Dim resultMessage As String = "Multiple results found:" & Environment.NewLine
            For Each row In foundRows
                resultMessage &= "Name: " & row.Cells("Name").Value.ToString() & ", Age: " & row.Cells("Age").Value.ToString() & Environment.NewLine
            Next
            MessageBox.Show(resultMessage, "Search Results", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        If dgvMembers.SelectedRows.Count = 0 Then
            MessageBox.Show("Please select a member to edit.", "Edit Member", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        Dim row = dgvMembers.SelectedRows(0)
        editingRowIndex = row.Index

        ' Fill fields with selected row data
        txtName.Text = row.Cells("Name").Value.ToString()
        txtAge.Text = row.Cells("Age").Value.ToString()
        txtAddress.Text = row.Cells("Address").Value.ToString()
        dtpDateOfBirth.Value = CDate(row.Cells("DateOfBirth").Value)
        txtReligion.Text = row.Cells("Religion").Value.ToString()
        txtPhone.Text = row.Cells("Phone").Value.ToString()
        txtEmail.Text = row.Cells("Email").Value.ToString()
        txtOccupation.Text = row.Cells("Occupation").Value.ToString()
        cboPaymentMethod.SelectedItem = row.Cells("PaymentMethod").Value.ToString()
        txtBankAccount.Text = row.Cells("BankAccount").Value.ToString()
        txtReason.Text = row.Cells("Reason").Value.ToString()

        btnAdd.Text = "Update Member"
        isEditing = True
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        If dgvMembers.SelectedRows.Count = 0 Then
            MessageBox.Show("Please select a member to remove.", "Remove Member", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        If MessageBox.Show("Are you sure you want to remove this member?", "Confirm Remove", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            dgvMembers.Rows.RemoveAt(dgvMembers.SelectedRows(0).Index)
        End If
    End Sub

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click
        Try
            Dim printDoc As New Printing.PrintDocument()
            AddHandler printDoc.PrintPage, AddressOf PrintDocument_PrintPage

            Dim printDialog As New PrintDialog()
            printDialog.Document = printDoc

            If printDialog.ShowDialog() = DialogResult.OK Then
                printDoc.Print()
            End If
        Catch ex As Exception
            MessageBox.Show("Error printing: " & ex.Message, "Print Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub PictureBox7_Click(sender As Object, e As EventArgs) Handles PictureBox7.Click
        Try
            If dtMembers.Rows.Count = 0 Then
                MessageBox.Show("No data to export.", "Export Data", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Return
            End If

            Dim saveDialog As New SaveFileDialog()
            saveDialog.Filter = "CSV Files (*.csv)|*.csv"
            saveDialog.Title = "Export to CSV"
            saveDialog.FileName = "MembershipList.csv"

            If saveDialog.ShowDialog() = DialogResult.OK Then
                Using writer As New IO.StreamWriter(saveDialog.FileName)
                    ' Write headers
                    Dim headers = dtMembers.Columns.Cast(Of DataColumn)().Select(Function(column) column.ColumnName)
                    writer.WriteLine(String.Join(",", headers))

                    ' Write data rows
                    For Each row As DataRow In dtMembers.Rows
                        Dim fields = row.ItemArray.Select(Function(field) field.ToString())
                        writer.WriteLine(String.Join(",", fields))
                    Next
                End Using

                MessageBox.Show("Data exported successfully!", "Export Complete", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show("Error exporting data: " & ex.Message, "Export Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub PictureBox8_Click(sender As Object, e As EventArgs) Handles PictureBox8.Click
        Try
            Dim openDialog As New OpenFileDialog()
            openDialog.Filter = "CSV Files (*.csv)|*.csv"
            openDialog.Title = "Import from Excel or CSV"

            If openDialog.ShowDialog() = DialogResult.OK Then
                ' Clear existing data
                dtMembers.Rows.Clear()

                Using reader As New IO.StreamReader(openDialog.FileName)
                    ' Skip header row
                    reader.ReadLine()

                    ' Read data rows
                    While Not reader.EndOfStream
                        Dim fields = reader.ReadLine().Split(","c)
                        If fields.Length = dtMembers.Columns.Count Then
                            Dim newRow As DataRow = dtMembers.NewRow()
                            For i As Integer = 0 To fields.Length - 1
                                Select Case dtMembers.Columns(i).DataType
                                    Case GetType(Integer)
                                        newRow(i) = Integer.Parse(fields(i))
                                    Case GetType(Date)
                                        newRow(i) = Date.Parse(fields(i))
                                    Case Else
                                        newRow(i) = fields(i)
                                End Select
                            Next
                            dtMembers.Rows.Add(newRow)
                        End If
                    End While
                End Using

                MessageBox.Show("Data imported successfully!", "Import Complete", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show("Error importing data: " & ex.Message, "Import Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        AboutBox1.Show()
    End Sub
End Class
