
Imports System.Data.Odbc
Imports System.IO
Imports ExcelDataReader

Public Class sectionFm

    Dim tables As DataTableCollection

    Private Sub sectionFm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Public Sub textDT()

        DataGridView1.Columns(0).HeaderText() = "Section No. (รหัสแผนก)"
        DataGridView1.Columns(1).HeaderText() = "Section Name (ชื่อแผนก)"

    End Sub

    Public Sub clear_section()
        sectionnoTb.Text = ""
        sectionnameTb.Text = ""
    End Sub

    Private Sub clearBt_Click(sender As Object, e As EventArgs) Handles clearBt.Click
        filenameLb.Text = ""
        sheetCb.Text = ""
        DataGridView1.DataSource.clear()
    End Sub

    Private Sub searchBt_Click(sender As Object, e As EventArgs) Handles searchBt.Click
        Dim query As String = "SELECT * FROM SectionTb WHERE Section_No = '" & sectionnoTb.Text & "'"
        Dim con As OdbcConnection = New OdbcConnection("Dsn=Cooper_odbc;uid=sa;pwd=sa;")
        Dim cmd As OdbcCommand = New OdbcCommand(query, con)
        Dim da As New OdbcDataAdapter(cmd)
        Dim dt As New DataTable

        con.Open()

        da.Fill(dt)
        If dt.Rows.Count > 0 Then
            sectionnoTb.Text = dt.Rows(0)("Section_No").ToString
            sectionnameTb.Text = dt.Rows(0)("Section_Name").ToString
        Else
            MessageBox.Show("Section No. does not exist. Please check again.", "Cooperative", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
        End If


        con.Close()
    End Sub

    Private Sub addBt_Click(sender As Object, e As EventArgs) Handles addBt.Click
        Try

            Dim query As String = "INSERT INTO SectionTb (Section_No, Section_Name) VALUES " _
                & "('" & sectionnoTb.Text & "', '" & sectionnameTb.Text & "')"
            Dim con As OdbcConnection = New OdbcConnection("Dsn=Cooper_odbc;uid=sa;pwd=sa;")
            Dim cmd As OdbcCommand = New OdbcCommand(query, con)

            con.Open()

            If sectionnoTb.Text = "" Then
                MessageBox.Show("Section_No. must be not blank.", "Cooperative", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            Else
                If MessageBox.Show("Do you want to Add?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                    With cmd
                        .Parameters.AddWithValue("Section_No", sectionnoTb.Text)
                        .Parameters.AddWithValue("Section_Name", sectionnameTb.Text)
                        .ExecuteNonQuery()
                        .Parameters.Clear()
                    End With
                    MessageBox.Show("Successfully Added", "Cooperative", MessageBoxButtons.OK, MessageBoxIcon.None)
                    clear_section()
                    refresh_datagrid()
                End If
            End If

        Catch ex As Exception
            MessageBox.Show("Incorrect or Duplicate data Please check again.", "Cooperative", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
        End Try

    End Sub

    Private Sub updateBt_Click(sender As Object, e As EventArgs) Handles updateBt.Click
        Dim query As String = "UPDATE SectionTb SET Section_No = '" & sectionnoTb.Text & "', Section_Name = '" & sectionnameTb.Text & "'"
        Dim con As OdbcConnection = New OdbcConnection("Dsn=Cooper_odbc;uid=sa;pwd=sa;")
        Dim cmd As OdbcCommand = New OdbcCommand(query, con)

        con.Open()

        If sectionnoTb.Text = "" Then
            MessageBox.Show("Section_No. must be not blank.", "Cooperative", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
        Else
            If MessageBox.Show("Do you want to Update?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                With cmd
                    .Parameters.AddWithValue("Section_No", sectionnoTb.Text)
                    .Parameters.AddWithValue("Section_Name", sectionnameTb.Text)
                    .ExecuteNonQuery()
                    .Parameters.Clear()
                End With
                MessageBox.Show("Successfully Updated", "Cooperative", MessageBoxButtons.OK, MessageBoxIcon.None)
                clear_section()
                refresh_datagrid()
            End If
        End If

        con.Close()
    End Sub

    Private Sub deleteBt_Click(sender As Object, e As EventArgs) Handles deleteBt.Click
        Dim query As String = "DELETE FROM SectionTb WHERE Section_No = '" & sectionnoTb.Text & "'"
        Dim con As OdbcConnection = New OdbcConnection("Dsn=Cooper_odbc;uid=sa;pwd=sa;")
        Dim cmd As OdbcCommand = New OdbcCommand(query, con)

        con.Open()

        If sectionnoTb.Text = "" Then
            MessageBox.Show("Section_No. must be not blank.", "Cooperative", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
        Else
            If MessageBox.Show("Do you want to Delete?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                With cmd
                    .Parameters.AddWithValue("Section_No", sectionnoTb.Text)
                    .ExecuteNonQuery()
                    .Parameters.Clear()
                End With
                MessageBox.Show("Successfully Deleted", "Cooperative", MessageBoxButtons.OK, MessageBoxIcon.None)
                clear_section()
                refresh_datagrid()
            End If
        End If

        con.Close()
    End Sub

    Private Sub deletedbBt_Click(sender As Object, e As EventArgs) Handles deletedbBt.Click
        Dim query As String = "DELETE FROM SectionTb"
        Dim con As OdbcConnection = New OdbcConnection("Dsn=Cooper_odbc;uid=sa;pwd=sa;")
        Dim cmd As OdbcCommand = New OdbcCommand(query, con)

        con.Open()

        If MessageBox.Show("Do you want to Delete all Section Data?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            With cmd
                .ExecuteNonQuery()
                .Parameters.Clear()
            End With
            MessageBox.Show("Successfully Deleted all Section Data in Database", "Cooperative", MessageBoxButtons.OK, MessageBoxIcon.None)
            clear_section()
            refresh_datagrid()
        End If

        con.Close()
    End Sub

    Private Sub cancelBt_Click(sender As Object, e As EventArgs) Handles cancelBt.Click
        member_regisFm.Show()
        Me.Close()

    End Sub

    Private Sub downloaddataBt_Click(sender As Object, e As EventArgs) Handles downloaddataBt.Click
        Dim ofd As OpenFileDialog = New OpenFileDialog() With {.Filter = "Excel Workbook|*.xlsx|Excel 97-2003 Workbook|*.xls"}
        If ofd.ShowDialog() = DialogResult.OK Then
            filenameTb.Text = ofd.FileName
            Dim stream = File.Open(ofd.FileName, FileMode.Open, FileAccess.Read)
            Dim reader As IExcelDataReader = ExcelReaderFactory.CreateReader(stream)
            Dim result As DataSet = reader.AsDataSet(New ExcelDataSetConfiguration() With {
                                                     .ConfigureDataTable = Function(__) New ExcelDataTableConfiguration() With {
                                                     .UseHeaderRow = True}})

            tables = result.Tables
            sheetCb.Items.Clear()
            For Each table As DataTable In tables
                sheetCb.Items.Add(table.TableName)
            Next
        End If
    End Sub

    Private Sub importBt_Click(sender As Object, e As EventArgs) Handles importBt.Click
        Try
            importBt.Enabled = False
            Application.DoEvents()

            Dim con As OdbcConnection = New OdbcConnection("Dsn=Cooper_odbc;uid=sa;pwd=sa;")
            con.Open()

            Dim cmd As New OdbcCommand

            If filenameTb.Text = "" Or sheetCb.Text = "" Then
                MessageBox.Show("Please download excel data.", "Cooperative", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            Else
                With cmd
                    .Connection = con
                    For i As Integer = 0 To DataGridView1.RowCount - 1
                        .CommandText = "INSERT INTO SectionTb VALUES " _
                                   & "('" & DataGridView1.Rows(i).Cells(0).Value & "', " _
                                   & "'" & DataGridView1.Rows(i).Cells(1).Value & "')"
                        .ExecuteNonQuery()
                    Next
                End With
                MessageBox.Show("Succesfully Imported", "Cooperative", MessageBoxButtons.OK, MessageBoxIcon.None)
            End If

            cmd.Dispose()
            cmd = Nothing

            With con
                .Close()
                .Dispose()
            End With

            importBt.Enabled = True

        Catch ex As Exception
            MessageBox.Show("Incorrect or Duplicate data Please check again.", "Cooperative", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
        End Try
    End Sub

    Private Sub sheetCb_SelectedIndexChanged(sender As Object, e As EventArgs) Handles sheetCb.SelectedIndexChanged
        Try

            Dim dt As DataTable = tables(sheetCb.SelectedItem.ToString())
            If dt IsNot Nothing Then
                Dim list As List(Of SectionClass) = New List(Of SectionClass)()
                For i As Integer = 0 To dt.Rows.Count - 1
                    Dim section As New SectionClass()
                    With section
                        .Section_No = dt.Rows(i)(0).ToString()
                        .Section_Name = dt.Rows(i)(1).ToString()

                    End With
                Next
                SectionClassBindingSource.DataSource = list
                DataGridView1.DataSource = dt
                textDT()
            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub refreshBt_Click(sender As Object, e As EventArgs) Handles refreshBt.Click
        refresh_datagrid()
    End Sub

    Public Sub refresh_datagrid()
        Dim query As String = "SELECT * FROM SectionTb ORDER BY Section_No ASC"
        Dim con As OdbcConnection = New OdbcConnection("Dsn=Cooper_odbc;uid=sa;pwd=sa;")

        Dim da As New OdbcDataAdapter(query, con)
        Dim ds As DataSet = New DataSet

        con.Open()
        da.Fill(ds)
        DataGridView1.DataSource = ds.Tables(0)
        textDT()
        con.Close()

    End Sub

    Private Sub Search_TB_TextChanged(sender As Object, e As EventArgs) Handles Search_TB.TextChanged
        Dim query As String = "SELECT * FROM SectionTb WHERE Section_No LIKE '%" & Search_TB.Text & "%' " _
                              & "OR Section_Name LIKE '%" & Search_TB.Text & "%'"
        Dim con As OdbcConnection = New OdbcConnection("Dsn=Cooper_odbc;uid=sa;pwd=sa;")
        Dim cmd As OdbcCommand = New OdbcCommand(query, con)

        con.Open()
        Dim dr As OdbcDataReader = cmd.ExecuteReader
        Dim dt As DataTable = New DataTable

        Search_TB.Text = Search_TB.Text.Replace("%", "").Replace("'", "").Replace("*", "")

        If Search_TB.Text = "" Or Len(Search_TB.Text) = 0 Then
            Exit Sub
        End If

        dt.Load(dr)
        DataGridView1.DataSource = dt
        dr.Close()
        con.Close()
    End Sub
End Class

