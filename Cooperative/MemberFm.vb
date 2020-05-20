
Imports System.Data.Odbc
Imports System.IO
Imports ExcelDataReader

Public Class member_regisFm
	Dim tables As DataTableCollection

	Private Sub member_regisFm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
		sectionShow()

	End Sub

	Public Sub textDT()

		DataGridView1.Columns(0).HeaderText() = "Employee No. (รหัสพนักงาน)"
		DataGridView1.Columns(1).HeaderText() = "Name (ชื่อ)"
		DataGridView1.Columns(2).HeaderText() = "Surname (นามสกุล)"
		DataGridView1.Columns(3).HeaderText() = "Sex (เพศ)"
		DataGridView1.Columns(4).HeaderText() = "Section (แผนก)"
		DataGridView1.Columns(5).HeaderText() = "Status (สถานะ)"
		DataGridView1.Columns(6).HeaderText() = "Comment (อื่นๆ)"

	End Sub

	Public Sub clear_member()
		employeeTb.Text = ""
		nameTb.Text = ""
		surnameTb.Text = ""
		sexCb.Text = ""
		'sectionCb.Text = ""
		statusCb.Text = ""
		commentTb.Text = ""
	End Sub

	Public Sub cancelBt_Click(sender As System.Object, e As System.EventArgs) Handles cancelBt.Click
		clear_member()
	End Sub


	Private Sub searchBt_Click(sender As System.Object, e As System.EventArgs) Handles searchBt.Click
		Dim query As String = "SELECT * FROM MemberRegTb WHERE Member_No = '" & employeeTb.Text & "'"
		Dim con As OdbcConnection = New OdbcConnection("Dsn=Cooper_odbc;uid=sa;pwd=sa;")
		Dim cmd As OdbcCommand = New OdbcCommand(query, con)
		Dim da As New OdbcDataAdapter(cmd)
		Dim dt As New DataTable

		con.Open()

		da.Fill(dt)
		If dt.Rows.Count > 0 Then
			employeeTb.Text = dt.Rows(0)("Member_No").ToString
			nameTb.Text = dt.Rows(0)("Member_Name").ToString
			surnameTb.Text = dt.Rows(0)("Member_Surname").ToString
			sexCb.Text = dt.Rows(0)("Member_Sex").ToString
			sectionCb.Text = dt.Rows(0)("Member_Section").ToString
			statusCb.Text = dt.Rows(0)("Member_Status").ToString
			commentTb.Text = dt.Rows(0)("Member_Comment").ToString
		Else
			MessageBox.Show("Employee No. does not exist. Please check again.", "Cooperative", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
		End If


		con.Close()

	End Sub

	Private Sub addBt_Click(sender As System.Object, e As System.EventArgs) Handles addBt.Click
		Try

			Dim query As String = "INSERT INTO MemberRegTb VALUES " _
							& "('" & employeeTb.Text & "', '" & nameTb.Text & "', '" & surnameTb.Text & "', '" & sexCb.Text & "', " _
							& "'" & sectionCb.Text & "', '" & statusCb.Text & "', '" & commentTb.Text & "')"
			Dim con As OdbcConnection = New OdbcConnection("Dsn=Cooper_odbc;uid=sa;pwd=sa;")
			Dim cmd As OdbcCommand = New OdbcCommand(query, con)

			con.Open()

			If employeeTb.Text = "" Then
				MessageBox.Show("Employee No. must be not blank.", "Cooperative", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
			Else
				If MessageBox.Show("Do you want to Add?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
					With cmd
						.Parameters.AddWithValue("Member_No", employeeTb.Text)
						.Parameters.AddWithValue("Member_Name", nameTb.Text)
						.Parameters.AddWithValue("Member_Surname", surnameTb.Text)
						.Parameters.AddWithValue("Member_Sex", sexCb.Text)
						.Parameters.AddWithValue("Member_Section", sectionCb.Text)
						.Parameters.AddWithValue("Member_Status", statusCb.Text)
						.Parameters.AddWithValue("Member_Comment", commentTb.Text)
						.ExecuteNonQuery()
						.Parameters.Clear()
					End With
					MessageBox.Show("Successfully Added", "Cooperative", MessageBoxButtons.OK, MessageBoxIcon.None)
					clear_member()
					refresh_datagrid()
				End If
			End If

			con.Close()

		Catch ex As Exception
			MessageBox.Show("Incorrect or Duplicate data Please check again.", "Cooperative", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
		End Try

	End Sub

	Private Sub updateBt_Click(sender As System.Object, e As System.EventArgs) Handles updateBt.Click
		Dim query As String = "UPDATE MemberRegTb SET Member_Name = '" & nameTb.Text & "', Member_Surname = '" & surnameTb.Text & "'," _
							& "Member_Sex = '" & sexCb.Text & "', Member_Section = '" & sectionCb.Text & "', Member_Status = '" & statusCb.Text & "'," _
							& "Member_Comment = '" & commentTb.Text & "' WHERE Member_No = '" & employeeTb.Text & "'"
		Dim con As OdbcConnection = New OdbcConnection("Dsn=Cooper_odbc;uid=sa;pwd=sa;")
		Dim cmd As OdbcCommand = New OdbcCommand(query, con)

		con.Open()

		If employeeTb.Text = "" Then
			MessageBox.Show("Employee No. must be not blank.", "Cooperative", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
		Else
			If MessageBox.Show("Do you want to Update?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
				With cmd
					.Parameters.AddWithValue("Member_No", employeeTb.Text)
					.Parameters.AddWithValue("Member_Name", nameTb.Text)
					.Parameters.AddWithValue("Member_Surname", surnameTb.Text)
					.Parameters.AddWithValue("Member_Sex", sexCb.Text)
					.Parameters.AddWithValue("Member_Section", sectionCb.Text)
					.Parameters.AddWithValue("Member_Status", statusCb.Text)
					.Parameters.AddWithValue("Member_Comment", commentTb.Text)
					.ExecuteNonQuery()
					.Parameters.Clear()
				End With
				MessageBox.Show("Successfully Updated", "Cooperative", MessageBoxButtons.OK, MessageBoxIcon.None)
				clear_member()
				refresh_datagrid()
			End If
		End If

		con.Close()
	End Sub

	Private Sub deleteBt_Click(sender As System.Object, e As System.EventArgs) Handles deleteBt.Click
		Dim query As String = "DELETE FROM MemberRegTb WHERE Member_No = '" & employeeTb.Text & "'"
		Dim con As OdbcConnection = New OdbcConnection("Dsn=Cooper_odbc;uid=sa;pwd=sa;")
		Dim cmd As OdbcCommand = New OdbcCommand(query, con)

		con.Open()

		If employeeTb.Text = "" Then
			MessageBox.Show("Member ID and ID Card must be not blank.", "Cooperative", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
		Else
			If MessageBox.Show("Do you want to Add?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
				With cmd
					.Parameters.AddWithValue("Member_No", employeeTb.Text)
					.ExecuteNonQuery()
					.Parameters.Clear()
				End With
				MessageBox.Show("Successfully Updated", "Cooperative", MessageBoxButtons.OK, MessageBoxIcon.None)
				clear_member()
				refresh_datagrid()
			End If
		End If

		con.Close()
	End Sub

	Private Sub deletedbBt_Click(sender As Object, e As EventArgs) Handles deletedbBt.Click
		Dim query As String = "DELETE FROM MemberRegTb"
		Dim con As OdbcConnection = New OdbcConnection("Dsn=Cooper_odbc;uid=sa;pwd=sa;")
		Dim cmd As OdbcCommand = New OdbcCommand(query, con)

		con.Open()
		If MessageBox.Show("Do you want to Delete all Member Data?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
			With cmd
				.ExecuteNonQuery()
				.Parameters.Clear()
			End With
			MessageBox.Show("Successfully Deleted all Member Data in Database", "Cooperative", MessageBoxButtons.OK, MessageBoxIcon.None)
			refresh_datagrid()
		End If


		con.Close()

	End Sub

	Public Sub resetdv()

		With DataGridView1
			.DataSource = Nothing
			.DataSource = Me.MemberClassBindingSource
			.Refresh()
		End With
	End Sub

	Private Sub refreshBt_Click(sender As Object, e As EventArgs) Handles refreshBt.Click
		refresh_datagrid()
	End Sub
	Public Sub refresh_datagrid()
		Dim query As String = "SELECT * FROM MemberRegTb"
		Dim con As OdbcConnection = New OdbcConnection("Dsn=Cooper_odbc;uid=sa;pwd=sa;")

		Dim da As New OdbcDataAdapter(query, con)
		Dim ds As DataSet = New DataSet

		con.Open()
		da.Fill(ds)
		DataGridView1.DataSource = ds.Tables(0)
		textDT()
		con.Close()

	End Sub

	Private Sub downloaddataBt_Click(sender As System.Object, e As System.EventArgs) Handles downloaddataBt.Click

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

	Private Sub sheetCb_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles sheetCb.SelectedIndexChanged
		Try

			Dim dt As DataTable = tables(sheetCb.SelectedItem.ToString())
			If dt IsNot Nothing Then
				Dim list As List(Of MemberClass) = New List(Of MemberClass)()
				For i As Integer = 0 To dt.Rows.Count - 1
					Dim member As New MemberClass()
					With member
						.Member_No = dt.Rows(i)(0).ToString()
						.Member_Name = dt.Rows(i)(1).ToString()
						.Member_Surname = dt.Rows(i)(2).ToString()
						.Member_Sex = dt.Rows(i)(3).ToString()
						.Member_Section = dt.Rows(i)(4).ToString()
						.Member_Status = dt.Rows(i)(5).ToString()
						.Member_Comment = dt.Rows(i)(6).ToString()
					End With
				Next
				MemberClassBindingSource.DataSource = list
				DataGridView1.DataSource = dt
				textDT()
			End If

		Catch ex As Exception

		End Try

	End Sub

	Private Sub importBt_Click(sender As System.Object, e As System.EventArgs) Handles importBt.Click
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
						.CommandText = "INSERT INTO MemberRegTb VALUES " _
										& "('" & DataGridView1.Rows(i).Cells(0).Value & "', " _
										& "'" & DataGridView1.Rows(i).Cells(1).Value & "', " _
										& "'" & DataGridView1.Rows(i).Cells(2).Value & "', " _
										& "'" & DataGridView1.Rows(i).Cells(3).Value & "', " _
										& "'" & DataGridView1.Rows(i).Cells(4).Value & "', " _
										& "'" & DataGridView1.Rows(i).Cells(5).Value & "', " _
										& "'" & DataGridView1.Rows(i).Cells(6).Value & "')"
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

	Private Sub clearBt_Click(sender As Object, e As EventArgs) Handles clearBt.Click

		filenameTb.Clear()
		sheetCb.Items.Clear()
		DataGridView1.DataSource.Clear()

	End Sub

	Private Sub showsectionBt_Click(sender As Object, e As EventArgs) Handles showsectionBt.Click
		sectionFm.Show()
	End Sub

	Public Sub sectionShow()
		Dim query As String = "SELECT Section_Name FROM SectionTb"
		Dim con As OdbcConnection = New OdbcConnection("Dsn=Cooper_odbc;uid=sa;pwd=sa;")
		Dim da As OdbcDataAdapter = New OdbcDataAdapter(query, con)
		Dim ds As DataSet = New DataSet
		da.Fill(ds)
		With sectionCb
			.DataSource = ds.Tables(0)
			.DisplayMember = "Section_Name"
			.ValueMember = "Section_Name"
		End With
	End Sub

	Private Sub Search_TB_TextChanged(sender As Object, e As EventArgs) Handles Search_TB.TextChanged
		Dim query As String = "SELECT * FROM MemberRegTb WHERE Member_No LIKE '%" & Search_TB.Text & "%' " _
							& "OR Member_Name LIKE '%" & Search_TB.Text & "%' " _
							& "OR Member_Surname LIKE '%" & Search_TB.Text & "%' " _
							& "OR Member_Sex LIKE '%" & Search_TB.Text & "' " _
							& "OR Member_Section LIKE '%" & Search_TB.Text & "' " _
							& "OR Member_Status LIKE '%" & Search_TB.Text & "'"
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



