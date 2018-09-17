Imports MySql.Data.MySqlClient
Imports System.Data.OleDb
Imports Excel = Microsoft.Office.Interop.Excel
Imports System
Imports System.IO



Public Class Form1

    Dim readcommand As New MySqlCommand
    Dim tablica_read As String
    Dim adresa As String
    Dim database As String
    Dim username As String
    Dim passwd As String
    Dim excel_path As String
    Dim conn As New MySqlConnection
    Dim sort As String = String.Format("asc")
    Dim dan As Int16

    Public Sub SetMyCustomFormat()
        ' postavi zeljeni format datuma za list picker
        DateTimePicker1.Format = DateTimePickerFormat.Custom
        DateTimePicker1.CustomFormat = "MM.yyyy."
    End Sub

    Public Sub spoji_se()
        conn.ConnectionString = String.Format("server={0};user id = {1};password = {2};database = {3};", adresa, username, passwd, database)
        Try
            conn.Open()
            'MessageBox.Show("Uspješno spojeno", "Brojač posjeta")

        Catch ex As Exception
            MessageBox.Show(String.Format("Nije se moguče spojiti na bazu podataka {0}", ex.Message), "Brojač posjeta")
        End Try
        'ice je car
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ComboBox1.DropDownStyle = ComboBoxStyle.DropDownList

        MaximizeBox = False




        SetMyCustomFormat() 'postavi iznad odredjeni format

        Using sr As New StreamReader("excel_lokacija.txt")


            excel_path = sr.ReadToEnd()

        End Using

        Using sr As New StreamReader("default_baza.txt")


            database = sr.ReadToEnd()

        End Using

        Using sr As New StreamReader("default_adresa.txt")


            adresa = sr.ReadToEnd()

        End Using

        Using sr As New StreamReader("default_username.txt")


            username = sr.ReadToEnd()


        End Using
        Using sr As New StreamReader("default_passwd.txt")


            passwd = sr.ReadToEnd()

        End Using

        spoji_se()


    End Sub







    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles srch_btn.Click

        sort_check()

        '

        Dim SDA As New MySqlDataAdapter
        Dim dbDataSet As New DataTable
        Dim bSource As New BindingSource
        Try


            Dim mjesec As Int16 = DateTimePicker1.Value.Month
            Dim godina As Int16 = DateTimePicker1.Value.Year


            Dim query1 As String = String.Format("USE {0};SELECT * FROM brojac_prometa WHERE MONTH(Datum) = {2} AND YEAR(Datum) ={3}   ORDER BY Datum {1} ", database, sort, mjesec, godina)
            readcommand = New MySqlCommand(query1, conn)
            SDA.SelectCommand = readcommand

            SDA.Fill(dbDataSet)
            bSource.DataSource = dbDataSet
            DataGridView1.DataSource = bSource
            SDA.Update(dbDataSet)


        Catch ex As Exception

            MessageBox.Show(ex.Message, "MySQL User Database")

        End Try
    End Sub

    Private Sub ShowUsers_butt_Click(sender As Object, e As EventArgs) Handles showall_btn.Click


        sort_check()


        Dim SDA As New MySqlDataAdapter
        Dim dbDataSet As New DataTable
        Dim bSource As New BindingSource
        Try

            Dim query1 As String = String.Format("USE {0};SELECT * FROM {1}  ORDER BY Datum {2}", database, "brojac_prometa", sort)
            readcommand = New MySqlCommand(query1, conn)
            SDA.SelectCommand = readcommand

            SDA.Fill(dbDataSet)
            bSource.DataSource = dbDataSet
            DataGridView1.DataSource = bSource
            SDA.Update(dbDataSet)


        Catch ex As Exception

            MessageBox.Show(ex.Message, "MySQL User Database")

        End Try
    End Sub


    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles savetoxml_btn.Click
        DATAGRIDVIEW_TO_EXCEL((DataGridView1))
    End Sub

    'ovo ja nisam pisao tako da ne znam sto sta radi
    Private Sub DATAGRIDVIEW_TO_EXCEL(ByVal DGV As DataGridView)
        Try
            Dim DTB = New DataTable, RWS As Integer, CLS As Integer

            For CLS = 0 To DGV.ColumnCount - 1 ' COLUMNS OF DTB
                DTB.Columns.Add(DGV.Columns(CLS).Name.ToString)
            Next

            Dim DRW As DataRow

            For RWS = 0 To DGV.Rows.Count - 1 ' FILL DTB WITH DATAGRIDVIEW
                DRW = DTB.NewRow

                For CLS = 0 To DGV.ColumnCount - 1
                    Try
                        DRW(DTB.Columns(CLS).ColumnName.ToString) = DGV.Rows(RWS).Cells(CLS).Value.ToString
                    Catch ex As Exception

                    End Try
                Next

                DTB.Rows.Add(DRW)
            Next

            DTB.AcceptChanges()

            Dim DST As New DataSet
            DST.Tables.Add(DTB)
            Dim FLE As String = "C:\Brojac_posjeta" ' PATH AND FILE NAME WHERE THE XML WIL BE CREATED (EXEMPLE: C:\REPS\XML.xml)
            DTB.WriteXml(FLE)
            Dim EXL As String = excel_path ' PATH OF/ EXCEL.EXE IN YOUR MICROSOFT OFFICE
            Shell(Chr(34) & EXL & Chr(34) & " " & Chr(34) & FLE & Chr(34), vbNormalFocus) ' OPEN XML WITH EXCEL

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub

    Private Sub sort_check()

        Dim text As String = ComboBox1.Text

        If text = "Ascending" Then

            sort = "asc"

        ElseIf text = "Descending" Then

            sort = "desc"
        End If

    End Sub

End Class
